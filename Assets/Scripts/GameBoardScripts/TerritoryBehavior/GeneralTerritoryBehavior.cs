using UnityEngine;
using System.Collections;

public class GeneralTerritoryBehavior : TerritoryBehaviorObserver {

	public TerritorySubject mySubject;
	protected Territory myTerritory;

	protected GameObject Unit0;
	protected GameObject Unit1;
	protected GameObject Unit2;
	protected GameObject Unit3;
	protected GameObject[] RenderedUnits = new GameObject[4];

	protected Vector3 Unit3Pos;
	protected Vector3 Unit0Pos;
	protected Vector3 Unit1Pos;
	protected Vector3 Unit2Pos;

	protected Vector3 Scale = new Vector3((float)0.4, (float)0.4, (float)0.4);

	protected Vector3[] UnitPositions = new Vector3[4];

	public override void UpdateUnits()
	{
		//Change to units happened, destroy the old ones
		foreach (GameObject obj in RenderedUnits)
		{
			Destroy(obj);
		}

		//Render the new unit list for the territory
		for (int i = 0; i < myTerritory.Units.Count; i++)
		{
			RenderUnit(myTerritory.Units[i], i);
		}
	}

	public override void UpdatePowerToken()
	{
	}

	public override void UpdateOrderToken()
	{
		if (myTerritory.Owner != null && myTerritory.PlacedOrderToken != null)
		{
			RenderOrderToken(myTerritory.PlacedOrderToken);
		}
	}

	protected GameObject RenderedOrderToken;
	protected Vector3 OrderTokenPos;
	protected void RenderOrderToken(OrderToken ot)
	{
		Destroy(RenderedOrderToken);

		RenderedOrderToken = new GameObject();
		RenderedOrderToken.name = "OrderToken";

		RenderedOrderToken.AddComponent<Rigidbody>();
		RenderedOrderToken.GetComponent<Rigidbody>().useGravity = false;

		RenderedOrderToken.AddComponent<MeshRenderer>();
		RenderedOrderToken.GetComponent<Renderer>().castShadows = true;
		RenderedOrderToken.GetComponent<Renderer>().receiveShadows = true;

		RenderedOrderToken.AddComponent<MeshFilter>();
		RenderedOrderToken.GetComponent<MeshFilter>().mesh = (Mesh)((GameObject)Resources.Load("Graphics/Models/Other/OrderToken")).GetComponent<MeshFilter>().mesh;

		string MaterialLoad = "Graphics/OrderTokenMaterials/";
		if (myTerritory.Owner.HouseCharacter == HouseCharacter.Baratheon)
		{
			MaterialLoad = MaterialLoad + "BaratheonOrder";
		}
		else if (myTerritory.Owner.HouseCharacter == HouseCharacter.Greyjoy)
		{
			MaterialLoad = MaterialLoad + "GreyjoyOrder";
		}
		else if (myTerritory.Owner.HouseCharacter == HouseCharacter.Lannister)
		{
			MaterialLoad = MaterialLoad + "LannisterOrder";
		}
		else if (myTerritory.Owner.HouseCharacter == HouseCharacter.Martell)
		{
			MaterialLoad = MaterialLoad + "MartellOrder";
		}
		else if (myTerritory.Owner.HouseCharacter == HouseCharacter.Stark)
		{
			MaterialLoad = MaterialLoad + "StarkOrder";
		}
		else if (myTerritory.Owner.HouseCharacter == HouseCharacter.Tyrell)
		{
			MaterialLoad = MaterialLoad + "TyrellOrder";
		}

		if (myTerritory.Owner.HouseCharacter == GameBase.myHouse.HouseCharacter)
		{
			MaterialLoad = "Graphics/OrderTokenMaterials/";
			if (myTerritory.PlacedOrderToken.Type == OrderTokenType.ConsolidatePowerOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Normal)
			{
				MaterialLoad = MaterialLoad + "Consolidate";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.ConsolidatePowerOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Star)
			{
				MaterialLoad = MaterialLoad + "ConsolidateP";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.DefendOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Normal)
			{
				MaterialLoad = MaterialLoad + "Defense";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.DefendOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Star)
			{
				MaterialLoad = MaterialLoad + "DefenseP";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.MoveOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.MinusOne)
			{
				MaterialLoad = MaterialLoad + "MarchM";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.MoveOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Normal)
			{
				MaterialLoad = MaterialLoad + "March";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.MoveOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Star)
			{
				MaterialLoad = MaterialLoad + "MarchP";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.RaidOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Normal)
			{
				MaterialLoad = MaterialLoad + "Raid";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.RaidOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Star)
			{
				MaterialLoad = MaterialLoad + "RaidP";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.SupportOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Normal)
			{
				MaterialLoad = MaterialLoad + "Support";
			}
			else if (myTerritory.PlacedOrderToken.Type == OrderTokenType.SupportOrder && myTerritory.PlacedOrderToken.Strenght == OrderTokenStrenght.Star)
			{
				MaterialLoad = MaterialLoad + "SupportP";
			}
		}

		RenderedOrderToken.GetComponent<Renderer>().material = (Material)Resources.Load(MaterialLoad);

		RenderedOrderToken.transform.localScale = new Vector3((float)0.5, (float)0.5, (float)0.5);
		RenderedOrderToken.transform.position = OrderTokenPos;
		RenderedOrderToken.transform.rotation = Quaternion.Euler(270, 0, 0);
	}

	protected void RenderUnit(Unit U, int i)
	{

		RenderedUnits[i] = new GameObject();
        RenderedUnits[i].name = U.Owner.ToString() + U.Type.ToString();

		RenderedUnits[i].AddComponent<Rigidbody>();
		RenderedUnits[i].GetComponent<Rigidbody>().useGravity = false;

		RenderedUnits[i].AddComponent<MeshRenderer>();
		RenderedUnits[i].AddComponent<MeshFilter>();
		RenderedUnits[i].GetComponent<Renderer>().castShadows = true;
		RenderedUnits[i].GetComponent<Renderer>().receiveShadows = true;



		if (U.Type == UnitType.Footman)
		{
			RenderedUnits[i].GetComponent<MeshFilter>().mesh = ((GameObject)Resources.Load("Graphics/Models/Units/Footman")).GetComponent<MeshFilter>().mesh;
		}
		else if (U.Type == UnitType.Ship)
		{
			RenderedUnits[i].GetComponent<MeshFilter>().mesh = ((GameObject)Resources.Load("Graphics/Models/Units/Ship")).GetComponent<MeshFilter>().mesh;
		}
		else if (U.Type == UnitType.Knight)
		{
			RenderedUnits[i].GetComponent<MeshFilter>().mesh = ((GameObject)Resources.Load("Graphics/Models/Units/Knight")).GetComponent<MeshFilter>().mesh;
		}
		else if (U.Type == UnitType.SiegeTower)
		{
			RenderedUnits[i].GetComponent<MeshFilter>().mesh = ((GameObject)Resources.Load("Graphics/Models/Units/SiegeTower")).GetComponent<MeshFilter>().mesh;
		}


		string MaterialLoad = "Graphics/UnitMaterials/";

		if (U.Owner.HouseCharacter == HouseCharacter.Baratheon)
		{
			MaterialLoad = MaterialLoad + "Baratheon/Baratheon";
		}
		else if (U.Owner.HouseCharacter == HouseCharacter.Greyjoy)
		{
			MaterialLoad = MaterialLoad + "Greyjoy/Greyjoy";
		}
		else if (U.Owner.HouseCharacter == HouseCharacter.Lannister)
		{
			MaterialLoad = MaterialLoad + "Lannister/Lannister";
		}
		else if (U.Owner.HouseCharacter == HouseCharacter.Martell)
		{
			MaterialLoad = MaterialLoad + "Martell/Martell";
		}
		else if (U.Owner.HouseCharacter == HouseCharacter.Stark)
		{
			MaterialLoad = MaterialLoad + "Stark/Stark";
		}
		else if (U.Owner.HouseCharacter == HouseCharacter.Tyrell)
		{
			MaterialLoad = MaterialLoad + "Tyrell/Tyrell";
		}

		if (!U.Alive)
		{
			MaterialLoad = MaterialLoad + "Routed";
		}

		if (U.Type == UnitType.Footman)
		{
			MaterialLoad = MaterialLoad + "Footman";
		}
		else if (U.Type == UnitType.Ship)
		{
			MaterialLoad = MaterialLoad + "Ship";
		}
		else if (U.Type == UnitType.Knight)
		{
			MaterialLoad = MaterialLoad + "Knight";
		}
		else if (U.Type == UnitType.SiegeTower)
		{
			MaterialLoad = MaterialLoad + "Siege";
		}

		RenderedUnits[i].GetComponent<Renderer>().material = (Material)Resources.Load(MaterialLoad);

		RenderedUnits[i].transform.position = UnitPositions[i];
		RenderedUnits[i].transform.rotation = Quaternion.Euler(270, 0, 0);
		RenderedUnits[i].transform.localScale = Scale;
	}
}
