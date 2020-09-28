﻿// <auto-generated />
using GDC_Inventory_Database.Datacontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GDC_Inventory_Database.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GDC_Inventory_Database.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuJusLadelO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BBPlates6N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BBPlates6O")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BQSSteelGooseNecks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BasePlates12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BentoBoxesAndRedPlates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlackSoupStubsSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bricks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ButterDishesCafeAdelaide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ButterKnives")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChaffingDishLargeBanquets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChaffingDishSmallBanquets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CocktailForks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeCupsLG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeCupsSmallO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeMugsLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeMugsSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeePots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeSaucersN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoffeeSaucersO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Creamers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreamersSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CremeBruleeDishVertexThreePointFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DemiTassCups")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DemiTassSaucers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DemiTassSpoonN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DemiTassSpoonsO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DessertSpoons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DinnerForks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DinnerKnives")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DinnerPlates11N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DinnerPlates11O")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FishSpoonsSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesBeverage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesChampagne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesMartini")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesMartiniSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesMartiniwBall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesRocks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesShooters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesShootersTall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesTomCollins")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesWater8oz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesWaterBanquets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesWineBanquets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesWineLargeRedCafeAdelaide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesWineRoomServiceO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlassesWineWhiteCafeAdelaide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeatLamps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IceGlo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IceGlo32AndAHalf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IceGlo52")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LadlesLargeN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LadlesLargeO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LadlesSmallSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LargeDessertSpoonsForDressing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LargeEyeBallPlates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LargeRoundSilverTraysO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LargeWhiteFootBalls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongHandleSpoonsN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongHandleSpoonsO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarmitesSmallBanquets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediumWhiteFootBalls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mirror101By70")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mirror80By80")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PafeyGlassesInStorage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PieSpatula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlateCovers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesBlueGlassFiveAndAHalfLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesBlueGlassThreePointThreeSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesGlassFiveAndAHalfLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesGlassThreePointThreeSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesGreenGlassFiveAndAHalfLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesGreenGlassThreePointThreeSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesYellowGlassFiveAndAHalfLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatesYellowGlassThreePointThreeSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotBlackIronLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotBlackIronMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotBlackIronOval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotBlueIronLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotBlueIronMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotBlueIronOval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotCastIron")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotGreenIronLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotGreenIronMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotGreenIronOval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotRedIronLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotRedIronMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotRedIronOval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotYellowIronLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotYellowIronMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PotYellowIronOval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PunchBowlLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PunchBowlSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remekins3CafeAdelaide")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSteelCharterPlateUnderlinerO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaladForks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaladPlates9N")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaladPlates9O")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaladTongs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeaShellTongs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SilverTrayRoundLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallChampagneCoup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallWhiteFootBalls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoupCups")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoupCupsCAandSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoupSpoons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SteakKnives")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeaPotsSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeaSpoons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenOZWaterGlassForRoomServiceN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThermosCoffeePotSSLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThermosCoffeePotSSSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TongsNStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TongsOStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TongsSmallN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TongsSmallO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnderlinersMarmitesSilverTray")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnderlinersSilverTrayLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnderlinersSilverTrayMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnderlinersSilverTraySmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrnsCoffeeLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrnsCoffeeMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrnsCoffeeSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaterPitchers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhiteCeramicSpoon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhiteRectangularPlates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhiteSquarPlates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WocBlack")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
