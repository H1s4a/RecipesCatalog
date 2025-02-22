using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recipes.Migrations
{
    /// <inheritdoc />
    public partial class RecipeCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CookingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    RecipeIngredientId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Предястие" },
                    { 2, "Основно" },
                    { 3, "Десерт" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Месо" },
                    { 2, "Картофи" },
                    { 3, "Зеле" },
                    { 4, "Чушки" },
                    { 5, "Краставици" },
                    { 6, "Сирене" },
                    { 7, "Чесън" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CategoryId", "CookingTime", "Description", "ImagePath", "Instructions", "Title" },
                values: new object[,]
                {
                    { 1, 2, "4-5 часа", "Задушено зеле с различни видове месо.", "/images/kapama.jpg", null, "Капама" },
                    { 2, 2, "1 час", "Традиционно ястие с картофи и кайма.", "/images/musaka.jpg", null, "Мусака" },
                    { 3, 1, "10-15 минути", "Домати, краставици, сирене и чушки.", "/images/shopska salata.jpg", null, "Шопска салата" },
                    { 4, 2, "1-2 часа", "Ястие от чушки, пълнени с кайма и ориз.", "/images/pulneni.jpg", null, "Пълнени чушки" },
                    { 5, 1, "10 минути", "Студена супа от кисело мляко, краставици и чесън.", "/images/tarator.jpg", null, "Таратор" },
                    { 6, 3, "3-4 часа", "Доматено-пиперена разядка с патладжан и подправки.", "/images/l.jpg", null, "Лютеница" },
                    { 7, 2, "1-2 часа", "Ястие от месо, лук и чушки.", "/images/kavurma.jpg", null, "Кавърма" },
                    { 8, 2, "2-3 часа", "Зелеви или лозови листа с плънка.", "/images/sarmi.jpg", null, "Сарми" },
                    { 9, 3, "1-2 часа", "Традиционно тестено изделие със сирене.", "/images/banica.jpg", null, "Баница" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "RecipeIngredientId" },
                values: new object[,]
                {
                    { 1, 1, 500m, 0 },
                    { 3, 1, 300m, 0 },
                    { 1, 2, 400m, 0 },
                    { 2, 2, 700m, 0 },
                    { 5, 3, 200m, 0 },
                    { 6, 3, 100m, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
