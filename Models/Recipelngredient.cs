using Microsoft.EntityFrameworkCore;
using Recipes.Models;

public class RecipeIngredient
{
    public int RecipeIngredientId { get; set; }
    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }

    [Precision(18, 2)]
    public decimal Quantity { get; set; }
}
