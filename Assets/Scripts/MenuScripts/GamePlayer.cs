using UnityEngine;
using System.Collections;

    public enum playerType {player, AI};

	[System.Serializable]
	public class GamePlayer
	{
		public NetworkPlayer _player;
        public playerType _playerType;
		public string _nickname;
        

		public GamePlayer(string nick, playerType type)
		{
			_nickname = nick;
            _playerType = type;
		}

	}

    
