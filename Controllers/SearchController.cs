using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using Recipes.Models;
using Recipes.Models.RecipeModel;
using System.Collections.Generic;
using System.Linq;

namespace Recipes.Controllers
{
    public class SearchController : Controller
    {
        private readonly RecipeCatalogContext _recipeCatalogContext;

        public SearchController(RecipeCatalogContext recipeCatalogContext)
        {
            _recipeCatalogContext = recipeCatalogContext;
        }

        [HttpGet]
        public JsonResult Autocomplete(string term)
        {
            var recipes = _recipeCatalogContext.Recipes
                .Where(r => EF.Functions.Like(r.Title.ToLower(), $"%{term.ToLower()}%"))
                .Select(r => new { label = r.Title, value = r.RecipeId })
                .ToList();

            return Json(recipes);
        }

        public IActionResult Results(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return View("Results", new List<IndexViewRecipeModel>());
            }

            var recipes = _recipeCatalogContext.Recipes
                .Include(r => r.Category)
                .Where(r => EF.Functions.Like(r.Title, $"%{query}%") ||
                            EF.Functions.Like(r.Description, $"%{query}%") ||
                            EF.Functions.Like(r.Category.Name, $"%{query}%"))
                .Select(r => new IndexViewRecipeModel
                {
                    RecipeId = r.RecipeId,
                    Title = r.Title,
                    Description = r.Description,
                    ImagePath = r.ImagePath,
                    Category = r.Category != null ? new CategoryTagViewModel { Name = r.Category.Name } : null
                })
                .ToList();

            return View("Results", recipes);
        }

        public IActionResult Search(string searchQuery)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {
                return View(new List<IndexViewRecipeModel>());
            }

            var recipes = _recipeCatalogContext.Recipes
                .Include(r => r.Category)
                .Where(r => r.Title.ToLower().Contains(searchQuery.ToLower()) ||
                            EF.Functions.Like(r.Category.Name, $"%{searchQuery}%"))
                .Select(r => new IndexViewRecipeModel
                {
                    RecipeId = r.RecipeId,
                    Title = r.Title,
                    Description = r.Description,
                    ImagePath = r.ImagePath,
                    Category = r.Category != null ? new CategoryTagViewModel { Name = r.Category.Name } : null
                })
                .ToList();

            if (!recipes.Any())
            {
                ViewBag.ErrorMessage = "Няма намерени резултати.";
                return View(new List<IndexViewRecipeModel>());
            }

            return View(recipes);

    }
}
}
