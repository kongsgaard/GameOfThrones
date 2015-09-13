using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameSetup : MonoBehaviour {

	// Use this for initialization
	void Start () {

        #region Houses are given territories
        List<Territory> BaratheonTerritory = new List<Territory>();
        foreach (Territory T in GameBase.TerritoryList)
        {
            if (T.Name == "Kingswood") { BaratheonTerritory.Add(T); }
            if (T.Name == "ShipbreakerBay") { BaratheonTerritory.Add(T); }
            if (T.Name == "Dragonstone") { BaratheonTerritory.Add(T); }
            if (T.Name == "DragonstoneHarbor") { BaratheonTerritory.Add(T); }
        }

        List<Territory> StarkTerritory = new List<Territory>();
        foreach (Territory T in GameBase.TerritoryList)
        {
            if (T.Name == "TheStonyShore") { StarkTerritory.Add(T); }
            if (T.Name == "Winterfell") { StarkTerritory.Add(T); }
            if (T.Name == "WinterfellHarbor") { StarkTerritory.Add(T); }
            if (T.Name == "WhiteHarbor") { StarkTerritory.Add(T); }
            if (T.Name == "WhiteHarborHarbor") { StarkTerritory.Add(T); }
            if (T.Name == "TheShiveringSea") { StarkTerritory.Add(T); }
        }

        List<Territory> GreyjoyTerritory = new List<Territory>();
        foreach (Territory T in GameBase.TerritoryList)
        {
            if (T.Name == "Pyke") { GreyjoyTerritory.Add(T); }
            if (T.Name == "PykeHarbor") { GreyjoyTerritory.Add(T); }
            if (T.Name == "IronmansBay") { GreyjoyTerritory.Add(T); }
            if (T.Name == "GreywaterWatch") { GreyjoyTerritory.Add(T); }
        }

        List<Territory> LannisterTerritory = new List<Territory>();
        foreach (Territory T in GameBase.TerritoryList)
        {
            if (T.Name == "TheGoldenSound") { LannisterTerritory.Add(T); }
            if (T.Name == "Lannisport") { LannisterTerritory.Add(T); }
            if (T.Name == "LannisportHarbor") { LannisterTerritory.Add(T); }
            if (T.Name == "StoneySept") { LannisterTerritory.Add(T); }
        }

        List<Territory> TyrellTerritory = new List<Territory>();
        foreach (Territory T in GameBase.TerritoryList)
        {
            if (T.Name == "RedwyneStraights") { TyrellTerritory.Add(T); }
            if (T.Name == "Highgarden") { TyrellTerritory.Add(T); }
            if (T.Name == "DornishMarches") { TyrellTerritory.Add(T); }
        }

        List<Territory> MartellTerritory = new List<Territory>();
        foreach (Territory T in GameBase.TerritoryList)
        {
            if (T.Name == "SeaOfDorne") { MartellTerritory.Add(T); }
            if (T.Name == "Sunspear") { MartellTerritory.Add(T); }
            if (T.Name == "SunspearHarbor") { MartellTerritory.Add(T); }
            if (T.Name == "SaltShore") { MartellTerritory.Add(T); }
        }
        #endregion

        #region Setup code to proerly start the game from the gameboard screen
        List<HouseSelect> housesSelected = GameBase.houseSelected;

        HouseSelect player = new HouseSelect("Stark");
        player.gp = new GamePlayer("player_Stark", playerType.player);
        housesSelected.Add(player);

        HouseSelect ai_baratheon = new HouseSelect("Baratheon");
        ai_baratheon.gp = new GamePlayer("ai_Baratheon", playerType.AI);
        housesSelected.Add(ai_baratheon);

        foreach (HouseSelect hs in housesSelected)
        {
            if (hs.House == "Stark")
            {
                House Stark = new House(HouseCharacter.Stark, StarkTerritory, null, 15, 5, hs.gp);
                GameBase.HouseList.Add(Stark);

                foreach (Territory T in GameBase.TerritoryList)
                {
                    
                    if (T.Name == "TheStonyShore") { Stark.PlaceUnitOnTerritory(T, Stark.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "Winterfell") { Stark.PlaceUnitOnTerritory(T, Stark.ReturnSomeUnitGivenType(UnitType.Knight)); Stark.PlaceUnitOnTerritory(T, Stark.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "WinterfellHarbor") { }
                    if (T.Name == "WhiteHarbor") { Stark.PlaceUnitOnTerritory(T, Stark.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "WhiteHarborHarbor") { }
                    if (T.Name == "TheShiveringSea") { Stark.PlaceUnitOnTerritory(T, Stark.ReturnSomeUnitGivenType(UnitType.Ship)); }
                }

                GameBase.myHouse = Stark;

                GameBase.IronThroneTrack.InsertHouseAtPosition(3, Stark);
                GameBase.FeifdomTrack.InsertHouseAtPosition(4, Stark);
                GameBase.KingsCourtTrack.InsertHouseAtPosition(2, Stark);
            }
            else if (hs.House == "Baratheon")
            {
                House Baratheon = new House(HouseCharacter.Baratheon, BaratheonTerritory, null, 15, 5, hs.gp);
                GameBase.HouseList.Add(Baratheon);

                foreach (Territory T in GameBase.TerritoryList)
                {
                    if (T.Name == "Kingswood") { Baratheon.PlaceUnitOnTerritory(T, Baratheon.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "ShipbreakerBay") { Baratheon.PlaceUnitOnTerritory(T, Baratheon.ReturnSomeUnitGivenType(UnitType.Ship)); Baratheon.PlaceUnitOnTerritory(T, Baratheon.ReturnSomeUnitGivenType(UnitType.Ship)); }
                    if (T.Name == "Dragonstone") { Baratheon.PlaceUnitOnTerritory(T, Baratheon.ReturnSomeUnitGivenType(UnitType.Knight)); Baratheon.PlaceUnitOnTerritory(T, Baratheon.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "DragonstoneHarbor") { }
                }

                GameBase.IronThroneTrack.InsertHouseAtPosition(1, Baratheon);
                GameBase.FeifdomTrack.InsertHouseAtPosition(5, Baratheon);
                GameBase.KingsCourtTrack.InsertHouseAtPosition(4, Baratheon);
            }
            else if (hs.House == "Greyjoy")
            {
                House Greyjoy = new House(HouseCharacter.Greyjoy, GreyjoyTerritory, null, 15, 5, hs.gp);
                GameBase.HouseList.Add(Greyjoy);

                foreach (Territory T in GameBase.TerritoryList)
                {
                    if (T.Name == "Pyke") { Greyjoy.PlaceUnitOnTerritory(T, Greyjoy.ReturnSomeUnitGivenType(UnitType.Knight)); Greyjoy.PlaceUnitOnTerritory(T, Greyjoy.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "PykeHarbor") { Greyjoy.PlaceUnitOnTerritory(T, Greyjoy.ReturnSomeUnitGivenType(UnitType.Ship)); }
                    if (T.Name == "IronmansBay") { Greyjoy.PlaceUnitOnTerritory(T, Greyjoy.ReturnSomeUnitGivenType(UnitType.Ship)); }
                    if (T.Name == "GreywaterWatch") { Greyjoy.PlaceUnitOnTerritory(T, Greyjoy.ReturnSomeUnitGivenType(UnitType.Footman)); }
                }

                GameBase.IronThroneTrack.InsertHouseAtPosition(5, Greyjoy);
                GameBase.FeifdomTrack.InsertHouseAtPosition(1, Greyjoy);
                GameBase.KingsCourtTrack.InsertHouseAtPosition(6, Greyjoy);
            }
            else if (hs.House == "Lannister")
            {
                House Lannister = new House(HouseCharacter.Lannister, LannisterTerritory, null, 15, 5, hs.gp);
                GameBase.HouseList.Add(Lannister);

                foreach (Territory T in GameBase.TerritoryList)
                {
                    if (T.Name == "TheGoldenSound") { Lannister.PlaceUnitOnTerritory(T, Lannister.ReturnSomeUnitGivenType(UnitType.Ship)); }
                    if (T.Name == "Lannisport") { Lannister.PlaceUnitOnTerritory(T, Lannister.ReturnSomeUnitGivenType(UnitType.Knight)); Lannister.PlaceUnitOnTerritory(T, Lannister.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "LannisportHarbor") { }
                    if (T.Name == "StoneySept") { Lannister.PlaceUnitOnTerritory(T, Lannister.ReturnSomeUnitGivenType(UnitType.Footman)); }
                }

                GameBase.IronThroneTrack.InsertHouseAtPosition(2, Lannister);
                GameBase.FeifdomTrack.InsertHouseAtPosition(6, Lannister);
                GameBase.KingsCourtTrack.InsertHouseAtPosition(1, Lannister);
            }
            else if (hs.House == "Tyrell")
            {
                House Tyrell = new House(HouseCharacter.Tyrell, TyrellTerritory, null, 15, 5, hs.gp);
                GameBase.HouseList.Add(Tyrell);

                foreach (Territory T in GameBase.TerritoryList)
                {
                    if (T.Name == "RedwyneStraights") { Tyrell.PlaceUnitOnTerritory(T, Tyrell.ReturnSomeUnitGivenType(UnitType.Ship)); }
                    if (T.Name == "Highgarden") { Tyrell.PlaceUnitOnTerritory(T, Tyrell.ReturnSomeUnitGivenType(UnitType.Knight)); Tyrell.PlaceUnitOnTerritory(T, Tyrell.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "DornishMarches") { Tyrell.PlaceUnitOnTerritory(T, Tyrell.ReturnSomeUnitGivenType(UnitType.Footman)); }
                }

                GameBase.IronThroneTrack.InsertHouseAtPosition(6, Tyrell);
                GameBase.FeifdomTrack.InsertHouseAtPosition(2, Tyrell);
                GameBase.KingsCourtTrack.InsertHouseAtPosition(5, Tyrell);
            }
            else if (hs.House == "Martell")
            {
                House Martell = new House(HouseCharacter.Martell, MartellTerritory, null, 15, 5, hs.gp);
                GameBase.HouseList.Add(Martell);

                foreach (Territory T in GameBase.TerritoryList)
                {
                    if (T.Name == "SeaOfDorne") { Martell.PlaceUnitOnTerritory(T, Martell.ReturnSomeUnitGivenType(UnitType.Ship)); }
                    if (T.Name == "Sunspear") { Martell.PlaceUnitOnTerritory(T, Martell.ReturnSomeUnitGivenType(UnitType.Knight)); Martell.PlaceUnitOnTerritory(T, Martell.ReturnSomeUnitGivenType(UnitType.Footman)); }
                    if (T.Name == "SunspearHarbor") { }
                    if (T.Name == "SaltShore") { Martell.PlaceUnitOnTerritory(T, Martell.ReturnSomeUnitGivenType(UnitType.Footman)); }
                }

                GameBase.IronThroneTrack.InsertHouseAtPosition(4, Martell);
                GameBase.KingsCourtTrack.InsertHouseAtPosition(3, Martell);
                GameBase.FeifdomTrack.InsertHouseAtPosition(3, Martell);
            }
        }
        #endregion

        #region oldCreateHouse
        /*
		House Greyjoy = new House(HouseCharacter.Greyjoy, GreyjoyTerritory, null, 15, 5, null);
        House Stark = new House(HouseCharacter.Stark, StarkTerritory, null, 15, 5, null);
		House Baratheon1 = new House(HouseCharacter.Baratheon, BaratheonTerritory, null, 15, 5, null);
		House Martell = new House(HouseCharacter.Martell, MartellTerritory, null, 15, 5, null);
		House Tyrell = new House(HouseCharacter.Tyrell, TyrellTerritory, null, 15, 5, null);
		House Lannister = new House(HouseCharacter.Lannister, LannisterTerritory, null, 15, 5, null);
        */
        #endregion

        GameBase.supplyTrack.SetSupplyForAllBasedOnTerritory();

        GameBase.wildlingTrack.NotifyValueChange();
        Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
