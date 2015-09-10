using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class HouseCard
    {
		private string _Name;
		private int _CombatStrenght;
		private int _SwordIcons;
		private int _FortificationIcons;
		private House _Owner;

		public Func<string, int> first;
		public Func<string, int> second;

		public string Name { get { return _Name; } set { _Name = value; } }
		public int CombatStrenght { get { return _CombatStrenght; } set { _CombatStrenght = value; } }
		public int SwordIcons { get { return _SwordIcons; } set { _SwordIcons = value; } }
		public int FortificationIcons { get { return _FortificationIcons; } set { _FortificationIcons = value; } }
        public House Owner { get { return _Owner; } set { _Owner = value; } }

		public HouseCard(string name, int combatstrenght, int swords, int fortifications, House owner) 
		{ 
			
		}

		public HouseCard(Func<string, int> one, Func<string, int> two) 
		{
			first = one;
			second = two;
		}

		public void Immediatly() 
		{
			first(_Name);
		}

		public void EndOfCombat() 
		{
			second(_Name);
		}


    }

