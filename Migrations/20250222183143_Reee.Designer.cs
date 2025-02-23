﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes.Data;

#nullable disable

namespace Recipes.Migrations
{
    [DbContext(typeof(RecipeCatalogContext))]
    [Migration("20250222183143_Reee")]
    partial class Reee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("RecipeIngredientId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 1,
                            Quantity = 500m,
                            RecipeIngredientId = 0
                        },
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 3,
                            Quantity = 300m,
                            RecipeIngredientId = 0
                        },
                        new
                        {
                            RecipeId = 2,
                            IngredientId = 2,
                            Quantity = 700m,
                            RecipeIngredientId = 0
                        },
                        new
                        {
                            RecipeId = 2,
                            IngredientId = 1,
                            Quantity = 400m,
                            RecipeIngredientId = 0
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 5,
                            Quantity = 200m,
                            RecipeIngredientId = 0
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 6,
                            Quantity = 100m,
                            RecipeIngredientId = 0
                        });
                });

            modelBuilder.Entity("Recipes.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Предястие"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Основно"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Десерт"
                        });
                });

            modelBuilder.Entity("Recipes.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            Name = "Месо"
                        },
                        new
                        {
                            IngredientId = 2,
                            Name = "Картофи"
                        },
                        new
                        {
                            IngredientId = 3,
                            Name = "Зеле"
                        },
                        new
                        {
                            IngredientId = 4,
                            Name = "Чушки"
                        },
                        new
                        {
                            IngredientId = 5,
                            Name = "Краставици"
                        },
                        new
                        {
                            IngredientId = 6,
                            Name = "Сирене"
                        },
                        new
                        {
                            IngredientId = 7,
                            Name = "Чесън"
                        });
                });

            modelBuilder.Entity("Recipes.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CookingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            CategoryId = 2,
                            CookingTime = "4-5 часа",
                            Description = "Капамата е традиционно българско зимно ястие с кисело зеле и различни видове месо – свинско, телешко, пилешко, наденица и бекон. Готви се бавно в глинен съд, за да придобие богат вкус и аромат.",
                            ImagePath = "/images/kapama.jpg",
                            Instructions = "1. Нарежете киселото зеле на ситно. 2. В голям глинен съд наредете ред зеле, ред месо (свинско, телешко, пилешко, бекон, наденица). 3. Поръсете с червен и черен пипер, сол, дафинов лист и бахар. 4. Повторете редовете, докато съдът се напълни. 5. Залейте с вино и вода, покрийте с зелеви листа и похлупете съда. 6. Гответе на слаб огън или във фурна на 150°C за 4-5 часа.",
                            Title = "Капама"
                        },
                        new
                        {
                            RecipeId = 2,
                            CategoryId = 2,
                            CookingTime = "1 час",
                            Description = "Мусаката е традиционно българско ястие с картофи и кайма, запечено с яйчено-млечна заливка. Хрупкавата коричка и богатият вкус я правят любима храна в българската кухня.",
                            ImagePath = "/images/musaka.jpg",
                            Instructions = "1. Нарежете лука на ситно и го запържете в малко олио. 2. Добавете каймата и пържете до златисто, като разбърквате. 3. Прибавете нарязаните на кубчета картофи, подправете със сол, черен пипер, червен пипер и чубрица. 4. Прехвърлете в тавичка и залейте с малко вода. 5. Печете на 180°C за около 40 минути. 6. Разбийте яйцата с киселото мляко и брашното и залейте мусаката. 7. Върнете във фурната за още 15 минути до златиста коричка.",
                            Title = "Мусака"
                        },
                        new
                        {
                            RecipeId = 3,
                            CategoryId = 1,
                            CookingTime = "10-15 минути",
                            Description = "Шопската салата е класическа българска салата, направена от пресни домати, краставици, печени чушки, сирене и магданоз. Освежаваща и лека, тя е идеално предястие за всяко ястие.",
                            ImagePath = "/images/salata.jpg",
                            Instructions = "1. Нарежете доматите, краставиците и чушките на кубчета. 2. Смесете в купа и добавете ситно нарязан лук и магданоз. 3. Овкусете със сол, олио и оцет. 4. Разбъркайте добре и сервирайте, поръсена с настъргано сирене и маслина отгоре.",
                            Title = "Шопска салата"
                        },
                        new
                        {
                            RecipeId = 4,
                            CategoryId = 2,
                            CookingTime = "1-2 часа",
                            Description = "Пълнените чушки са класическо българско ястие, приготвено с чушки, пълнени с кайма, ориз и подправки, след което се запичат във фурна или се готвят на котлон с доматен сос.",
                            ImagePath = "/images/pulneni.jpg",
                            Instructions = "1. Нарежете лука и го запържете в малко олио. 2. Добавете каймата и пържете до златисто. 3. Прибавете измития ориз и гответе няколко минути. 4. Подправете със сол, черен пипер, чубрица и червен пипер. 5. Напълнете почистените чушки със сместа. 6. Подредете ги в тава, залейте с вода и печете на 180°C за около 50-60 минути. 7. По желание пригответе доматен сос и залейте чушките преди сервиране.",
                            Title = "Пълнени чушки"
                        },
                        new
                        {
                            RecipeId = 5,
                            CategoryId = 1,
                            CookingTime = "10 минути",
                            Description = "Тараторът е традиционна българска студена супа, приготвена от кисело мляко, краставици, чесън, копър и орехи. Освежаваща и перфектна за лятото.",
                            ImagePath = "/images/tarator.jpg",
                            Instructions = "1. Обелете и нарежете краставиците на ситно или ги настържете. 2. Смесете с киселото мляко и разредете с вода до желаната консистенция. 3. Добавете счукан чесън, ситно нарязан копър и натрошени орехи. 4. Овкусете със сол и зехтин. 5. Охладете добре преди сервиране.",
                            Title = "Таратор"
                        },
                        new
                        {
                            RecipeId = 6,
                            CategoryId = 3,
                            CookingTime = "3-4 часа",
                            Description = "Лютеницата е традиционна българска разядка, приготвена от печени чушки, домати, моркови, патладжани и подправки. Идеална за мазане на хляб или като гарнитура.",
                            ImagePath = "/images/l.jpg",
                            Instructions = "1. Опечете и обелете чушките и патладжаните. 2. Пасирайте доматите и ги сварете до сгъстяване. 3. Смесете всички зеленчуци и ги пасирайте или накълцайте. 4. Добавете олио, сол, захар и черен пипер. 5. Варете на слаб огън 2-3 часа, като разбърквате. 6. Напълнете в буркани и стерилизирайте за зимата.",
                            Title = "Лютеница"
                        },
                        new
                        {
                            RecipeId = 7,
                            CategoryId = 2,
                            CookingTime = "1-2 часа",
                            Description = "Ястие от месо, лук и чушки, което се приготвя с подправки и често с гъби или картофи. Това е традиционно българско ястие, което се готви на бавен огън, за да се извлекат всички аромати.",
                            ImagePath = "/images/kavurma.jpg",
                            Instructions = "1. Измиваме месото и го нарязваме на малки кубчета. 2. Запържваме месото в голям тиган с олио до златиста коричка. 3. Нарязваме лука на ситно и го добавяме към месото. Пържим за около 5-7 минути, докато лукът стане прозрачен. 4. Нарязваме чушките и ги добавяме към месото и лука. Готвим още 10-15 минути, докато омекнат. 5. Чесънът нарязваме на ситно и добавяме в тигана. 6. Нарязваме доматите на малки парчета и ги добавяме. 7. Добавяме бялото вино (по желание) и малко вода, за да не загори ястието. 8. Подправяме със сол, черен пипер, чубрица и червен пипер и оставяме да къкри 1-1.5 часа на слаб огън, като периодично добавяме вода, ако е необходимо.",
                            Title = "Кавърма"
                        },
                        new
                        {
                            RecipeId = 8,
                            CategoryId = 2,
                            CookingTime = "2-3 часа",
                            Description = "Зелеви или лозови листа, пълни с ориз, месо и подправки, които се завиват в малки рулца. Ястието се готви дълго на бавен огън, за да се изпълнят с аромати.",
                            ImagePath = "/images/sarmi.jpg",
                            Instructions = "1. Запържваме нарязания лук и чесън в малко олио до златисто. 2. Добавяме смляното месо и го пържим, докато стане на малки парченца. 3. Добавяме ориза, червения пипер, солта и черния пипер и бъркаме добре. 4. Заливаме с малко вода и оставяме ориза да набъбне. 5. Върху всяко листо поставяме малко от плънката и завиваме на руло. 6. Нареждаме сармите в голям съд и заливаме с нарязаните домати и вода или бульон, така че да ги покрива. 7. Добавяме дафиновите листа и оставяме да се готвят на слаб огън за 2-3 часа.",
                            Title = "Сарми"
                        },
                        new
                        {
                            RecipeId = 9,
                            CategoryId = 3,
                            CookingTime = "1-2 часа",
                            Description = "Традиционно тестено изделие със сирене, яйца и кисело мляко, обвито в тънки кори.",
                            ImagePath = "/images/banica.jpg",
                            Instructions = "1. Разбиваме яйцата в купа и добавяме сиренето и киселото мляко. 2. В отделна купа смесваме олиото с бакпулвера. 3. Намазваме всяка кора с малко от олиото. 4. Поставяме малко от сместа върху кората и я завиваме на руло. 5. Повтаряме с останалите кори и ги нареждаме в тава. 6. Печем в предварително загрята фурна на 180°C за 30-40 минути до златисто.",
                            Title = "Баница"
                        },
                        new
                        {
                            RecipeId = 10,
                            CategoryId = 3,
                            CookingTime = "1 час",
                            Description = "Печената тиква е чудесно ястие, което съчетава сладкия вкус на тиквата с подправки като канела и мед. Това е лесно и здравословно ястие, което може да се сервира като гарнитура или самостоятелно ястие.",
                            ImagePath = "/images/tikva.jpg",
                            Instructions = "1. Измийте тиквата и я нарежете на едри парчета. 2. Премахнете семките. 3. Поръсете тиквата с мед, канела и малко олио. 4. Наредете я в тава, покрита с хартия за печене. 5. Печете в предварително загрята фурна на 180°C за около 45-60 минути, докато тиквата омекне и придобие златист цвят.",
                            Title = "Печена тиква"
                        });
                });

            modelBuilder.Entity("RecipeIngredient", b =>
                {
                    b.HasOne("Recipes.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipes.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Recipes.Models.Recipe", b =>
                {
                    b.HasOne("Recipes.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Recipes.Models.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Recipes.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("Recipes.Models.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
