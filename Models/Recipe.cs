namespace Recipes.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CookingTime { get; set; }
        public string? Instructions { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string ImagePath { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>(); // Инициализиране
    }
}
