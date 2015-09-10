using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HouseSelectList : MonoBehaviour {
	public static List<HouseSelect> houseSelectList = new List<HouseSelect>();
	

	// Use this for initialization
	void Start () {
		houseSelectList.Add(new HouseSelect("Stark"));
		houseSelectList.Add(new HouseSelect("Martell"));
	//	houseSelectList.Add(new HouseSelect("Greyjoy"));
	//	houseSelectList.Add(new HouseSelect("Lannister"));
	//	houseSelectList.Add(new HouseSelect("Tyrell"));
	//	houseSelectList.Add(new HouseSelect("Baratheon"));
	}

	void OnGUI() 
	{
		int i = 0;
		foreach (HouseSelect hs in houseSelectList) 
		{ 
			i++;
			if (GUI.Button(new Rect(i * 100, 10, 100, 100), hs.icon, "label")) 
			{
				GetComponent<NetworkView>().RPC("Server_HouseSelected", RPCMode.Server, hs.House, ConnectScript.my_GamePlayer._nickname);
			}
			
			if(hs.gp != null)
			{
				GUI.Label(new Rect(i*100, 110,100,20), hs.gp._nickname );
			}
		}

		if (Network.peerType == NetworkPeerType.Server) 
		{
			if (GUI.Button(new Rect(10,200,100,50), "Begin Game")) 
			{
				GetComponent<NetworkView>().RPC("Clients_BeginGame", RPCMode.All);
			}
		}

		int j = 0;
		foreach (GamePlayer gp in ConnectScript.GamePlayers) 
		{
			GUI.Label(new Rect(400, 400+j*20, 50,20), gp._nickname);
			j++;
		}

		
	}

	[RPC]
	void Clients_BeginGame() 
	{
		Application.LoadLevel("GameBoard");
	}

	[RPC]
	void Server_HouseSelected(string hsHouse, string gpNick) 
	{
		GetComponent<NetworkView>().RPC("Clients_HouseSelected", RPCMode.All, hsHouse, gpNick);
	}

	[RPC]
	void Clients_HouseSelected(string hsHouse, string gpNick) 
	{
		HouseSelect hs_current = null;
		foreach (HouseSelect hs2 in houseSelectList) 
		{
			if (hs2.House == hsHouse) 
			{
				hs_current = hs2;
				break;
			}
		}
		HouseSelect hs_selected = null;
		foreach (HouseSelect hs1 in houseSelectList) 
		{
			if (hs1.House == hs_current.House) 
			{
				hs_selected = hs1;
				break;
			}
		}

		GamePlayer gp1 = null;
		foreach (GamePlayer gp in ConnectScript.GamePlayers) 
		{
			if (gp._nickname == gpNick) 
			{
				gp1 = gp;
			}
		}


		foreach (HouseSelect hs in houseSelectList) 
		{
			if (hs.gp == gp1) 
			{
				hs.gp = null;
				break;
			}
		}

		hs_selected.gp = gp1;
	}


	// Update is called once per frame
	void Update () {
	
	}
}
