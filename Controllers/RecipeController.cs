using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;  // Необходимо за Include
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Recipes.Data;
using Recipes.Models.RecipeModel;
using System.Linq;  // Необходимо за LINQ

namespace Recipes.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeCatalogContext _recipeCatalogContext;

        public RecipeController(RecipeCatalogContext recipeCatalogContext)
        {
            _recipeCatalogContext = recipeCatalogContext;
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
                .ToList();

            return View(recipes);
        }

        public ActionResult Details(int id)
        {
            var recipe = _recipeCatalogContext.Recipes
                .Include(r => r.Category)
                .Include(r => r.RecipeIngredients)
                    .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefault(m => m.RecipeId == id);

            if (recipe == null)
                return NotFound();

            return View(recipe);
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recipe = _recipeCatalogContext.Recipes
                .FirstOrDefault(m => m.RecipeId == id);

            if (recipe == null)
                return NotFound();

            var model = new EditRecipeViewModel
            {
                RecipeId = recipe.RecipeId,
                Title = recipe.Title,
                Description = recipe.Description,
                CategoryId = recipe.CategoryId
            };

            ViewData["CategoryId"] = new SelectList(_recipeCatalogContext.Categories, "CategoryId", "Name", recipe.CategoryId);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, EditRecipeViewModel model)
        {
            if (id != model.RecipeId)
                return NotFound();

            var recipe = _recipeCatalogContext.Recipes.FirstOrDefault(b => b.RecipeId == id);
            if (recipe == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                recipe.Title = model.Title;
                recipe.CategoryId = model.CategoryId;
                recipe.Description = model.Description;
                _recipeCatalogContext.Update(recipe);
                _recipeCatalogContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryId"] = new SelectList(_recipeCatalogContext.Categories, "CategoryId", "Name", model.CategoryId);
            return View(model);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recipe = _recipeCatalogContext.Recipes
                .FirstOrDefault(m => m.RecipeId == id);

            if (recipe == null)
                return NotFound();

            return View(recipe);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var recipe = _recipeCatalogContext.Recipes.Find(id);
            if (recipe == null)
                return RedirectToAction("Index");

            _recipeCatalogContext.Recipes.Remove(recipe);
            _recipeCatalogContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
