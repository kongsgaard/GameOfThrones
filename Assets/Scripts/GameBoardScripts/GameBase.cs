using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameBase : MonoBehaviour {
	static public List<Territory> TerritoryList;
	static public List<House> HouseList = new List<House>();
    static public WildlingTrack wildlingTrack;
	static public InfluenceTrack IronThroneTrack;
	static public InfluenceTrack FeifdomTrack;
	static public InfluenceTrack KingsCourtTrack;
	static public RoundTrack roundTrack;
    static public SupplyTrack supplyTrack;
	static public BannedOrders bannedOrders;
	
	//The house of the player..
	static public House myHouse;


	// Use this for initialization
	void Start () 
	{
        GameBase.TerritoryList = DeclareTerritories.MakeTerritories();
        GameBase.wildlingTrack = new WildlingTrack(2);
		GameBase.IronThroneTrack = new InfluenceTrack(6);
		GameBase.FeifdomTrack = new InfluenceTrack(6);
		GameBase.KingsCourtTrack = new InfluenceTrack(6);
		GameBase.roundTrack = new RoundTrack(1);
        GameBase.supplyTrack = new SupplyTrack();
		GameBase.bannedOrders = new BannedOrders();

		#region Houses are given territories
		List<Territory> BaratheonTerritory = new List<Territory>();
		foreach (Territory T in TerritoryList)
		{
			if (T.Name == "Kingswood") { BaratheonTerritory.Add(T); }
			if (T.Name == "ShipbreakerBay") { BaratheonTerritory.Add(T); }
			if (T.Name == "Dragonstone") { BaratheonTerritory.Add(T); }
			if (T.Name == "DragonstoneHarbor") { BaratheonTerritory.Add(T); }
		}

		List<Territory> StarkTerritory = new List<Territory>();
		foreach (Territory T in TerritoryList)
        {
            if (T.Name == "TheStonyShore") { StarkTerritory.Add(T); }
			if (T.Name == "Winterfell") { StarkTerritory.Add(T); }
			if (T.Name == "WinterfellHarbor") { StarkTerritory.Add(T); }
			if (T.Name == "WhiteHarbor") { StarkTerritory.Add(T); }
			if (T.Name == "WhiteHarborHarbor") { StarkTerritory.Add(T); }
			if (T.Name == "TheShiveringSea") { StarkTerritory.Add(T); }
		}

		List<Territory> GreyjoyTerritory = new List<Territory>();
		foreach (Territory T in TerritoryList)
		{
			if (T.Name == "Pyke") { GreyjoyTerritory.Add(T); }
			if (T.Name == "PykeHarbor") { GreyjoyTerritory.Add(T); }
			if (T.Name == "IronmansBay") { GreyjoyTerritory.Add(T); }
			if (T.Name == "GreywaterWatch") { GreyjoyTerritory.Add(T); }
		}

		List<Territory> LannisterTerritory = new List<Territory>();
		foreach (Territory T in TerritoryList)
		{
			if (T.Name == "TheGoldenSound") { LannisterTerritory.Add(T); }
			if (T.Name == "Lannisport") { LannisterTerritory.Add(T); }
			if (T.Name == "LannisportHarbor") { LannisterTerritory.Add(T); }
			if (T.Name == "StoneySept") { LannisterTerritory.Add(T); }
		}

		List<Territory> TyrellTerritory = new List<Territory>();
		foreach (Territory T in TerritoryList)
		{
			if (T.Name == "RedwyneStraights") { TyrellTerritory.Add(T); }
			if (T.Name == "Highgarden") { TyrellTerritory.Add(T); }
			if (T.Name == "DornishMarches") { TyrellTerritory.Add(T); }
		}

		List<Territory> MartellTerritory = new List<Territory>();
		foreach (Territory T in TerritoryList)
		{
			if (T.Name == "SeaOfDorne") { MartellTerritory.Add(T); }
			if (T.Name == "Sunspear") { MartellTerritory.Add(T); }
			if (T.Name == "SunspearHarbor") { MartellTerritory.Add(T); }
			if (T.Name == "SaltShore") { MartellTerritory.Add(T); }
		}
		#endregion


		#region Houses are created from the Selected Houses in HouseSelection level
        /*
        List<HouseSelect> houseSelectList_fromHouseSelect = HouseSelectList.houseSelectList;

        foreach (HouseSelect hs in houseSelectList_fromHouseSelect) 
        {
			if (hs.House == "Stark") 
			{
				House Stark = new House(HouseCharacter.Stark, StarkTerritory, null, 15, 5, hs.gp);
				HouseList.Add(Stark);
			}
			else if (hs.House == "Baratheon") 
			{
				House Baratheon = new House(HouseCharacter.Baratheon, BaratheonTerritory, null, 15, 5, hs.gp);
				HouseList.Add(Baratheon);
			}
			else if (hs.House == "Greyjoy") 
			{
				House Greyjoy = new House(HouseCharacter.Greyjoy, GreyjoyTerritory, null, 15, 5, hs.gp);
				HouseList.Add(Greyjoy);
			}
			else if (hs.House == "Lannister") 
			{
				House Lannister = new House(HouseCharacter.Lannister, LannisterTerritory, null, 15, 5, hs.gp);
				HouseList.Add(Lannister);
			}
			else if (hs.House == "Tyrell") 
			{
				House Tyrell = new House(HouseCharacter.Tyrell, TyrellTerritory, null, 15, 5,hs.gp);
				HouseList.Add(Tyrell);
			}
			else if (hs.House == "Martell") 
			{
				House Martell = new House(HouseCharacter.Martell, MartellTerritory, null, 15, 5, hs.gp);
				HouseList.Add(Martell);
			}
		}
        */
		#endregion

		#region myHouse set
        /*
        foreach (HouseSelect hs in houseSelectList_fromHouseSelect) 
		{
			if (hs.gp._player == Network.player) 
			{
				foreach (House h in HouseList) 
				{
					if (hs.House == "Stark" && h.HouseCharacter == HouseCharacter.Stark) 
					{
						myHouse = h;
					}
					else if (hs.House == "Greyjoy" && h.HouseCharacter == HouseCharacter.Greyjoy) 
					{
						myHouse = h;
					}
					else if (hs.House == "Baratheon" && h.HouseCharacter == HouseCharacter.Baratheon)
					{
						myHouse = h;
					}
					else if (hs.House == "Lannister" && h.HouseCharacter == HouseCharacter.Lannister)
					{
						myHouse = h;
					}
					else if (hs.House == "Martell" && h.HouseCharacter == HouseCharacter.Martell)
					{
						myHouse = h;
					}
					else if (hs.House == "Tyrell" && h.HouseCharacter == HouseCharacter.Tyrell)
					{
						myHouse = h;
					}
				}
			}
		}
        */
		#endregion

		/* Test code! */
		House Greyjoy1 = new House(HouseCharacter.Greyjoy, GreyjoyTerritory, null, 15, 5, null);
        House Stark1 = new House(HouseCharacter.Stark, StarkTerritory, null, 15, 5, null);
		House Baratheon1 = new House(HouseCharacter.Baratheon, BaratheonTerritory, null, 15, 5, null);
		House Martell1 = new House(HouseCharacter.Martell, MartellTerritory, null, 15, 5, null);
		House Tyrell1 = new House(HouseCharacter.Tyrell, TyrellTerritory, null, 15, 5, null);
		House Lannister1 = new House(HouseCharacter.Lannister, LannisterTerritory, null, 15, 5, null);

        #region TestHouses place units on Territories
        foreach (Territory T in TerritoryList)
        {
            if (T.Name == "Kingswood") { Baratheon1.PlaceUnitOnTerritory(T, Baratheon1.ReturnSomeFootman()); }
            if (T.Name == "ShipbreakerBay") { Baratheon1.PlaceUnitOnTerritory(T, Baratheon1.ReturnSomeShip()); Baratheon1.PlaceUnitOnTerritory(T, Baratheon1.ReturnSomeShip()); }
            if (T.Name == "Dragonstone") { Baratheon1.PlaceUnitOnTerritory(T, Baratheon1.ReturnSomeKnight()); Baratheon1.PlaceUnitOnTerritory(T, Baratheon1.ReturnSomeFootman()); }
            if (T.Name == "DragonstoneHarbor") { }
        }

        foreach (Territory T in TerritoryList)
        {
            if (T.Name == "TheStonyShore") { Stark1.PlaceUnitOnTerritory(T, Stark1.ReturnSomeFootman()); }
            if (T.Name == "Winterfell") { Stark1.PlaceUnitOnTerritory(T, Stark1.ReturnSomeKnight()); Stark1.PlaceUnitOnTerritory(T, Stark1.ReturnSomeFootman()); }
            if (T.Name == "WinterfellHarbor") { }
            if (T.Name == "WhiteHarbor") { Stark1.PlaceUnitOnTerritory(T, Stark1.ReturnSomeFootman()); }
            if (T.Name == "WhiteHarborHarbor") { }
            if (T.Name == "TheShiveringSea") { Stark1.PlaceUnitOnTerritory(T, Stark1.ReturnSomeShip()); }
        }

        foreach (Territory T in TerritoryList)
        {
            if (T.Name == "Pyke") { Greyjoy1.PlaceUnitOnTerritory(T, Greyjoy1.ReturnSomeKnight()); Greyjoy1.PlaceUnitOnTerritory(T, Greyjoy1.ReturnSomeFootman()); }
            if (T.Name == "PykeHarbor") { Greyjoy1.PlaceUnitOnTerritory(T, Greyjoy1.ReturnSomeShip()); }
            if (T.Name == "IronmansBay") { Greyjoy1.PlaceUnitOnTerritory(T, Greyjoy1.ReturnSomeShip()); }
            if (T.Name == "GreywaterWatch") { Greyjoy1.PlaceUnitOnTerritory(T, Greyjoy1.ReturnSomeFootman()); }
        }

        foreach (Territory T in TerritoryList)
        {
            if (T.Name == "TheGoldenSound") { Lannister1.PlaceUnitOnTerritory(T, Lannister1.ReturnSomeShip()); }
            if (T.Name == "Lannisport") { Lannister1.PlaceUnitOnTerritory(T, Lannister1.ReturnSomeKnight()); Lannister1.PlaceUnitOnTerritory(T, Lannister1.ReturnSomeFootman()); }
            if (T.Name == "LannisportHarbor") { }
            if (T.Name == "StoneySept") { Lannister1.PlaceUnitOnTerritory(T, Lannister1.ReturnSomeFootman()); }
        }

        foreach (Territory T in TerritoryList)
        {
            if (T.Name == "RedwyneStraights") { Tyrell1.PlaceUnitOnTerritory(T, Tyrell1.ReturnSomeShip()); }
            if (T.Name == "Highgarden") { Tyrell1.PlaceUnitOnTerritory(T, Tyrell1.ReturnSomeKnight()); Tyrell1.PlaceUnitOnTerritory(T, Tyrell1.ReturnSomeFootman()); }
            if (T.Name == "DornishMarches") { Tyrell1.PlaceUnitOnTerritory(T, Tyrell1.ReturnSomeFootman()); }
        }

        foreach (Territory T in TerritoryList)
        {
            if (T.Name == "SeaOfDorne") { Martell1.PlaceUnitOnTerritory(T, Martell1.ReturnSomeShip()); }
            if (T.Name == "Sunspear") { Martell1.PlaceUnitOnTerritory(T, Martell1.ReturnSomeKnight()); Martell1.PlaceUnitOnTerritory(T, Martell1.ReturnSomeFootman()); }
            if (T.Name == "SunspearHarbor") { }
            if (T.Name == "SaltShore") { Martell1.PlaceUnitOnTerritory(T, Martell1.ReturnSomeFootman()); }
        }
        #endregion

		myHouse = Stark1;

        HouseList.Add(Greyjoy1); HouseList.Add(Stark1); HouseList.Add(Baratheon1); 
        HouseList.Add(Martell1); HouseList.Add(Tyrell1); HouseList.Add(Lannister1);

        supplyTrack.SetSupplyForAllBasedOnTerritory();

		#region TestHouses IfluenceTrack assign
		IronThroneTrack.InsertHouseAtPosition(1, Baratheon1); IronThroneTrack.InsertHouseAtPosition(2, Lannister1);
		IronThroneTrack.InsertHouseAtPosition(3, Stark1); IronThroneTrack.InsertHouseAtPosition(4, Martell1);
		IronThroneTrack.InsertHouseAtPosition(5, Greyjoy1); IronThroneTrack.InsertHouseAtPosition(6, Tyrell1);

		FeifdomTrack.InsertHouseAtPosition(1, Greyjoy1); FeifdomTrack.InsertHouseAtPosition(2, Tyrell1);
		FeifdomTrack.InsertHouseAtPosition(3, Martell1); FeifdomTrack.InsertHouseAtPosition(4, Stark1);
		FeifdomTrack.InsertHouseAtPosition(5, Baratheon1); FeifdomTrack.InsertHouseAtPosition(6, Lannister1);

		KingsCourtTrack.InsertHouseAtPosition(1, Lannister1); KingsCourtTrack.InsertHouseAtPosition(2, Stark1);
		KingsCourtTrack.InsertHouseAtPosition(3, Martell1); KingsCourtTrack.InsertHouseAtPosition(4, Baratheon1);
		KingsCourtTrack.InsertHouseAtPosition(5, Tyrell1); KingsCourtTrack.InsertHouseAtPosition(6, Greyjoy1);
		#endregion

	}
}
