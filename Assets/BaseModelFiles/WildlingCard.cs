using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class WildlingCard
    {
		private string _Name;
		public Action<House> Lose_LowestBidder;
		public Action<List<House>> Lose_All;
		public Action<House> Win_HighestBidder;

		public string Name { get { return _Name; } set { _Name = value; } }

		public WildlingCard(string name,Action<House> lowest, Action<List<House>> lose_all, Action<House> highestbidder) 
		{
			Name = name;
			Lose_LowestBidder = lowest;
			Lose_All = lose_all;
			Win_HighestBidder = highestbidder;
		}


    }
