using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDC_Inventory_Database.Models
{
    public class Inventory
    {

        public int Id { get; set; }
        public string SoupSpoons { get; set; }
        public string SteakKnives { get; set; }
        public string DessertSpoons { get; set; }
        public string DemiTassSpoonsO { get; set; }
        public string DemiTassSpoonN { get; set; }
        public string SaladForks { get; set; }
        public string DinnerForks { get; set; }
        public string DinnerKnives { get; set; }
        public string TeaSpoons { get; set; }
        public string ButterKnives { get; set; }
        public string LongHandleSpoonsO { get; set; }
        public string LongHandleSpoonsN { get; set; }
        public string TongsNStyle { get; set; }
        public string TongsOStyle { get; set; }
        public string TongsSmallO { get; set; }
        public string TongsSmallN { get; set; }
        public string LadlesLargeO { get; set; }
        public string LadlesLargeN { get; set; }
        public string LadlesSmallSS { get; set; }
        public string PieSpatula { get; set; }
        public string SeaShellTongs { get; set; }
        public string CocktailForks { get; set; }
        public string FishSpoonsSmall { get; set; }
        public string BasePlates12 { get; set; }
        public string DinnerPlates11N { get; set; }
        public string DinnerPlates11O { get; set; }
        public string SaladPlates9N { get; set; }
        public string SaladPlates9O { get; set; }
        public string BBPlates6N { get; set; }
        public string BBPlates6O { get; set; }
        public string CoffeeSaucersN { get; set; }
        public string CoffeeSaucersO { get; set; }
        public string CoffeeCupsLG { get; set; }
        public string CoffeeCupsSmallO{ get; set; }
        public string CoffeeMugsLarge{ get; set; }
        public string CoffeeMugsSmall{ get; set; }
        public string SoupCups { get; set; }
        public string PlateCovers { get; set; }
        public string CoffeePots { get; set; }
        public string WaterPitchers{ get; set; }
        public string Creamers { get; set; }
        public string CreamersSS { get; set; }
        public string GlassesShooters { get; set; }
        public string GlassesShootersTall { get; set; }
        public string GlassesBeverage { get; set; }
        public string GlassesRocks { get; set; }
        public string GlassesWaterBanquets { get; set; }
        public string GlassesWater8oz { get; set; }
        public string GlassesWineBanquets{ get; set; }
        public string GlassesWineLargeRedCafeAdelaide { get; set; }
        public string GlassesWineWhiteCafeAdelaide { get; set; }
        public string GlassesWineRoomServiceO { get; set; }
        public string GlassesChampagne { get; set; }
        public string GlassesMartini { get; set; }
        public string GlassesMartiniSmall { get; set; }
        public string GlassesMartiniwBall { get; set; }
        public string GlassesTomCollins { get; set; }
        public string ThermosCoffeePotSSSmall { get; set; }
        public string ThermosCoffeePotSSLarge{ get; set; }
        public string PunchBowlSmall { get; set; }
        public string PunchBowlLarge { get; set; }
        public string HeatLamps { get; set; }
        public string ChaffingDishLargeBanquets { get; set; }
        public string ChaffingDishSmallBanquets { get; set; }
        public string MarmitesSmallBanquets { get; set; }
        public string DemiTassCups { get; set; }
        public string DemiTassSaucers { get; set; }
        public string CremeBruleeDishVertexThreePointFive{ get; set; }
        public string PotCastIron { get; set; }
        public string BlackSoupStubsSmall { get; set; }
        public string PotGreenIronLarge{ get; set; }
        public string PotGreenIronMedium { get; set; }
        public string PotGreenIronOval { get; set; }
        public string PotBlueIronLarge { get; set; }
        public string PotBlueIronMedium { get; set; }
        public string PotBlueIronOval{ get; set; }
        public string PotYellowIronLarge { get; set; }
        public string PotYellowIronMedium { get; set; }
        public string PotYellowIronOval { get; set; }
        public string PotBlackIronLarge { get; set; }
        public string PotBlackIronMedium{ get; set; }
        public string PotBlackIronOval { get; set; }
        public string PotRedIronLarge { get; set; }
        public string PotRedIronMedium { get; set; }
        public string PotRedIronOval { get; set; }
        public string WocBlack { get; set; }
        public string Bricks { get; set; }
        public string BentoBoxesAndRedPlates { get; set; }
        public string IceGlo { get; set; }
        public string IceGlo52 { get; set; }
        public string IceGlo32AndAHalf { get; set; }
        public string Mirror101By70{ get; set; }
        public string Mirror80By80{ get; set; }
        public string SilverTrayRoundLarge{ get; set; }
        public string UnderlinersSilverTrayLarge { get; set; }
        public string UnderlinersSilverTrayMedium { get; set; }
        public string UnderlinersSilverTraySmall { get; set; }
        public string UnderlinersMarmitesSilverTray { get; set; }
        public string PlatesYellowGlassFiveAndAHalfLarge{ get; set; }
        public string PlatesYellowGlassThreePointThreeSmall{ get; set; }
        public string PlatesBlueGlassFiveAndAHalfLarge{ get; set; }
        public string PlatesBlueGlassThreePointThreeSmall{ get; set; }
        public string PlatesGreenGlassFiveAndAHalfLarge{ get; set; }
        public string PlatesGreenGlassThreePointThreeSmall{ get; set; }
        public string PlatesGlassFiveAndAHalfLarge{ get; set; }
        public string PlatesGlassThreePointThreeSmall { get; set; }
        public string UrnsCoffeeLarge{ get; set; }
        public string UrnsCoffeeMedium{ get; set; }
        public string UrnsCoffeeSmall { get; set; }
        public string ButterDishesCafeAdelaide{ get; set; }
        public string Remekins3CafeAdelaide { get; set; }
        public string SoupCupsCAandSS { get; set; }
        public string WhiteCeramicSpoon{ get; set; }
        public string SmallChampagneCoup{ get; set; }
        public string PafeyGlassesInStorage { get; set; }
        public string TeaPotsSS { get; set; }
        public string LargeWhiteFootBalls { get; set; }
        public string MediumWhiteFootBalls { get; set; }
        public string SmallWhiteFootBalls { get; set; }
        public string WhiteRectangularPlates { get; set; }
        public string WhiteSquarPlates { get; set; }
        public string LargeEyeBallPlates { get; set; }
        public string SSteelCharterPlateUnderlinerO { get; set; }
        public string AuJusLadelO { get; set; }
        public string LargeRoundSilverTraysO { get; set; }
        public string SaladTongs { get; set; }
        public string LargeDessertSpoonsForDressing { get; set; }
        public string BQSSteelGooseNecks { get; set; }
        public string TenOZWaterGlassForRoomServiceN{ get; set; }


    }
}
