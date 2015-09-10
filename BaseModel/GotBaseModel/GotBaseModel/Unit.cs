using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotBaseModel
{
	public enum UnitType {Footman, Knight, SiegeTower, Ship }
    class Unit
    {
        private string _Name;
		private House _Owner;
		private UnitType _Type;
		
		//Lying down or?
		private bool _alive;

        public string Name { get { return _Name; } set { _Name = value; } }
		public House Owner { get { return _Owner; } set { _Owner = value; } }
		public UnitType Type { get { return _Type; } set { _Type = value; } }
		public bool Alive { get { return _alive; } set { _alive = value; } }

		public Unit(House owner, UnitType type, bool alive, string name)
		{
			Owner = owner;
			Type = type;
			Alive = alive;
            Name = name;
		}
    }
}
