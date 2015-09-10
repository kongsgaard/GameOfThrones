using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


	public class DeclareTerritories
	{
		public static List<Territory> MakeTerritories() 
		{
            List<Territory> AllTerritories = new List<Territory>();

            Territory CastleBlack = new Territory("CastleBlack", null, TerritoryType.LandArea, false, false, 1, 0); AllTerritories.Add(CastleBlack);
            Territory Karhold = new Territory("Karhold", null, TerritoryType.LandArea, false, false, 1, 0); AllTerritories.Add(Karhold);
            Territory Winterfell = new Territory("Winterfell", null, TerritoryType.LandArea, false, true, 1, 1); AllTerritories.Add(Winterfell);
            Territory WinterfellHarbor = new Territory("WinterfellHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(WinterfellHarbor);
            Territory TheStonyShore = new Territory("TheStonyShore", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(TheStonyShore);
            Territory WhiteHarbor = new Territory("WhiteHarbor", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(WhiteHarbor);
            Territory WhiteHarborHarbor = new Territory("WhiteHarborHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(WhiteHarborHarbor);
            Territory WidowsWatch = new Territory("WidowsWatch", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(WidowsWatch);
            Territory TheShiveringSea = new Territory("TheShiveringSea", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(TheShiveringSea);
            Territory BayOfIce = new Territory("BayOfIce", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(BayOfIce);
            Territory MoatCalin = new Territory("MoatCalin", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(MoatCalin);
            Territory GreywaterWatch = new Territory("GreywaterWatch", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(GreywaterWatch);
            Territory FlintsFinger = new Territory("FlintsFinger", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(FlintsFinger);
            Territory Seagard = new Territory("Seagard", null, TerritoryType.LandArea, false, true, 1, 1); AllTerritories.Add(Seagard);
            Territory TheTwins = new Territory("TheTwins", null, TerritoryType.LandArea, false, false, 1, 0); AllTerritories.Add(TheTwins);
            Territory TheFingers = new Territory("TheFingers", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(TheFingers);
            Territory TheMountiansOfTheMoon = new Territory("TheMountiansOfTheMoon", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(TheMountiansOfTheMoon);
            Territory TheEyrie = new Territory("TheEyrie", null, TerritoryType.LandArea, true, false, 1, 1); AllTerritories.Add(TheEyrie);
            Territory Pyke = new Territory("Pyke", null, TerritoryType.LandArea, false, true, 1, 1); AllTerritories.Add(Pyke);
            Territory PykeHarbor = new Territory("PykeHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(PykeHarbor);
            Territory IronmansBay = new Territory("IronmansBay", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(IronmansBay);
            Territory SunsetSea = new Territory("SunsetSea", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(SunsetSea);
            Territory Riverrun = new Territory("Riverrun", null, TerritoryType.LandArea, false, true, 1, 1); AllTerritories.Add(Riverrun);
            Territory Lannisport = new Territory("Lannisport", null, TerritoryType.LandArea, false, true, 0, 2); AllTerritories.Add(Lannisport);
            Territory LannisportHarbor = new Territory("LannisportHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(LannisportHarbor);
            Territory TheGoldenSound = new Territory("TheGoldenSound", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(TheGoldenSound);
            Territory StonySept = new Territory("StoneySept", null, TerritoryType.LandArea, false, false, 1, 0); AllTerritories.Add(StonySept);
            Territory Harrenhal = new Territory("Harrenhal", null, TerritoryType.LandArea, true, false, 1, 0); AllTerritories.Add(Harrenhal);
            Territory SearoadMarches = new Territory("SearoadMarches", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(SearoadMarches);
            Territory CracklawPoint = new Territory("CracklawPoint", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(CracklawPoint);
            Territory Blackwater = new Territory("Blackwater", null, TerritoryType.LandArea, false, false, 0, 2); AllTerritories.Add(Blackwater);
            Territory KingsLanding = new Territory("KingsLanding", null, TerritoryType.LandArea, false, true, 2, 0); AllTerritories.Add(KingsLanding);
            Territory TheNarrowSea = new Territory("TheNarrowSea", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(TheNarrowSea);
            Territory BlackwaterBay = new Territory("BlackwaterBay", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(BlackwaterBay);
            Territory ShipbreakerBay = new Territory("ShipbreakerBay", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(ShipbreakerBay);
            Territory Dragonstone = new Territory("Dragonstone", null, TerritoryType.LandArea, false, true, 1, 1); AllTerritories.Add(Dragonstone);
            Territory DragonstoneHarbor = new Territory("DragonstoneHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(DragonstoneHarbor);
            Territory Kingswood = new Territory("Kingswood", null, TerritoryType.LandArea, false, false, 1, 1); AllTerritories.Add(Kingswood);
            Territory TheReach = new Territory("TheReach", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(TheReach);
            Territory Highgarden = new Territory("Highgarden", null, TerritoryType.LandArea, false, true, 0, 2); AllTerritories.Add(Highgarden);
            Territory Oldtown = new Territory("Oldtown", null, TerritoryType.LandArea, false, true, 0, 0); AllTerritories.Add(Oldtown);
            Territory OldtownHarbor = new Territory("OldtownHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(OldtownHarbor);
            Territory RedwyneStraights = new Territory("RedwyneStraights", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(RedwyneStraights);
            Territory TheArbor = new Territory("TheArbor", null, TerritoryType.LandArea, false, false, 1, 0); AllTerritories.Add(TheArbor);
            Territory WestSummerSea = new Territory("WestSummerSea", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(WestSummerSea);
            Territory ThreeTowers = new Territory("ThreeTowers", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(ThreeTowers);
            Territory DornishMarches = new Territory("DornishMarches", null, TerritoryType.LandArea, false, false, 1, 0); AllTerritories.Add(DornishMarches);
            Territory PrincesPass = new Territory("PrincesPass", null, TerritoryType.LandArea, false, false, 1, 1); AllTerritories.Add(PrincesPass);
            Territory TheBoneway = new Territory("TheBoneway", null, TerritoryType.LandArea, false, false, 1, 0); AllTerritories.Add(TheBoneway);
            Territory StormsEnd = new Territory("StormsEnd", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(StormsEnd);
            Territory StormsEndHarbor = new Territory("StormsEndHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(StormsEndHarbor);
            Territory Starfall = new Territory("Starfall", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(Starfall);
            Territory Yronwood = new Territory("Yronwood", null, TerritoryType.LandArea, true, false, 0, 0); AllTerritories.Add(Yronwood);
            Territory SaltShore = new Territory("SaltShore", null, TerritoryType.LandArea, false, false, 0, 1); AllTerritories.Add(SaltShore);
            Territory Sunspear = new Territory("Sunspear", null, TerritoryType.LandArea, false, true, 1, 1); AllTerritories.Add(Sunspear);
            Territory SunspearHarbor = new Territory("SunspearHarbor", null, TerritoryType.HarborArea, false, false, 0, 0); AllTerritories.Add(SunspearHarbor);
            Territory SeaOfDorne = new Territory("SeaOfDorne", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(SeaOfDorne);
            Territory EastSummerSea = new Territory("EastSummerSea", null, TerritoryType.SeaArea, false, false, 0, 0); AllTerritories.Add(EastSummerSea);

			List<Territory> CastleBlackAdj = new List<Territory>();
			CastleBlackAdj.Add(BayOfIce); CastleBlackAdj.Add(TheShiveringSea); CastleBlackAdj.Add(Karhold); CastleBlackAdj.Add(Winterfell);
			CastleBlack.AdjecantTerritories = CastleBlackAdj;

			List<Territory> KarholdAdj = new List<Territory>();
			KarholdAdj.Add(CastleBlack); KarholdAdj.Add(TheShiveringSea); KarholdAdj.Add(Winterfell);
			Karhold.AdjecantTerritories = KarholdAdj;

			List<Territory> WinterfellAdj = new List<Territory>();
			WinterfellAdj.Add(BayOfIce); WinterfellAdj.Add(TheShiveringSea); WinterfellAdj.Add(Karhold); WinterfellAdj.Add(CastleBlack); WinterfellAdj.Add(WhiteHarbor);
			WinterfellAdj.Add(TheStonyShore); WinterfellAdj.Add(MoatCalin);
			Winterfell.AdjecantTerritories = WinterfellAdj;

			List<Territory> WinterfellHarborAdj = new List<Territory>();
			WinterfellHarborAdj.Add(BayOfIce);
			WinterfellHarbor.AdjecantTerritories = WinterfellHarborAdj;

			List<Territory> BayOfIceAdj = new List<Territory>();
			BayOfIceAdj.Add(CastleBlack); BayOfIceAdj.Add(WinterfellHarbor); BayOfIceAdj.Add(Winterfell); BayOfIceAdj.Add(TheStonyShore); BayOfIceAdj.Add(SunsetSea);
			BayOfIceAdj.Add(FlintsFinger); BayOfIceAdj.Add(GreywaterWatch);
			BayOfIce.AdjecantTerritories = BayOfIceAdj;
            
			List<Territory> TheStonyShoreAdj = new List<Territory>();
			TheStonyShoreAdj.Add(BayOfIce); TheStonyShoreAdj.Add(Winterfell);
			TheStonyShore.AdjecantTerritories = TheStonyShoreAdj;

			List<Territory> WhiteHarborAdj = new List<Territory>();
			WhiteHarborAdj.Add(Winterfell); WhiteHarborAdj.Add(TheShiveringSea); WhiteHarborAdj.Add(TheNarrowSea); WhiteHarborAdj.Add(WidowsWatch);
			WhiteHarborAdj.Add(MoatCalin);
			WhiteHarbor.AdjecantTerritories = WhiteHarborAdj;

			List<Territory> TheShiveringSeaAdj = new List<Territory>();
			TheShiveringSeaAdj.Add(CastleBlack); TheShiveringSeaAdj.Add(Karhold); TheShiveringSeaAdj.Add(Winterfell); TheShiveringSeaAdj.Add(WidowsWatch);
			TheShiveringSeaAdj.Add(WhiteHarbor); TheShiveringSeaAdj.Add(TheNarrowSea);
			TheShiveringSea.AdjecantTerritories = TheShiveringSeaAdj;

			List<Territory> WhiteHarborHarborAdj = new List<Territory>();
			WhiteHarborHarborAdj.Add(TheNarrowSea);
			WhiteHarborHarbor.AdjecantTerritories = WhiteHarborHarborAdj;

			List<Territory> WidowsWatchAdj = new List<Territory>();
			WidowsWatchAdj.Add(WhiteHarbor); WidowsWatchAdj.Add(TheShiveringSea); WidowsWatchAdj.Add(TheNarrowSea);
			WidowsWatch.AdjecantTerritories = WidowsWatchAdj;
            
			List<Territory> MoatCalinAdj = new List<Territory>();
			MoatCalinAdj.Add(Winterfell); MoatCalinAdj.Add(WhiteHarbor); MoatCalinAdj.Add(TheNarrowSea); MoatCalinAdj.Add(GreywaterWatch);
			MoatCalinAdj.Add(Seagard); MoatCalinAdj.Add(TheTwins);
			MoatCalin.AdjecantTerritories = MoatCalinAdj;

			List<Territory> GreywaterWatchAdj = new List<Territory>();
			GreywaterWatchAdj.Add(BayOfIce); GreywaterWatchAdj.Add(IronmansBay); GreywaterWatchAdj.Add(FlintsFinger); GreywaterWatchAdj.Add(MoatCalin);
			GreywaterWatchAdj.Add(Seagard);
			GreywaterWatch.AdjecantTerritories = GreywaterWatchAdj;

			List<Territory> FlintsFingerAdj = new List<Territory>();
			FlintsFingerAdj.Add(BayOfIce); FlintsFingerAdj.Add(IronmansBay); FlintsFingerAdj.Add(GreywaterWatch); FlintsFingerAdj.Add(SunsetSea);
			FlintsFinger.AdjecantTerritories = FlintsFingerAdj;

			List<Territory> SunsetSeaAdj = new List<Territory>();
			SunsetSeaAdj.Add(BayOfIce); SunsetSeaAdj.Add(IronmansBay); SunsetSeaAdj.Add(FlintsFinger);
			SunsetSeaAdj.Add(SearoadMarches); SunsetSeaAdj.Add(TheGoldenSound); SunsetSeaAdj.Add(WestSummerSea);
			SunsetSea.AdjecantTerritories = SunsetSeaAdj;

			List<Territory> IronmansBayAdj = new List<Territory>();
			IronmansBayAdj.Add(Pyke); IronmansBayAdj.Add(PykeHarbor); IronmansBayAdj.Add(FlintsFinger); IronmansBayAdj.Add(GreywaterWatch);
			IronmansBayAdj.Add(Seagard); IronmansBayAdj.Add(TheGoldenSound); IronmansBayAdj.Add(SunsetSea); IronmansBayAdj.Add(Riverrun);
			IronmansBay.AdjecantTerritories = IronmansBayAdj;
            
			List<Territory> PykeAdj = new List<Territory>();
			PykeAdj.Add(IronmansBay);
			Pyke.AdjecantTerritories = PykeAdj;

			List<Territory> PykeHarborAdj = new List<Territory>();
			PykeHarborAdj.Add(IronmansBay);
			PykeHarbor.AdjecantTerritories = PykeHarborAdj;

			List<Territory> SeagardAdj = new List<Territory>();
			SeagardAdj.Add(GreywaterWatch); SeagardAdj.Add(IronmansBay); SeagardAdj.Add(MoatCalin); SeagardAdj.Add(TheTwins); SeagardAdj.Add(Riverrun);
			Seagard.AdjecantTerritories = SeagardAdj;

			List<Territory> TheTwinsAdj = new List<Territory>();
			TheTwinsAdj.Add(Seagard); TheTwinsAdj.Add(MoatCalin); TheTwinsAdj.Add(TheFingers); TheTwinsAdj.Add(TheMountiansOfTheMoon); TheTwinsAdj.Add(TheNarrowSea);
			TheTwins.AdjecantTerritories = TheTwinsAdj;

			List<Territory> TheFingersAdj = new List<Territory>();
			TheFingersAdj.Add(TheTwins); TheFingersAdj.Add(TheNarrowSea); TheFingersAdj.Add(TheMountiansOfTheMoon); 
			TheFingers.AdjecantTerritories = TheFingersAdj;
            
			List<Territory> TheMountiansOfTheMoonAdj = new List<Territory>();
			TheMountiansOfTheMoonAdj.Add(TheTwins); TheMountiansOfTheMoonAdj.Add(TheNarrowSea); TheMountiansOfTheMoonAdj.Add(TheFingers); TheMountiansOfTheMoonAdj.Add(TheEyrie);
			TheMountiansOfTheMoon.AdjecantTerritories = TheMountiansOfTheMoonAdj;

			List<Territory> TheEyrieAdj = new List<Territory>();
			TheEyrieAdj.Add(TheMountiansOfTheMoon); TheEyrieAdj.Add(TheNarrowSea);
			TheEyrie.AdjecantTerritories = TheEyrieAdj;

			List<Territory> TheNarrowSeaAdj = new List<Territory>();
			TheNarrowSeaAdj.Add(TheShiveringSea); TheNarrowSeaAdj.Add(WhiteHarbor); TheNarrowSeaAdj.Add(WhiteHarborHarbor); TheNarrowSeaAdj.Add(WidowsWatch);
			TheNarrowSeaAdj.Add(MoatCalin); TheNarrowSeaAdj.Add(TheTwins); TheNarrowSeaAdj.Add(TheFingers); TheNarrowSeaAdj.Add(TheMountiansOfTheMoon);
			TheNarrowSeaAdj.Add(TheEyrie); TheNarrowSeaAdj.Add(ShipbreakerBay); TheNarrowSeaAdj.Add(CracklawPoint);
			TheNarrowSea.AdjecantTerritories = TheNarrowSeaAdj;

			List<Territory> TheGoldenSoundAdj = new List<Territory>();
			TheGoldenSoundAdj.Add(IronmansBay); TheGoldenSoundAdj.Add(SunsetSea); TheGoldenSoundAdj.Add(Lannisport); TheGoldenSoundAdj.Add(LannisportHarbor);
			TheGoldenSoundAdj.Add(Riverrun); TheGoldenSoundAdj.Add(SearoadMarches);
			TheGoldenSound.AdjecantTerritories = TheGoldenSoundAdj;

			List<Territory> RiverrunAdj = new List<Territory>();
			RiverrunAdj.Add(Seagard); RiverrunAdj.Add(IronmansBay); RiverrunAdj.Add(TheGoldenSound); RiverrunAdj.Add(Lannisport);
			RiverrunAdj.Add(Harrenhal); RiverrunAdj.Add(StonySept);
			Riverrun.AdjecantTerritories = RiverrunAdj;
            
			List<Territory> LannisportAdj = new List<Territory>();
			LannisportAdj.Add(TheGoldenSound); LannisportAdj.Add(Riverrun); LannisportAdj.Add(SearoadMarches); LannisportAdj.Add(StonySept);
			Lannisport.AdjecantTerritories = LannisportAdj;

			List<Territory> LannisportHarborAdj = new List<Territory>();
			LannisportHarborAdj.Add(TheGoldenSound);
			LannisportHarbor.AdjecantTerritories = LannisportHarborAdj;

            List<Territory> SearoadMarchesAdj = new List<Territory>();
            SearoadMarchesAdj.Add(WestSummerSea); SearoadMarchesAdj.Add(SunsetSea); SearoadMarchesAdj.Add(TheGoldenSound); SearoadMarchesAdj.Add(Highgarden);
            SearoadMarchesAdj.Add(TheReach); SearoadMarchesAdj.Add(Blackwater); SearoadMarchesAdj.Add(StonySept); SearoadMarchesAdj.Add(Lannisport);
            SearoadMarches.AdjecantTerritories = SearoadMarchesAdj;


			List<Territory> StonySeptAdj = new List<Territory>();
			StonySeptAdj.Add(Riverrun); StonySeptAdj.Add(Lannisport); StonySeptAdj.Add(SearoadMarches); StonySeptAdj.Add(Harrenhal); StonySeptAdj.Add(Blackwater);
			StonySept.AdjecantTerritories = StonySeptAdj;

			List<Territory> HarrenhalAdj = new List<Territory>();
			HarrenhalAdj.Add(Riverrun); HarrenhalAdj.Add(StonySept); HarrenhalAdj.Add(Blackwater); HarrenhalAdj.Add(CracklawPoint);
			Harrenhal.AdjecantTerritories = HarrenhalAdj;

			List<Territory> CracklawPointAdj = new List<Territory>();
			CracklawPointAdj.Add(TheMountiansOfTheMoon); CracklawPointAdj.Add(Harrenhal); CracklawPointAdj.Add(Blackwater); CracklawPointAdj.Add(KingsLanding);
            CracklawPointAdj.Add(BlackwaterBay); CracklawPointAdj.Add(ShipbreakerBay); CracklawPointAdj.Add(TheNarrowSea);
			CracklawPoint.AdjecantTerritories = CracklawPointAdj;
            
			List<Territory> BlackwaterBayAdj = new List<Territory>();
			BlackwaterBayAdj.Add(CracklawPoint); BlackwaterBayAdj.Add(KingsLanding); BlackwaterBayAdj.Add(Kingswood); BlackwaterBayAdj.Add(ShipbreakerBay);
			BlackwaterBay.AdjecantTerritories = BlackwaterBayAdj;

			List<Territory> KingsLandingAdj = new List<Territory>();
			KingsLandingAdj.Add(CracklawPoint); KingsLandingAdj.Add(Blackwater); KingsLandingAdj.Add(Kingswood); KingsLandingAdj.Add(TheReach);
			KingsLandingAdj.Add(BlackwaterBay);
			KingsLanding.AdjecantTerritories = KingsLandingAdj;

			List<Territory> ShipbreakerBayAdj = new List<Territory>();
			ShipbreakerBayAdj.Add(TheNarrowSea); ShipbreakerBayAdj.Add(Dragonstone); ShipbreakerBayAdj.Add(DragonstoneHarbor); ShipbreakerBayAdj.Add(CracklawPoint);
			ShipbreakerBayAdj.Add(BlackwaterBay); ShipbreakerBayAdj.Add(Kingswood); ShipbreakerBayAdj.Add(StormsEnd); ShipbreakerBayAdj.Add(StormsEndHarbor);
			ShipbreakerBayAdj.Add(EastSummerSea);
			ShipbreakerBay.AdjecantTerritories = ShipbreakerBayAdj;

			List<Territory> DragonStoneAdj = new List<Territory>();
			DragonStoneAdj.Add(ShipbreakerBay); 
			Dragonstone.AdjecantTerritories = DragonStoneAdj;

			List<Territory> DragonStoneHarborAdj = new List<Territory>();
			DragonStoneHarborAdj.Add(ShipbreakerBay);
			DragonstoneHarbor.AdjecantTerritories = DragonStoneHarborAdj;
            
			List<Territory> KingswoodAdj = new List<Territory>();
			KingswoodAdj.Add(KingsLanding); KingswoodAdj.Add(TheReach); KingswoodAdj.Add(TheBoneway); KingswoodAdj.Add(StormsEnd);
			KingswoodAdj.Add(BlackwaterBay); KingswoodAdj.Add(ShipbreakerBay);
			Kingswood.AdjecantTerritories = KingswoodAdj;

			List<Territory> StormsEndAdj = new List<Territory>();
			StormsEndAdj.Add(Kingswood); StormsEndAdj.Add(TheBoneway); StormsEndAdj.Add(SeaOfDorne); StormsEndAdj.Add(EastSummerSea);
			StormsEndAdj.Add(ShipbreakerBay);
			StormsEnd.AdjecantTerritories = StormsEndAdj;

			List<Territory> StormsEndHarborAdj = new List<Territory>();
			StormsEndHarborAdj.Add(ShipbreakerBay);
			StormsEndHarbor.AdjecantTerritories = StormsEndHarborAdj;

            List<Territory> BlackwaterAdj = new List<Territory>();
            BlackwaterAdj.Add(Harrenhal); BlackwaterAdj.Add(StonySept); BlackwaterAdj.Add(SearoadMarches); BlackwaterAdj.Add(TheReach);
            BlackwaterAdj.Add(KingsLanding); BlackwaterAdj.Add(CracklawPoint);
            Blackwater.AdjecantTerritories = BlackwaterAdj;

			List<Territory> TheReachAdj = new List<Territory>();
			TheReachAdj.Add(KingsLanding); TheReachAdj.Add(Blackwater); TheReachAdj.Add(SearoadMarches); TheReachAdj.Add(Highgarden);
			TheReachAdj.Add(DornishMarches); TheReachAdj.Add(TheBoneway); TheReachAdj.Add(Kingswood);
			TheReach.AdjecantTerritories = TheReachAdj;

			List<Territory> HighgardenAdj = new List<Territory>();
			HighgardenAdj.Add(WestSummerSea); HighgardenAdj.Add(RedwyneStraights); HighgardenAdj.Add(Oldtown); HighgardenAdj.Add(DornishMarches);
			HighgardenAdj.Add(TheReach); HighgardenAdj.Add(SearoadMarches);
			Highgarden.AdjecantTerritories = HighgardenAdj;
            
			List<Territory> WestSummerSeaAdj = new List<Territory>();
			WestSummerSeaAdj.Add(SunsetSea); WestSummerSeaAdj.Add(SearoadMarches); WestSummerSeaAdj.Add(Highgarden); WestSummerSeaAdj.Add(RedwyneStraights);
			WestSummerSeaAdj.Add(TheArbor); WestSummerSeaAdj.Add(ThreeTowers); WestSummerSeaAdj.Add(Starfall); WestSummerSeaAdj.Add(EastSummerSea);
			WestSummerSea.AdjecantTerritories = WestSummerSeaAdj;

			List<Territory> RedwyneStraightsAdj = new List<Territory>();
			RedwyneStraightsAdj.Add(WestSummerSea); RedwyneStraightsAdj.Add(Highgarden); RedwyneStraightsAdj.Add(Oldtown); RedwyneStraightsAdj.Add(OldtownHarbor);
			RedwyneStraightsAdj.Add(TheArbor); RedwyneStraightsAdj.Add(ThreeTowers);
			RedwyneStraights.AdjecantTerritories = RedwyneStraightsAdj;

			List<Territory> TheArborAdj = new List<Territory>();
			TheArborAdj.Add(RedwyneStraights); TheArborAdj.Add(WestSummerSea);
			TheArbor.AdjecantTerritories = TheArborAdj;

			List<Territory> OldtownHarborAdj = new List<Territory>();
			OldtownHarborAdj.Add(RedwyneStraights); 
			OldtownHarbor.AdjecantTerritories = OldtownHarborAdj;

			List<Territory> OldtownAdj = new List<Territory>();
			OldtownAdj.Add(Highgarden); OldtownAdj.Add(RedwyneStraights); OldtownAdj.Add(DornishMarches); OldtownAdj.Add(ThreeTowers);
			Oldtown.AdjecantTerritories = OldtownAdj;
            
			List<Territory> ThreeTowersAdj = new List<Territory>();
			ThreeTowersAdj.Add(RedwyneStraights); ThreeTowersAdj.Add(WestSummerSea); ThreeTowersAdj.Add(Oldtown); ThreeTowersAdj.Add(DornishMarches);
			ThreeTowersAdj.Add(PrincesPass);
			ThreeTowers.AdjecantTerritories = ThreeTowersAdj;

			List<Territory> DornishMarchesAdj = new List<Territory>();
			DornishMarchesAdj.Add(Highgarden); DornishMarchesAdj.Add(Oldtown); DornishMarchesAdj.Add(ThreeTowers); DornishMarchesAdj.Add(PrincesPass);
			DornishMarchesAdj.Add(TheBoneway); DornishMarchesAdj.Add(TheReach);
			DornishMarches.AdjecantTerritories = DornishMarchesAdj;

			List<Territory> PrincesPassAdj = new List<Territory>();
			PrincesPassAdj.Add(ThreeTowers); PrincesPassAdj.Add(DornishMarches); PrincesPassAdj.Add(TheBoneway); PrincesPassAdj.Add(Yronwood);
			PrincesPassAdj.Add(Starfall);
			PrincesPass.AdjecantTerritories = PrincesPassAdj;

            List<Territory> StarfallAdj = new List<Territory>();
            StarfallAdj.Add(PrincesPass); StarfallAdj.Add(Yronwood); StarfallAdj.Add(SaltShore); StarfallAdj.Add(WestSummerSea);
            StarfallAdj.Add(EastSummerSea);
            Starfall.AdjecantTerritories = StarfallAdj;

            List<Territory> SaltShoreAdj = new List<Territory>();
            SaltShoreAdj.Add(Starfall); SaltShoreAdj.Add(Yronwood); SaltShoreAdj.Add(Sunspear); SaltShoreAdj.Add(EastSummerSea);
            SaltShore.AdjecantTerritories = SaltShoreAdj;
            
            List<Territory> TheBonewayAdj = new List<Territory>();
            TheBonewayAdj.Add(StormsEnd); TheBonewayAdj.Add(Kingswood); TheBonewayAdj.Add(TheReach); TheBonewayAdj.Add(DornishMarches);
            TheBonewayAdj.Add(PrincesPass); TheBonewayAdj.Add(Yronwood); TheBonewayAdj.Add(SeaOfDorne);
            TheBoneway.AdjecantTerritories = TheBonewayAdj;

            List<Territory> YronwoodAdj = new List<Territory>();
            YronwoodAdj.Add(TheBoneway); YronwoodAdj.Add(PrincesPass); YronwoodAdj.Add(Starfall); YronwoodAdj.Add(SaltShore);
            YronwoodAdj.Add(SunsetSea); YronwoodAdj.Add(SeaOfDorne);
            Yronwood.AdjecantTerritories = YronwoodAdj;

            List<Territory> SunspearAdj = new List<Territory>();
            SunspearAdj.Add(SeaOfDorne); SunspearAdj.Add(Yronwood); SunspearAdj.Add(SaltShore); SunspearAdj.Add(EastSummerSea);
            Sunspear.AdjecantTerritories = SunspearAdj;

            List<Territory> SunspearHarborAdj = new List<Territory>();
            SunspearHarborAdj.Add(EastSummerSea);
            SunspearHarbor.AdjecantTerritories = SunspearHarborAdj;

            List<Territory> SeaOfDorneAdj = new List<Territory>();
            SeaOfDorneAdj.Add(StormsEnd); SeaOfDorneAdj.Add(TheBoneway); SeaOfDorneAdj.Add(Yronwood); SeaOfDorneAdj.Add(Sunspear);
            SeaOfDorneAdj.Add(EastSummerSea);
            SeaOfDorne.AdjecantTerritories = SeaOfDorneAdj;

            List<Territory> EastSummerSeaAdj = new List<Territory>();
            EastSummerSeaAdj.Add(ShipbreakerBay); EastSummerSeaAdj.Add(StormsEnd); EastSummerSeaAdj.Add(SeaOfDorne); EastSummerSeaAdj.Add(Sunspear);
            EastSummerSeaAdj.Add(SunspearHarbor); EastSummerSeaAdj.Add(SaltShore); EastSummerSeaAdj.Add(Starfall); EastSummerSeaAdj.Add(WestSummerSea);
            EastSummerSea.AdjecantTerritories = EastSummerSeaAdj;




            return AllTerritories;
		}

		//Makes a cross reference, that when one territory is adjecant to another, it go both ways!
        public static void check(List<Territory> fulllist) 
        {
            foreach (Territory t1 in fulllist) 
            {
                bool flag = false;
                foreach (Territory t2 in t1.AdjecantTerritories) 
                {
                    foreach (Territory t3 in t2.AdjecantTerritories) 
                    {
                        if (t3 == t1) { flag = true; }
                    }
                }
                if (!flag) { throw new Exception("Two territories not in each other adjecant"); }
            }
        }

	}

