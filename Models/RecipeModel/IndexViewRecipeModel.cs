namespace Recipes.Models.RecipeModel
{
    public class IndexViewRecipeModel
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public CategoryTagViewModel? Category { get; set; } 
    }

    public class CategoryTagViewModel
    {
        public string Name { get; set; }
    }
}
