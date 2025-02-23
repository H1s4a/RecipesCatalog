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
                new Ingredient { IngredientId = 7, Name = "Чесън" },
                new Ingredient { IngredientId = 8, Name = "Лук" },
                new Ingredient { IngredientId = 9, Name = "Магданоз" },
                new Ingredient { IngredientId = 10, Name = "Домати" },
                new Ingredient { IngredientId = 11, Name = "Ориз" },
                new Ingredient { IngredientId = 12, Name = "Яйца" },
                new Ingredient { IngredientId = 13, Name = "Кисело мляко" },
                new Ingredient { IngredientId = 14, Name = "Брашно" },
                new Ingredient { IngredientId = 15, Name = "Захар" },
                new Ingredient { IngredientId = 16, Name = "Тиква" },
                new Ingredient { IngredientId = 17, Name = "Сол" },
                new Ingredient { IngredientId = 18, Name = "Пипер" }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { RecipeId = 1, Title = "Капама", Description = "Традиционно ястие с месо и кисело зеле.", CookingTime = "4-5 часа", CategoryId = 2, ImagePath = "/images/kapama.jpg", Instructions = "1. Нарежете киселото зеле на ситно и го наредете в голяма тенджера..." },
                new Recipe { RecipeId = 2, Title = "Мусака", Description = "Ястие с картофи, кайма и подправки.", CookingTime = "1 час", CategoryId = 2, ImagePath = "/images/musaka.jpg", Instructions = "1. Нарежете картофите на кубчета и ги запържете..." },
                new Recipe { RecipeId = 3, Title = "Шопска салата", Description = "Класическа салата с домати, краставици и сирене.", CookingTime = "10-15 минути", CategoryId = 1, ImagePath = "/images/salata.jpg", Instructions = "1. Нарежете доматите, краставиците и чушките..." },
                new Recipe { RecipeId = 4, Title = "Пълнени чушки", Description = "Чушки, пълнени с ориз, месо и подправки.", CookingTime = "1-2 часа", CategoryId = 2, ImagePath = "/images/pulneni.jpg", Instructions = "1. Запържете лука и добавете месото..." },
                new Recipe { RecipeId = 5, Title = "Таратор", Description = "Традиционна студена супа от краставици и кисело мляко.", CookingTime = "10 минути", CategoryId = 1, ImagePath = "/images/tarator.jpg", Instructions = "1. Нарежете краставиците и ги смесете с кисело мляко..." },
                new Recipe { RecipeId = 6, Title = "Лютеница", Description = "Разядка от печени чушки и домати.", CookingTime = "3-4 часа", CategoryId = 3, ImagePath = "/images/l.jpg", Instructions = "1. Опечете чушките и ги обелете..." },
                new Recipe { RecipeId = 7, Title = "Кавърма", Description = "Месо, лук и чушки, задушени в тенджера.", CookingTime = "1-2 часа", CategoryId = 2, ImagePath = "/images/kavurma.jpg", Instructions = "1. Нарежете месото и го запържете..." },
                new Recipe { RecipeId = 8, Title = "Сарми", Description = "Зелеви листа с ориз и месо.", CookingTime = "2-3 часа", CategoryId = 2, ImagePath = "/images/sarmi.jpg", Instructions = "1. Измийте лозовите или зелева листа..." },
                new Recipe { RecipeId = 9, Title = "Баница", Description = "Печено тестено изделие със сирене.", CookingTime = "1-2 часа", CategoryId = 3, ImagePath = "/images/banica.jpg", Instructions = "1. Разбийте яйцата и смесете с натрошеното сирене..." },
                new Recipe { RecipeId = 10, Title = "Печена тиква", Description = "Печена тиква с подправки.", CookingTime = "1 час", CategoryId = 3, ImagePath = "/images/tikva.jpg", Instructions = "1. Нарежете тиквата и я запечете във фурната..." }
            );

            modelBuilder.Entity<RecipeIngredient>().HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            modelBuilder.Entity<RecipeIngredient>().HasData(
                // Капама
                new RecipeIngredient { RecipeId = 1, IngredientId = 1, Quantity = 500 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 3, Quantity = 800 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 8, Quantity = 1 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 7, Quantity = 3 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 9, Quantity = 20 },

                // Мусака
                new RecipeIngredient { RecipeId = 2, IngredientId = 2, Quantity = 800 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 1, Quantity = 400 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 8, Quantity = 1 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 7, Quantity = 2 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 9, Quantity = 10 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 12, Quantity = 2 },

                // Шопска салата
                new RecipeIngredient { RecipeId = 3, IngredientId = 10, Quantity = 4 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 5, Quantity = 2 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 4, Quantity = 1 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 6, Quantity = 100 },

                // Пълнени чушки
                new RecipeIngredient { RecipeId = 4, IngredientId = 11, Quantity = 300 },
                new RecipeIngredient { RecipeId = 4, IngredientId = 1, Quantity = 300 },
                new RecipeIngredient { RecipeId = 4, IngredientId = 4, Quantity = 6 },
                new RecipeIngredient { RecipeId = 4, IngredientId = 7, Quantity = 2 },
                new RecipeIngredient { RecipeId = 4, IngredientId = 8, Quantity = 1 },

                // Таратор
                new RecipeIngredient { RecipeId = 5, IngredientId = 5, Quantity = 2 },
                new RecipeIngredient { RecipeId = 5, IngredientId = 13, Quantity = 200 },
                new RecipeIngredient { RecipeId = 5, IngredientId = 7, Quantity = 5 },

                // Лютеница
                new RecipeIngredient { RecipeId = 6, IngredientId = 4, Quantity = 5 },
                new RecipeIngredient { RecipeId = 6, IngredientId = 10, Quantity = 6 },
                new RecipeIngredient { RecipeId = 6, IngredientId = 7, Quantity = 3 },

                // Кавърма
                new RecipeIngredient { RecipeId = 7, IngredientId = 1, Quantity = 600 },
                new RecipeIngredient { RecipeId = 7, IngredientId = 8, Quantity = 1 },
                new RecipeIngredient { RecipeId = 7, IngredientId = 4, Quantity = 2 },
                new RecipeIngredient { RecipeId = 7, IngredientId = 7, Quantity = 2 },

                // Сарми
                new RecipeIngredient { RecipeId = 8, IngredientId = 11, Quantity = 400 },
                new RecipeIngredient { RecipeId = 8, IngredientId = 1, Quantity = 350 },
                new RecipeIngredient { RecipeId = 8, IngredientId = 9, Quantity = 20 },

                // Баница
                new RecipeIngredient { RecipeId = 9, IngredientId = 6, Quantity = 200 },
                new RecipeIngredient { RecipeId = 9, IngredientId = 12, Quantity = 2 },
                new RecipeIngredient { RecipeId = 9, IngredientId = 14, Quantity = 200 },

                // Печена тиква
                new RecipeIngredient { RecipeId = 10, IngredientId = 16, Quantity = 1 },
                new RecipeIngredient { RecipeId = 10, IngredientId = 15, Quantity = 10 }
            );
        }
    }
}
