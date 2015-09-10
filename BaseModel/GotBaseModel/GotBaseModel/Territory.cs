using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotBaseModel
{
	public enum TerritoryType { LandArea, HarborArea, SeaArea }
    class Territory
    {
        private string _Name;
        private List<Unit> _Units = new List<Unit>();
        private List<Territory> _AdjacentTerritories = new List<Territory>();
        private House _Owner;
        private OrderToken _PlacedOrderToken = null;
		private TerritoryType _Type;

        private bool _ContainsCastle;
        private bool _ContainsStronghold;
        private bool _ContainsPowerToken = false;
        private int _PowerIcons;
        private int _Barrels;

		public string Name { get { return _Name; } set { _Name = value; } }
		public List<Unit> Units { get { return _Units; } set { _Units = value; } }
		public List<Territory> AdjecantTerritories { get { return _AdjacentTerritories; } set { _AdjacentTerritories = value; } }
		public House Owner { get { return _Owner; } set { _Owner = value; } }
		public OrderToken PlacedOrderToken { get { return _PlacedOrderToken; } set { _PlacedOrderToken = value; } }
		public TerritoryType Type { get { return _Type; } set { _Type = value; } }

		public bool ContainsCastle { get { return _ContainsCastle; } set { _ContainsCastle = value; } }
		public bool ContainsStronghold { get { return _ContainsStronghold; } set { _ContainsStronghold = value; } }
		public bool ContainsPowerToken { get { return _ContainsPowerToken; } set { _ContainsPowerToken = value; } }
		public int PowerIcons { get { return _PowerIcons; } set { _PowerIcons = value; } }
		public int Barrels { get { return _Barrels; } set { _Barrels = value; } }

		public Territory(string name, House owner,TerritoryType type, bool containscastle, bool containsstronghold, int powericons, int barrels) 
		{
			Name = name;
			Owner = owner;
			Type = type;
			ContainsCastle = containscastle;
			ContainsStronghold = containsstronghold;
			PowerIcons = powericons;
			Barrels = barrels;
		}
        




    }
}
