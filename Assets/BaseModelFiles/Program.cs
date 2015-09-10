using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

	class Program
	{

		static void Main(string[] args)
		{
            
            DeclareTerritories.check(DeclareTerritories.MakeTerritories());

			List<Territory> AllTerritories = DeclareTerritories.MakeTerritories();

			#region Houses are given territories
			List<Territory> BaratheonTerritory = new List<Territory>();
			foreach (Territory T in AllTerritories) 
			{
				if (T.Name == "Kingswood") { BaratheonTerritory.Add(T); }
				if (T.Name == "ShipbreakerBay") { BaratheonTerritory.Add(T); }
				if (T.Name == "Dragonstone") { BaratheonTerritory.Add(T); }
				if (T.Name == "DragonstoneHarbor") { BaratheonTerritory.Add(T); }
			}

			List<Territory> StarkTerritory = new List<Territory>();
			foreach (Territory T in AllTerritories)
			{
				if (T.Name == "Winterfell") { StarkTerritory.Add(T); }
				if (T.Name == "WinterfellHarbor") { StarkTerritory.Add(T); }
				if (T.Name == "WhiteHarbor") { StarkTerritory.Add(T); }
				if (T.Name == "WhiteHarborHarbor") { StarkTerritory.Add(T); }
				if (T.Name == "TheShiveringSea") { StarkTerritory.Add(T); }
			}

			List<Territory> GreyjoyTerritory = new List<Territory>();
			foreach (Territory T in AllTerritories)
			{
				if (T.Name == "Pyke") { GreyjoyTerritory.Add(T); }
				if (T.Name == "PykeHarbor") { GreyjoyTerritory.Add(T); }
				if (T.Name == "IronmansBay") { GreyjoyTerritory.Add(T); }
				if (T.Name == "GreywaterWatch") { GreyjoyTerritory.Add(T); }
			}

			List<Territory> LannisterTerritory = new List<Territory>();
			foreach (Territory T in AllTerritories)
			{
				if (T.Name == "TheGoldenSound") { LannisterTerritory.Add(T); }
				if (T.Name == "Lannisport") { LannisterTerritory.Add(T); }
				if (T.Name == "LannisportHarbor") { LannisterTerritory.Add(T); }
				if (T.Name == "StonySept") { LannisterTerritory.Add(T); }
			}

			List<Territory> TyrellTerritory = new List<Territory>();
			foreach (Territory T in AllTerritories)
			{
				if (T.Name == "RedwyneStraits") { TyrellTerritory.Add(T); }
				if (T.Name == "Highgarden") { TyrellTerritory.Add(T); }
				if (T.Name == "DornishMarches") { TyrellTerritory.Add(T); }
			}

			List<Territory> MartellTerritory = new List<Territory>();
			foreach (Territory T in AllTerritories)
			{
				if (T.Name == "SeaOfDorne") { MartellTerritory.Add(T); }
				if (T.Name == "Sunspear") { MartellTerritory.Add(T); }
				if (T.Name == "SunspearHarbor") { MartellTerritory.Add(T); }
				if (T.Name == "SaltShore") { MartellTerritory.Add(T); }
			}

			#endregion

		//	House Stark = new House(HouseCharacter.Stark, StarkTerritory, null, 3, 4, 2, 15, 5);
		//	House Baratheon = new House(HouseCharacter.Baratheon, BaratheonTerritory, null, 1,5,4,15,5);
		//	House Greyjoy = new House(HouseCharacter.Greyjoy, GreyjoyTerritory, null, 5, 1, 6,15,5);
		//	House Lannister = new House(HouseCharacter.Lannister, LannisterTerritory, null, 2,6,1,15,5);
		//	House Tyrell = new House(HouseCharacter.Tyrell, TyrellTerritory, null, 6,2,5,15,5);
		//	House Martell = new House(HouseCharacter.Martell, MartellTerritory, null, 4, 3, 3, 15, 5);

			Console.ReadLine();


		}
	}

