using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.Migrations
{
    /// <inheritdoc />
    public partial class Reee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipe_RecipeId1",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_RecipeId1",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "PreparationSteps",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RecipeId1",
                table: "RecipeIngredients");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Recipes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Instructions",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Instructions",
                value: "1. Нарежете киселото зеле на ситно. 2. В голям глинен съд наредете ред зеле, ред месо (свинско, телешко, пилешко, бекон, наденица). 3. Поръсете с червен и черен пипер, сол, дафинов лист и бахар. 4. Повторете редовете, докато съдът се напълни. 5. Залейте с вино и вода, покрийте с зелеви листа и похлупете съда. 6. Гответе на слаб огън или във фурна на 150°C за 4-5 часа.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Instructions",
                value: "1. Нарежете лука на ситно и го запържете в малко олио. 2. Добавете каймата и пържете до златисто, като разбърквате. 3. Прибавете нарязаните на кубчета картофи, подправете със сол, черен пипер, червен пипер и чубрица. 4. Прехвърлете в тавичка и залейте с малко вода. 5. Печете на 180°C за около 40 минути. 6. Разбийте яйцата с киселото мляко и брашното и залейте мусаката. 7. Върнете във фурната за още 15 минути до златиста коричка.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "Instructions",
                value: "1. Нарежете доматите, краставиците и чушките на кубчета. 2. Смесете в купа и добавете ситно нарязан лук и магданоз. 3. Овкусете със сол, олио и оцет. 4. Разбъркайте добре и сервирайте, поръсена с настъргано сирене и маслина отгоре.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "Instructions",
                value: "1. Нарежете лука и го запържете в малко олио. 2. Добавете каймата и пържете до златисто. 3. Прибавете измития ориз и гответе няколко минути. 4. Подправете със сол, черен пипер, чубрица и червен пипер. 5. Напълнете почистените чушки със сместа. 6. Подредете ги в тава, залейте с вода и печете на 180°C за около 50-60 минути. 7. По желание пригответе доматен сос и залейте чушките преди сервиране.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Instructions",
                value: "1. Обелете и нарежете краставиците на ситно или ги настържете. 2. Смесете с киселото мляко и разредете с вода до желаната консистенция. 3. Добавете счукан чесън, ситно нарязан копър и натрошени орехи. 4. Овкусете със сол и зехтин. 5. Охладете добре преди сервиране.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "Instructions",
                value: "1. Опечете и обелете чушките и патладжаните. 2. Пасирайте доматите и ги сварете до сгъстяване. 3. Смесете всички зеленчуци и ги пасирайте или накълцайте. 4. Добавете олио, сол, захар и черен пипер. 5. Варете на слаб огън 2-3 часа, като разбърквате. 6. Напълнете в буркани и стерилизирайте за зимата.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "Instructions",
                value: "1. Измиваме месото и го нарязваме на малки кубчета. 2. Запържваме месото в голям тиган с олио до златиста коричка. 3. Нарязваме лука на ситно и го добавяме към месото. Пържим за около 5-7 минути, докато лукът стане прозрачен. 4. Нарязваме чушките и ги добавяме към месото и лука. Готвим още 10-15 минути, докато омекнат. 5. Чесънът нарязваме на ситно и добавяме в тигана. 6. Нарязваме доматите на малки парчета и ги добавяме. 7. Добавяме бялото вино (по желание) и малко вода, за да не загори ястието. 8. Подправяме със сол, черен пипер, чубрица и червен пипер и оставяме да къкри 1-1.5 часа на слаб огън, като периодично добавяме вода, ако е необходимо.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "Instructions",
                value: "1. Запържваме нарязания лук и чесън в малко олио до златисто. 2. Добавяме смляното месо и го пържим, докато стане на малки парченца. 3. Добавяме ориза, червения пипер, солта и черния пипер и бъркаме добре. 4. Заливаме с малко вода и оставяме ориза да набъбне. 5. Върху всяко листо поставяме малко от плънката и завиваме на руло. 6. Нареждаме сармите в голям съд и заливаме с нарязаните домати и вода или бульон, така че да ги покрива. 7. Добавяме дафиновите листа и оставяме да се готвят на слаб огън за 2-3 часа.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "Instructions",
                value: "1. Разбиваме яйцата в купа и добавяме сиренето и киселото мляко. 2. В отделна купа смесваме олиото с бакпулвера. 3. Намазваме всяка кора с малко от олиото. 4. Поставяме малко от сместа върху кората и я завиваме на руло. 5. Повтаряме с останалите кори и ги нареждаме в тава. 6. Печем в предварително загрята фурна на 180°C за 30-40 минути до златисто.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "Instructions",
                value: "1. Измийте тиквата и я нарежете на едри парчета. 2. Премахнете семките. 3. Поръсете тиквата с мед, канела и малко олио. 4. Наредете я в тава, покрита с хартия за печене. 5. Печете в предварително загрята фурна на 180°C за около 45-60 минути, докато тиквата омекне и придобие златист цвят.");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Instructions",
                table: "Recipes");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreparationSteps",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RecipeId1",
                table: "RecipeIngredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CookingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                column: "RecipeId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 },
                column: "RecipeId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 2 },
                column: "RecipeId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 2 },
                column: "RecipeId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 3 },
                column: "RecipeId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 3 },
                column: "RecipeId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "PreparationSteps",
                value: "1. Нарежете киселото зеле на ситно. 2. В голям глинен съд наредете ред зеле, ред месо (свинско, телешко, пилешко, бекон, наденица). 3. Поръсете с червен и черен пипер, сол, дафинов лист и бахар. 4. Повторете редовете, докато съдът се напълни. 5. Залейте с вино и вода, покрийте с зелеви листа и похлупете съда. 6. Гответе на слаб огън или във фурна на 150°C за 4-5 часа.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "PreparationSteps",
                value: "1. Нарежете лука на ситно и го запържете в малко олио. 2. Добавете каймата и пържете до златисто, като разбърквате. 3. Прибавете нарязаните на кубчета картофи, подправете със сол, черен пипер, червен пипер и чубрица. 4. Прехвърлете в тавичка и залейте с малко вода. 5. Печете на 180°C за около 40 минути. 6. Разбийте яйцата с киселото мляко и брашното и залейте мусаката. 7. Върнете във фурната за още 15 минути до златиста коричка.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "PreparationSteps",
                value: "1. Нарежете доматите, краставиците и чушките на кубчета. 2. Смесете в купа и добавете ситно нарязан лук и магданоз. 3. Овкусете със сол, олио и оцет. 4. Разбъркайте добре и сервирайте, поръсена с настъргано сирене и маслина отгоре.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "PreparationSteps",
                value: "1. Нарежете лука и го запържете в малко олио. 2. Добавете каймата и пържете до златисто. 3. Прибавете измития ориз и гответе няколко минути. 4. Подправете със сол, черен пипер, чубрица и червен пипер. 5. Напълнете почистените чушки със сместа. 6. Подредете ги в тава, залейте с вода и печете на 180°C за около 50-60 минути. 7. По желание пригответе доматен сос и залейте чушките преди сервиране.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "PreparationSteps",
                value: "1. Обелете и нарежете краставиците на ситно или ги настържете. 2. Смесете с киселото мляко и разредете с вода до желаната консистенция. 3. Добавете счукан чесън, ситно нарязан копър и натрошени орехи. 4. Овкусете със сол и зехтин. 5. Охладете добре преди сервиране.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                column: "PreparationSteps",
                value: "1. Опечете и обелете чушките и патладжаните. 2. Пасирайте доматите и ги сварете до сгъстяване. 3. Смесете всички зеленчуци и ги пасирайте или накълцайте. 4. Добавете олио, сол, захар и черен пипер. 5. Варете на слаб огън 2-3 часа, като разбърквате. 6. Напълнете в буркани и стерилизирайте за зимата.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                column: "PreparationSteps",
                value: "1. Измиваме месото и го нарязваме на малки кубчета. 2. Запържваме месото в голям тиган с олио до златиста коричка. 3. Нарязваме лука на ситно и го добавяме към месото. Пържим за около 5-7 минути, докато лукът стане прозрачен. 4. Нарязваме чушките и ги добавяме към месото и лука. Готвим още 10-15 минути, докато омекнат. 5. Чесънът нарязваме на ситно и добавяме в тигана. 6. Нарязваме доматите на малки парчета и ги добавяме. 7. Добавяме бялото вино (по желание) и малко вода, за да не загори ястието. 8. Подправяме със сол, черен пипер, чубрица и червен пипер и оставяме да къкри 1-1.5 часа на слаб огън, като периодично добавяме вода, ако е необходимо.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                column: "PreparationSteps",
                value: "1. Запържваме нарязания лук и чесън в малко олио до златисто. 2. Добавяме смляното месо и го пържим, докато стане на малки парченца. 3. Добавяме ориза, червения пипер, солта и черния пипер и бъркаме добре. 4. Заливаме с малко вода и оставяме ориза да набъбне. 5. Върху всяко листо поставяме малко от плънката и завиваме на руло. 6. Нареждаме сармите в голям съд и заливаме с нарязаните домати и вода или бульон, така че да ги покрива. 7. Добавяме дафиновите листа и оставяме да се готвят на слаб огън за 2-3 часа.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                column: "PreparationSteps",
                value: "1. Разбиваме яйцата в купа и добавяме сиренето и киселото мляко. 2. В отделна купа смесваме олиото с бакпулвера. 3. Намазваме всяка кора с малко от олиото. 4. Поставяме малко от сместа върху кората и я завиваме на руло. 5. Повтаряме с останалите кори и ги нареждаме в тава. 6. Печем в предварително загрята фурна на 180°C за 30-40 минути до златисто.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                column: "PreparationSteps",
                value: "1. Измийте тиквата и я нарежете на едри парчета. 2. Премахнете семките. 3. Поръсете тиквата с мед, канела и малко олио. 4. Наредете я в тава, покрита с хартия за печене. 5. Печете в предварително загрята фурна на 180°C за около 45-60 минути, докато тиквата омекне и придобие златист цвят.");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId1",
                table: "RecipeIngredients",
                column: "RecipeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipe_RecipeId1",
                table: "RecipeIngredients",
                column: "RecipeId1",
                principalTable: "Recipe",
                principalColumn: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
