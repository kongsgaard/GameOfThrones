using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System;


public class ConnectScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public bool ShowMenu_MainMenu = true;
	public bool ShowMenu_HostingLobby = false;
	public bool ShowMenu_ConnectedLobby = false;


	string IPconnect = "127.0.0.1";
	int Portconnect = 25001;

//	string IPhost = "127.0.0.1";
	int PortHost = 25001;

	string Host_PlayerName = "Host";
	string Connect_PlayerName = "ConnectPlayer";

	void MainMenuGUI() 
	{
		if (GUI.Button(new Rect(10, 10, 200, 70), "Host a server"))
		{
			Network.InitializeServer(8, PortHost, true);
			ShowMenu_HostingLobby = true;
			ShowMenu_MainMenu = false;
		}
	//	IPhost = GUI.TextField(new Rect(220, 10, 200, 20), IPhost);
		PortHost = int.Parse(GUI.TextField(new Rect(220, 10, 200, 20), PortHost.ToString()));
		Host_PlayerName = GUI.TextField(new Rect(220,30,200,20), Host_PlayerName);
		

		if (GUI.Button(new Rect(10, 90, 200, 70), "Connect to server")) 
		{
			try { Network.Connect(IPconnect, Portconnect); }
			catch { }
			ShowMenu_ConnectedLobby = true;
			ShowMenu_MainMenu = false;
		}
		IPconnect = GUI.TextField(new Rect(220, 90, 200, 20), IPconnect);
		Portconnect = int.Parse(GUI.TextField(new Rect(220, 110, 200, 20), Portconnect.ToString()));
		Connect_PlayerName = GUI.TextField(new Rect(220, 130, 200, 20), Connect_PlayerName);

		if (GUI.Button(new Rect(10, 170, 200, 70), "Options")) 
		{ 
			
		}

		if (GUI.Button(new Rect(10, 250,200,70), "Exit")) 
		{
			Application.Quit();
		}

	}

	void HostingLobbyGUI() 
	{
		if (GUI.Button(new Rect(10, 10, 200, 50), "Close lobby")) 
		{
			GamePlayers = new List<GamePlayer>();
			Network.Disconnect(200);
			ShowMenu_HostingLobby = false;
			ShowMenu_MainMenu = true;
		}

		if (GUI.Button(new Rect(400, 400, 100, 50), "Start game")) 
		{
			GetComponent<NetworkView>().RPC("Clients_LoadLevel", RPCMode.All);	
		}

		int VerticalCounter = 10;
		foreach (GamePlayer gp in GamePlayers) 
		{
			GUI.TextField(new Rect(220, VerticalCounter, 150, 20), gp._nickname );
			VerticalCounter = VerticalCounter + 20;
		}
	}

	void ConnectedLobbyGUI() 
	{
		if (GUI.Button(new Rect(10, 10, 200, 50), "Disconnect from lobby"))
		{
			GamePlayers = new List<GamePlayer>();
			Network.Disconnect(200);
			ShowMenu_ConnectedLobby = false;
			ShowMenu_MainMenu = true;
		}

		int VerticalCounter = 10;
		foreach (GamePlayer gp in GamePlayers)
		{
			GUI.TextField(new Rect(220, VerticalCounter, 150, 20), gp._nickname);
			VerticalCounter = VerticalCounter + 20;
		}
	}


	void OnGUI() 
	{
		if (ShowMenu_MainMenu) 
		{
			MainMenuGUI();
		}

		if (ShowMenu_HostingLobby) 
		{
			HostingLobbyGUI();
		}

		if (ShowMenu_ConnectedLobby) 
		{
			ConnectedLobbyGUI();
		}
	}

	/*
	void OnGUI() 
	{

		if (!HostingLobby)
		{
			GUILayout.BeginVertical("box");
			if (GUILayout.Button("ConnectButton"))
			{
				showconnectmenu = true;
			}
			GUILayout.EndVertical();


			if (showconnectmenu)
			{
				IPconnect = GUILayout.TextField(IPconnect);
				Portconnect = int.Parse(GUILayout.TextField(Portconnect.ToString()));
				if (GUILayout.Button("Connect"))
				{
					Network.Connect(IPconnect, Portconnect);

				}
				if (GUILayout.Button("Host Server"))
				{
					Network.InitializeServer(8, Portconnect, true);
					//HostingLobby = true;

				}
				if (GUILayout.Button("close"))
				{
					showconnectmenu = false;
					Network.Disconnect(200);
				}
			}

			if (Network.peerType == NetworkPeerType.Server)
			{
				GUILayout.Label("Server hosted: Clients connected =" + Network.connections.Length);
			}
			if (Network.peerType == NetworkPeerType.Client)
			{
				GUILayout.Label("You are connected to a server");
			}
		}
	}
	
	void OnPlayerConnected(NetworkPlayer player) 
	{
		Debug.Log("Someone has connected!" + player.ipAddress);
	} */


	static public List<GamePlayer> GamePlayers = new List<GamePlayer>();
	static public GamePlayer my_GamePlayer = null;

	[RPC]
	void Server_playerConnected(NetworkPlayer np, string Nickname) 
	{
		GetComponent<NetworkView>().RPC("Clients_playerConnected", RPCMode.AllBuffered, np, Nickname);
	}

	[RPC]
	void Clients_playerConnected(NetworkPlayer np, string Nickname) 
	{
		GamePlayer currentGP = new GamePlayer(np, Nickname);
		GamePlayers.Add(currentGP);
		if (np == Network.player) 
		{
			my_GamePlayer = currentGP;
		}
	}

	[RPC]
	void Server_playerDisconnected(NetworkPlayer np) 
	{
		GetComponent<NetworkView>().RPC("Clients_playerDisconnected", RPCMode.AllBuffered, np);
	}

	[RPC]
	void Clients_playerDisconnected(NetworkPlayer np) 
	{
		GamePlayer gp = null;
		foreach(GamePlayer gp1 in GamePlayers)
		{
			if (gp1._player == np) 
			{
				gp = gp1;
				break;
			}
		}
		GamePlayers.Remove(gp);
	}

	[RPC]
	void Clients_LoadLevel() 
	{
		Application.LoadLevel("HouseSelection");
	}

	void OnConnectedToServer() 
	{
		GetComponent<NetworkView>().RPC("Server_playerConnected", RPCMode.Server, Network.player, Connect_PlayerName);
	}

	void OnServerInitialized() 
	{
		GetComponent<NetworkView>().RPC("Clients_playerConnected", RPCMode.AllBuffered, Network.player, Host_PlayerName);
	}

	void OnDisconnectedFromServer(NetworkDisconnection info) 
	{
		GamePlayers = new List<GamePlayer>();
	}

	void OnPlayerDisconnected(NetworkPlayer player) 
	{
		GetComponent<NetworkView>().RPC("Clients_playerDisconnected", RPCMode.AllBuffered, player);
	}

	void OnFailedToConnect(NetworkConnectionError error) 
	{
		Debug.Log(error.GetType().ToString());
	}

}


