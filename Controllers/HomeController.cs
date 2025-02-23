using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using Recipes.Models;
using Recipes.Models.RecipeModel;

namespace Recepies.Controllers
{
    public class HomeController : Controller
    {
        private readonly RecipeCatalogContext _recipeCatalogContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, RecipeCatalogContext recipeCatalogContext)
        {
            _recipeCatalogContext = recipeCatalogContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var recipes = _recipeCatalogContext.Recipes
                .Include(r => r.Category)
                .Select(r => new IndexViewRecipeModel
                {
                    RecipeId = r.RecipeId,
                    Title = r.Title,
                    Description = r.Description,
                    ImagePath = r.ImagePath,
                    Category = r.Category != null
                                ? new CategoryTagViewModel { Name = r.Category.Name }
                                : null
                })
                .OrderBy(r => Guid.NewGuid())
                .Take(5)
                .ToList();

            return View(recipes);
        }


        public ActionResult Details(int id)
        {
            var recipe = _recipeCatalogContext.Recipes
                .Include(r => r.RecipeIngredients)
                    .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefault(m => m.RecipeId == id);

            if (recipe == null)
                return NotFound();

            return View(recipe);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}