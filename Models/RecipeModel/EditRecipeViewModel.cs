namespace Recipes.Models.RecipeModel
{
    public class EditRecipeViewModel
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
    }
}
