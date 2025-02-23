using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recipes.Migrations
{
    /// <inheritdoc />
    public partial class Recep : Migration
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
                name: "Recipe",
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
                    table.PrimaryKey("PK_Recipe", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipe_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
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
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparationSteps = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    RecipeIngredientId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    RecipeId1 = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_RecipeIngredients_Recipe_RecipeId1",
                        column: x => x.RecipeId1,
                        principalTable: "Recipe",
                        principalColumn: "RecipeId");
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
                columns: new[] { "RecipeId", "CategoryId", "CookingTime", "Description", "ImagePath", "PreparationSteps", "Title" },
                values: new object[,]
                {
                    { 1, 2, "4-5 часа", "Капамата е традиционно българско зимно ястие с кисело зеле и различни видове месо – свинско, телешко, пилешко, наденица и бекон. Готви се бавно в глинен съд, за да придобие богат вкус и аромат.", "/images/kapama.jpg", "1. Нарежете киселото зеле на ситно. 2. В голям глинен съд наредете ред зеле, ред месо (свинско, телешко, пилешко, бекон, наденица). 3. Поръсете с червен и черен пипер, сол, дафинов лист и бахар. 4. Повторете редовете, докато съдът се напълни. 5. Залейте с вино и вода, покрийте с зелеви листа и похлупете съда. 6. Гответе на слаб огън или във фурна на 150°C за 4-5 часа.", "Капама" },
                    { 2, 2, "1 час", "Мусаката е традиционно българско ястие с картофи и кайма, запечено с яйчено-млечна заливка. Хрупкавата коричка и богатият вкус я правят любима храна в българската кухня.", "/images/musaka.jpg", "1. Нарежете лука на ситно и го запържете в малко олио. 2. Добавете каймата и пържете до златисто, като разбърквате. 3. Прибавете нарязаните на кубчета картофи, подправете със сол, черен пипер, червен пипер и чубрица. 4. Прехвърлете в тавичка и залейте с малко вода. 5. Печете на 180°C за около 40 минути. 6. Разбийте яйцата с киселото мляко и брашното и залейте мусаката. 7. Върнете във фурната за още 15 минути до златиста коричка.", "Мусака" },
                    { 3, 1, "10-15 минути", "Шопската салата е класическа българска салата, направена от пресни домати, краставици, печени чушки, сирене и магданоз. Освежаваща и лека, тя е идеално предястие за всяко ястие.", "/images/salata.jpg", "1. Нарежете доматите, краставиците и чушките на кубчета. 2. Смесете в купа и добавете ситно нарязан лук и магданоз. 3. Овкусете със сол, олио и оцет. 4. Разбъркайте добре и сервирайте, поръсена с настъргано сирене и маслина отгоре.", "Шопска салата" },
                    { 4, 2, "1-2 часа", "Пълнените чушки са класическо българско ястие, приготвено с чушки, пълнени с кайма, ориз и подправки, след което се запичат във фурна или се готвят на котлон с доматен сос.", "/images/pulneni.jpg", "1. Нарежете лука и го запържете в малко олио. 2. Добавете каймата и пържете до златисто. 3. Прибавете измития ориз и гответе няколко минути. 4. Подправете със сол, черен пипер, чубрица и червен пипер. 5. Напълнете почистените чушки със сместа. 6. Подредете ги в тава, залейте с вода и печете на 180°C за около 50-60 минути. 7. По желание пригответе доматен сос и залейте чушките преди сервиране.", "Пълнени чушки" },
                    { 5, 1, "10 минути", "Тараторът е традиционна българска студена супа, приготвена от кисело мляко, краставици, чесън, копър и орехи. Освежаваща и перфектна за лятото.", "/images/tarator.jpg", "1. Обелете и нарежете краставиците на ситно или ги настържете. 2. Смесете с киселото мляко и разредете с вода до желаната консистенция. 3. Добавете счукан чесън, ситно нарязан копър и натрошени орехи. 4. Овкусете със сол и зехтин. 5. Охладете добре преди сервиране.", "Таратор" },
                    { 6, 3, "3-4 часа", "Лютеницата е традиционна българска разядка, приготвена от печени чушки, домати, моркови, патладжани и подправки. Идеална за мазане на хляб или като гарнитура.", "/images/l.jpg", "1. Опечете и обелете чушките и патладжаните. 2. Пасирайте доматите и ги сварете до сгъстяване. 3. Смесете всички зеленчуци и ги пасирайте или накълцайте. 4. Добавете олио, сол, захар и черен пипер. 5. Варете на слаб огън 2-3 часа, като разбърквате. 6. Напълнете в буркани и стерилизирайте за зимата.", "Лютеница" },
                    { 7, 2, "1-2 часа", "Ястие от месо, лук и чушки, което се приготвя с подправки и често с гъби или картофи. Това е традиционно българско ястие, което се готви на бавен огън, за да се извлекат всички аромати.", "/images/kavurma.jpg", "1. Измиваме месото и го нарязваме на малки кубчета. 2. Запържваме месото в голям тиган с олио до златиста коричка. 3. Нарязваме лука на ситно и го добавяме към месото. Пържим за около 5-7 минути, докато лукът стане прозрачен. 4. Нарязваме чушките и ги добавяме към месото и лука. Готвим още 10-15 минути, докато омекнат. 5. Чесънът нарязваме на ситно и добавяме в тигана. 6. Нарязваме доматите на малки парчета и ги добавяме. 7. Добавяме бялото вино (по желание) и малко вода, за да не загори ястието. 8. Подправяме със сол, черен пипер, чубрица и червен пипер и оставяме да къкри 1-1.5 часа на слаб огън, като периодично добавяме вода, ако е необходимо.", "Кавърма" },
                    { 8, 2, "2-3 часа", "Зелеви или лозови листа, пълни с ориз, месо и подправки, които се завиват в малки рулца. Ястието се готви дълго на бавен огън, за да се изпълнят с аромати.", "/images/sarmi.jpg", "1. Запържваме нарязания лук и чесън в малко олио до златисто. 2. Добавяме смляното месо и го пържим, докато стане на малки парченца. 3. Добавяме ориза, червения пипер, солта и черния пипер и бъркаме добре. 4. Заливаме с малко вода и оставяме ориза да набъбне. 5. Върху всяко листо поставяме малко от плънката и завиваме на руло. 6. Нареждаме сармите в голям съд и заливаме с нарязаните домати и вода или бульон, така че да ги покрива. 7. Добавяме дафиновите листа и оставяме да се готвят на слаб огън за 2-3 часа.", "Сарми" },
                    { 9, 3, "1-2 часа", "Традиционно тестено изделие със сирене, яйца и кисело мляко, обвито в тънки кори.", "/images/banica.jpg", "1. Разбиваме яйцата в купа и добавяме сиренето и киселото мляко. 2. В отделна купа смесваме олиото с бакпулвера. 3. Намазваме всяка кора с малко от олиото. 4. Поставяме малко от сместа върху кората и я завиваме на руло. 5. Повтаряме с останалите кори и ги нареждаме в тава. 6. Печем в предварително загрята фурна на 180°C за 30-40 минути до златисто.", "Баница" },
                    { 10, 3, "1 час", "Печената тиква е чудесно ястие, което съчетава сладкия вкус на тиквата с подправки като канела и мед. Това е лесно и здравословно ястие, което може да се сервира като гарнитура или самостоятелно ястие.", "/images/tikva.jpg", "1. Измийте тиквата и я нарежете на едри парчета. 2. Премахнете семките. 3. Поръсете тиквата с мед, канела и малко олио. 4. Наредете я в тава, покрита с хартия за печене. 5. Печете в предварително загрята фурна на 180°C за около 45-60 минути, докато тиквата омекне и придобие златист цвят.", "Печена тиква" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "RecipeId1", "RecipeIngredientId" },
                values: new object[,]
                {
                    { 1, 1, 500m, null, 0 },
                    { 3, 1, 300m, null, 0 },
                    { 1, 2, 400m, null, 0 },
                    { 2, 2, 700m, null, 0 },
                    { 5, 3, 200m, null, 0 },
                    { 6, 3, 100m, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId1",
                table: "RecipeIngredients",
                column: "RecipeId1");

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
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
