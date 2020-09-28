using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GDC_Inventory_Database.Models;
using GDC_Inventory_Database.Datacontext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime;

namespace GDC_Inventory_Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly DataContext datacontext;
        public InventoryController(DataContext datacontext)
        {
            this.datacontext = datacontext;
        }
        [HttpPost]
        public ActionResult<InventoryDto> Created(InventoryDto targetvalue)
        {
            var data = datacontext.Set<Inventory>().Add(new Inventory
            {
                SoupSpoons = targetvalue.SoupSpoons,
                SteakKnives = targetvalue.SteakKnives,
                DessertSpoons = targetvalue.DessertSpoons,
                DemiTassSpoonsO = targetvalue.DemiTassSpoonsO,
                DemiTassSpoonN = targetvalue.DemiTassSpoonN,
                SaladForks = targetvalue.SaladForks,
                DinnerForks = targetvalue.DinnerForks,
                DinnerKnives = targetvalue.DinnerKnives,
                TeaSpoons = targetvalue.TeaSpoons,
                ButterKnives = targetvalue.ButterKnives,
                LongHandleSpoonsO = targetvalue.LongHandleSpoonsO,
                LongHandleSpoonsN = targetvalue.LongHandleSpoonsN,
                TongsNStyle = targetvalue.TongsNStyle,
                TongsOStyle = targetvalue.TongsOStyle,
                TongsSmallO = targetvalue.TongsSmallO,
                TongsSmallN = targetvalue.TongsSmallN,
                LadlesLargeO = targetvalue.LadlesLargeO,
                LadlesLargeN = targetvalue.LadlesLargeN,
                LadlesSmallSS = targetvalue.LadlesSmallSS,
                PieSpatula = targetvalue.PieSpatula,
                SeaShellTongs = targetvalue.SeaShellTongs,
                CocktailForks = targetvalue.CocktailForks,
                FishSpoonsSmall = targetvalue.FishSpoonsSmall,
                BasePlates12 = targetvalue.BasePlates12,
                DinnerPlates11N = targetvalue.DinnerPlates11N,
                DinnerPlates11O = targetvalue.DinnerPlates11O,
                SaladPlates9N = targetvalue.SaladPlates9N,
                SaladPlates9O = targetvalue.SaladPlates9O,
                BBPlates6N = targetvalue.BBPlates6N,
                BBPlates6O = targetvalue.BBPlates6O,
                CoffeeSaucersN = targetvalue.CoffeeSaucersN,
                CoffeeSaucersO = targetvalue.CoffeeSaucersO,
                CoffeeCupsLG = targetvalue.CoffeeCupsLG,
                CoffeeCupsSmallO = targetvalue.CoffeeCupsSmallO,
                CoffeeMugsLarge = targetvalue.CoffeeMugsLarge,
                CoffeeMugsSmall = targetvalue.CoffeeMugsSmall,
                SoupCups = targetvalue.SoupCups,
                PlateCovers = targetvalue.PlateCovers,
                CoffeePots = targetvalue.CoffeePots,
                WaterPitchers = targetvalue.WaterPitchers,
                Creamers = targetvalue.Creamers,
                CreamersSS = targetvalue.CreamersSS,
                GlassesShooters = targetvalue.GlassesShooters,
                GlassesShootersTall = targetvalue.GlassesShootersTall,
                GlassesBeverage = targetvalue.GlassesBeverage,
                GlassesRocks = targetvalue.GlassesRocks,
                GlassesWaterBanquets = targetvalue.GlassesWaterBanquets,
                GlassesWater8oz = targetvalue.GlassesWater8oz,
                GlassesWineBanquets = targetvalue.GlassesWineBanquets,
                GlassesWineLargeRedCafeAdelaide = targetvalue.GlassesWineLargeRedCafeAdelaide,
                GlassesWineWhiteCafeAdelaide = targetvalue.GlassesWineWhiteCafeAdelaide,
                GlassesWineRoomServiceO = targetvalue.GlassesWineRoomServiceO,
                GlassesChampagne = targetvalue.GlassesChampagne,
                GlassesMartini = targetvalue.GlassesMartini,
                GlassesMartiniSmall = targetvalue.GlassesMartiniSmall,
                GlassesMartiniwBall = targetvalue.GlassesMartiniwBall,
                GlassesTomCollins = targetvalue.GlassesTomCollins,
                ThermosCoffeePotSSSmall = targetvalue.ThermosCoffeePotSSSmall,
                ThermosCoffeePotSSLarge = targetvalue.ThermosCoffeePotSSLarge,
                PunchBowlSmall = targetvalue.PunchBowlSmall,
                PunchBowlLarge = targetvalue.PunchBowlLarge,
                HeatLamps = targetvalue.HeatLamps,
                ChaffingDishLargeBanquets = targetvalue.ChaffingDishLargeBanquets,
                ChaffingDishSmallBanquets = targetvalue.ChaffingDishSmallBanquets, 
                MarmitesSmallBanquets = targetvalue.MarmitesSmallBanquets,
                DemiTassCups = targetvalue.DemiTassCups,
                DemiTassSaucers = targetvalue.DemiTassSaucers,
                CremeBruleeDishVertexThreePointFive = targetvalue.CremeBruleeDishVertexThreePointFive,
                PotCastIron = targetvalue.PotCastIron,
                BlackSoupStubsSmall = targetvalue.BlackSoupStubsSmall,
                PotGreenIronLarge = targetvalue.PotGreenIronLarge,
                PotGreenIronMedium = targetvalue.PotGreenIronMedium,
                PotGreenIronOval = targetvalue.PotGreenIronOval,
                PotBlueIronLarge = targetvalue.PotBlueIronLarge,
                PotBlueIronMedium = targetvalue.PotBlueIronMedium, 
                PotBlueIronOval = targetvalue.PotBlueIronOval,
                PotYellowIronLarge = targetvalue.PotYellowIronLarge,
                PotYellowIronMedium = targetvalue.PotYellowIronMedium,
                PotYellowIronOval = targetvalue.PotYellowIronOval,
                PotBlackIronLarge = targetvalue.PotBlackIronLarge,
                PotBlackIronMedium = targetvalue.PotBlackIronMedium,
                PotBlackIronOval = targetvalue.PotBlackIronOval,
                PotRedIronLarge = targetvalue.PotRedIronLarge,
                PotRedIronMedium = targetvalue.PotRedIronMedium,
                PotRedIronOval = targetvalue.PotRedIronOval,
                WocBlack = targetvalue.WocBlack,
                Bricks = targetvalue.Bricks,
                BentoBoxesAndRedPlates = targetvalue.BentoBoxesAndRedPlates,
                IceGlo = targetvalue.IceGlo,
                IceGlo52 = targetvalue.IceGlo52,
                IceGlo32AndAHalf = targetvalue.IceGlo32AndAHalf,
                Mirror101By70 = targetvalue.Mirror101By70,
                Mirror80By80 = targetvalue.Mirror80By80,
                SilverTrayRoundLarge = targetvalue.SilverTrayRoundLarge,
                UnderlinersSilverTrayLarge = targetvalue.UnderlinersSilverTrayLarge,
                UnderlinersSilverTrayMedium = targetvalue.UnderlinersSilverTrayMedium,
                UnderlinersSilverTraySmall = targetvalue.UnderlinersSilverTraySmall,
                UnderlinersMarmitesSilverTray = targetvalue.UnderlinersMarmitesSilverTray,
                PlatesYellowGlassFiveAndAHalfLarge = targetvalue.PlatesYellowGlassFiveAndAHalfLarge,
                PlatesYellowGlassThreePointThreeSmall = targetvalue.PlatesYellowGlassThreePointThreeSmall,
                PlatesBlueGlassFiveAndAHalfLarge = targetvalue.PlatesBlueGlassFiveAndAHalfLarge,
                PlatesBlueGlassThreePointThreeSmall = targetvalue.PlatesBlueGlassThreePointThreeSmall,
                PlatesGreenGlassFiveAndAHalfLarge = targetvalue.PlatesGreenGlassFiveAndAHalfLarge,
                PlatesGreenGlassThreePointThreeSmall = targetvalue.PlatesGreenGlassThreePointThreeSmall,
                PlatesGlassFiveAndAHalfLarge = targetvalue.PlatesGlassFiveAndAHalfLarge,
                PlatesGlassThreePointThreeSmall = targetvalue.PlatesGlassThreePointThreeSmall,
                UrnsCoffeeLarge = targetvalue.UrnsCoffeeLarge,
                UrnsCoffeeMedium = targetvalue.UrnsCoffeeMedium,
                UrnsCoffeeSmall = targetvalue.UrnsCoffeeSmall,
                ButterDishesCafeAdelaide = targetvalue.ButterDishesCafeAdelaide,
                Remekins3CafeAdelaide = targetvalue.Remekins3CafeAdelaide,
                SoupCupsCAandSS = targetvalue.SoupCupsCAandSS,
                WhiteCeramicSpoon = targetvalue.WhiteCeramicSpoon,
                SmallChampagneCoup = targetvalue.SmallChampagneCoup,
                PafeyGlassesInStorage = targetvalue.PafeyGlassesInStorage,
                TeaPotsSS = targetvalue.TeaPotsSS,
                LargeWhiteFootBalls = targetvalue.LargeWhiteFootBalls,
                MediumWhiteFootBalls = targetvalue.MediumWhiteFootBalls,
                SmallWhiteFootBalls = targetvalue.SmallWhiteFootBalls,
                WhiteRectangularPlates = targetvalue.WhiteRectangularPlates,
                WhiteSquarPlates = targetvalue.WhiteSquarPlates,
                LargeEyeBallPlates = targetvalue.LargeEyeBallPlates,
                SSteelCharterPlateUnderlinerO = targetvalue.SSteelCharterPlateUnderlinerO,
                AuJusLadelO = targetvalue.AuJusLadelO,
                LargeRoundSilverTraysO = targetvalue.LargeRoundSilverTraysO,
                SaladTongs = targetvalue.SaladTongs, 
                LargeDessertSpoonsForDressing = targetvalue.LargeDessertSpoonsForDressing,
                BQSSteelGooseNecks = targetvalue.BQSSteelGooseNecks,
                TenOZWaterGlassForRoomServiceN = targetvalue.TenOZWaterGlassForRoomServiceN
    });
            targetvalue.Id = data.Entity.Id;
            datacontext.SaveChanges();
            return Created(String.Empty, data);
        }

        [HttpDelete]
        public ActionResult<InventoryDto> Delete(int id)
        {
            var data = datacontext.Set<Inventory>().FirstOrDefault(x => x.Id == id);

            datacontext.Set<Inventory>().Remove(data);
            datacontext.SaveChanges();
            return Ok();
        }
    }
}
