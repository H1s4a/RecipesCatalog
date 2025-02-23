using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recipes.Migrations
{
    /// <inheritdoc />
    public partial class Ingr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "RecipeIngredients",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 8, "Лук" },
                    { 9, "Магданоз" },
                    { 10, "Домати" },
                    { 11, "Ориз" },
                    { 12, "Яйца" },
                    { 13, "Кисело мляко" },
                    { 14, "Брашно" },
                    { 15, "Захар" },
                    { 16, "Тиква" },
                    { 17, "Сол" },
                    { 18, "Пипер" }
                });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 800m);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 800m);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 3 },
                column: "Quantity",
                value: 2m);

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "RecipeIngredientId" },
                values: new object[,]
                {
                    { 7, 1, 3m, 0 },
                    { 7, 2, 2m, 0 },
                    { 4, 3, 1m, 0 },
                    { 1, 4, 300m, 0 },
                    { 4, 4, 6m, 0 },
                    { 7, 4, 2m, 0 },
                    { 5, 5, 2m, 0 },
                    { 7, 5, 5m, 0 },
                    { 4, 6, 5m, 0 },
                    { 7, 6, 3m, 0 },
                    { 1, 7, 600m, 0 },
                    { 4, 7, 2m, 0 },
                    { 7, 7, 2m, 0 },
                    { 1, 8, 350m, 0 },
                    { 6, 9, 200m, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Традиционно ястие с месо и кисело зеле.", "1. Нарежете киселото зеле на ситно и го наредете в голяма тенджера..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Ястие с картофи, кайма и подправки.", "1. Нарежете картофите на кубчета и ги запържете..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Класическа салата с домати, краставици и сирене.", "1. Нарежете доматите, краставиците и чушките..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Чушки, пълнени с ориз, месо и подправки.", "1. Запържете лука и добавете месото..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Традиционна студена супа от краставици и кисело мляко.", "1. Нарежете краставиците и ги смесете с кисело мляко..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Разядка от печени чушки и домати.", "1. Опечете чушките и ги обелете..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Месо, лук и чушки, задушени в тенджера.", "1. Нарежете месото и го запържете..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Зелеви листа с ориз и месо.", "1. Измийте лозовите или зелева листа..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Печено тестено изделие със сирене.", "1. Разбийте яйцата и смесете с натрошеното сирене..." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Печена тиква с подправки.", "1. Нарежете тиквата и я запечете във фурната..." });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "RecipeIngredientId" },
                values: new object[,]
                {
                    { 8, 1, 1m, 0 },
                    { 9, 1, 20m, 0 },
                    { 8, 2, 1m, 0 },
                    { 9, 2, 10m, 0 },
                    { 12, 2, 2m, 0 },
                    { 10, 3, 4m, 0 },
                    { 8, 4, 1m, 0 },
                    { 11, 4, 300m, 0 },
                    { 13, 5, 200m, 0 },
                    { 10, 6, 6m, 0 },
                    { 8, 7, 1m, 0 },
                    { 9, 8, 20m, 0 },
                    { 11, 8, 400m, 0 },
                    { 12, 9, 2m, 0 },
                    { 14, 9, 200m, 0 },
                    { 15, 10, 10m, 0 },
                    { 16, 10, 1m, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "RecipeIngredients",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 300m);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 700m);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 3 },
                column: "Quantity",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Капамата е традиционно българско зимно ястие с кисело зеле и различни видове месо – свинско, телешко, пилешко, наденица и бекон. Готви се бавно в глинен съд, за да придобие богат вкус и аромат.", "1. Нарежете киселото зеле на ситно. 2. В голям глинен съд наредете ред зеле, ред месо (свинско, телешко, пилешко, бекон, наденица). 3. Поръсете с червен и черен пипер, сол, дафинов лист и бахар. 4. Повторете редовете, докато съдът се напълни. 5. Залейте с вино и вода, покрийте с зелеви листа и похлупете съда. 6. Гответе на слаб огън или във фурна на 150°C за 4-5 часа." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Мусаката е традиционно българско ястие с картофи и кайма, запечено с яйчено-млечна заливка. Хрупкавата коричка и богатият вкус я правят любима храна в българската кухня.", "1. Нарежете лука на ситно и го запържете в малко олио. 2. Добавете каймата и пържете до златисто, като разбърквате. 3. Прибавете нарязаните на кубчета картофи, подправете със сол, черен пипер, червен пипер и чубрица. 4. Прехвърлете в тавичка и залейте с малко вода. 5. Печете на 180°C за около 40 минути. 6. Разбийте яйцата с киселото мляко и брашното и залейте мусаката. 7. Върнете във фурната за още 15 минути до златиста коричка." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Шопската салата е класическа българска салата, направена от пресни домати, краставици, печени чушки, сирене и магданоз. Освежаваща и лека, тя е идеално предястие за всяко ястие.", "1. Нарежете доматите, краставиците и чушките на кубчета. 2. Смесете в купа и добавете ситно нарязан лук и магданоз. 3. Овкусете със сол, олио и оцет. 4. Разбъркайте добре и сервирайте, поръсена с настъргано сирене и маслина отгоре." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Пълнените чушки са класическо българско ястие, приготвено с чушки, пълнени с кайма, ориз и подправки, след което се запичат във фурна или се готвят на котлон с доматен сос.", "1. Нарежете лука и го запържете в малко олио. 2. Добавете каймата и пържете до златисто. 3. Прибавете измития ориз и гответе няколко минути. 4. Подправете със сол, черен пипер, чубрица и червен пипер. 5. Напълнете почистените чушки със сместа. 6. Подредете ги в тава, залейте с вода и печете на 180°C за около 50-60 минути. 7. По желание пригответе доматен сос и залейте чушките преди сервиране." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Тараторът е традиционна българска студена супа, приготвена от кисело мляко, краставици, чесън, копър и орехи. Освежаваща и перфектна за лятото.", "1. Обелете и нарежете краставиците на ситно или ги настържете. 2. Смесете с киселото мляко и разредете с вода до желаната консистенция. 3. Добавете счукан чесън, ситно нарязан копър и натрошени орехи. 4. Овкусете със сол и зехтин. 5. Охладете добре преди сервиране." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Лютеницата е традиционна българска разядка, приготвена от печени чушки, домати, моркови, патладжани и подправки. Идеална за мазане на хляб или като гарнитура.", "1. Опечете и обелете чушките и патладжаните. 2. Пасирайте доматите и ги сварете до сгъстяване. 3. Смесете всички зеленчуци и ги пасирайте или накълцайте. 4. Добавете олио, сол, захар и черен пипер. 5. Варете на слаб огън 2-3 часа, като разбърквате. 6. Напълнете в буркани и стерилизирайте за зимата." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Ястие от месо, лук и чушки, което се приготвя с подправки и често с гъби или картофи. Това е традиционно българско ястие, което се готви на бавен огън, за да се извлекат всички аромати.", "1. Измиваме месото и го нарязваме на малки кубчета. 2. Запържваме месото в голям тиган с олио до златиста коричка. 3. Нарязваме лука на ситно и го добавяме към месото. Пържим за около 5-7 минути, докато лукът стане прозрачен. 4. Нарязваме чушките и ги добавяме към месото и лука. Готвим още 10-15 минути, докато омекнат. 5. Чесънът нарязваме на ситно и добавяме в тигана. 6. Нарязваме доматите на малки парчета и ги добавяме. 7. Добавяме бялото вино (по желание) и малко вода, за да не загори ястието. 8. Подправяме със сол, черен пипер, чубрица и червен пипер и оставяме да къкри 1-1.5 часа на слаб огън, като периодично добавяме вода, ако е необходимо." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Зелеви или лозови листа, пълни с ориз, месо и подправки, които се завиват в малки рулца. Ястието се готви дълго на бавен огън, за да се изпълнят с аромати.", "1. Запържваме нарязания лук и чесън в малко олио до златисто. 2. Добавяме смляното месо и го пържим, докато стане на малки парченца. 3. Добавяме ориза, червения пипер, солта и черния пипер и бъркаме добре. 4. Заливаме с малко вода и оставяме ориза да набъбне. 5. Върху всяко листо поставяме малко от плънката и завиваме на руло. 6. Нареждаме сармите в голям съд и заливаме с нарязаните домати и вода или бульон, така че да ги покрива. 7. Добавяме дафиновите листа и оставяме да се готвят на слаб огън за 2-3 часа." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Традиционно тестено изделие със сирене, яйца и кисело мляко, обвито в тънки кори.", "1. Разбиваме яйцата в купа и добавяме сиренето и киселото мляко. 2. В отделна купа смесваме олиото с бакпулвера. 3. Намазваме всяка кора с малко от олиото. 4. Поставяме малко от сместа върху кората и я завиваме на руло. 5. Повтаряме с останалите кори и ги нареждаме в тава. 6. Печем в предварително загрята фурна на 180°C за 30-40 минути до златисто." });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10,
                columns: new[] { "Description", "Instructions" },
                values: new object[] { "Печената тиква е чудесно ястие, което съчетава сладкия вкус на тиквата с подправки като канела и мед. Това е лесно и здравословно ястие, което може да се сервира като гарнитура или самостоятелно ястие.", "1. Измийте тиквата и я нарежете на едри парчета. 2. Премахнете семките. 3. Поръсете тиквата с мед, канела и малко олио. 4. Наредете я в тава, покрита с хартия за печене. 5. Печете в предварително загрята фурна на 180°C за около 45-60 минути, докато тиквата омекне и придобие златист цвят." });
        }
    }
}
