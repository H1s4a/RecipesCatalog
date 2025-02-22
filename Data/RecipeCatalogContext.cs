using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes.Data
{
    public class RecipeCatalogContext : DbContext
    {
        public RecipeCatalogContext(DbContextOptions<RecipeCatalogContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Предястие" },
                new Category { CategoryId = 2, Name = "Основно" },
                new Category { CategoryId = 3, Name = "Десерт" }
            );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Месо" },
                new Ingredient { IngredientId = 2, Name = "Картофи" },
                new Ingredient { IngredientId = 3, Name = "Зеле" },
                new Ingredient { IngredientId = 4, Name = "Чушки" },
                new Ingredient { IngredientId = 5, Name = "Краставици" },
                new Ingredient { IngredientId = 6, Name = "Сирене" },
                new Ingredient { IngredientId = 7, Name = "Чесън" }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { RecipeId = 1, Title = "Капама", Description = "Задушено зеле с различни видове месо.", CookingTime = "4-5 часа", CategoryId = 2, ImagePath = "/images/kapama.jpg" },
                new Recipe { RecipeId = 2, Title = "Мусака", Description = "Традиционно ястие с картофи и кайма.", CookingTime = "1 час", CategoryId = 2, ImagePath = "/images/musaka.jpg" },
                new Recipe { RecipeId = 3, Title = "Шопска салата", Description = "Домати, краставици, сирене и чушки.", CookingTime = "10-15 минути", CategoryId = 1, ImagePath = "/images/shopska salata.jpg" },
                new Recipe { RecipeId = 4, Title = "Пълнени чушки", Description = "Ястие от чушки, пълнени с кайма и ориз.", CookingTime = "1-2 часа", CategoryId = 2, ImagePath = "/images/pulneni.jpg" },
                new Recipe { RecipeId = 5, Title = "Таратор", Description = "Студена супа от кисело мляко, краставици и чесън.", CookingTime = "10 минути", CategoryId = 1, ImagePath = "/images/tarator.jpg" },
                new Recipe { RecipeId = 6, Title = "Лютеница", Description = "Доматено-пиперена разядка с патладжан и подправки.", CookingTime = "3-4 часа", CategoryId = 3, ImagePath = "/images/l.jpg" },
                new Recipe { RecipeId = 7, Title = "Кавърма", Description = "Ястие от месо, лук и чушки.", CookingTime = "1-2 часа", CategoryId = 2, ImagePath = "/images/kavurma.jpg" },
                new Recipe { RecipeId = 8, Title = "Сарми", Description = "Зелеви или лозови листа с плънка.", CookingTime = "2-3 часа", CategoryId = 2, ImagePath = "/images/sarmi.jpg" },
                new Recipe { RecipeId = 9, Title = "Баница", Description = "Традиционно тестено изделие със сирене.", CookingTime = "1-2 часа", CategoryId = 3, ImagePath = "/images/banica.jpg" }
            );

            modelBuilder.Entity<RecipeIngredient>().HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient { RecipeId = 1, IngredientId = 1, Quantity = 500 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 3, Quantity = 300 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 2, Quantity = 700 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 1, Quantity = 400 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 5, Quantity = 200 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 6, Quantity = 100 }
            );

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId);

            modelBuilder.Entity<RecipeIngredient>()
                .Property(ri => ri.Quantity)
                .HasPrecision(18, 4);
        }
    }
}
