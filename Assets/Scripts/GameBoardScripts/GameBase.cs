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

    static public List<HouseSelect> houseSelected = new List<HouseSelect>();

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

        

	}
}