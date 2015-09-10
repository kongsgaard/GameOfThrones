using UnityEngine;
using System.Collections;

	[System.Serializable]
	public class GamePlayer
	{
		public NetworkPlayer _player;
		public string _nickname;

		public GamePlayer(NetworkPlayer player, string nick)
		{
			_player = player;
			_nickname = nick;
		}

	}
