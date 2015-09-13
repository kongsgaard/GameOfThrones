using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class TerritorySubject 
{
	TerritoryBehaviorObserver myObserver;
	public void DefineObserver(TerritoryBehaviorObserver obs) 
	{
		myObserver = obs;
	}

	public void NotifyUnitChange() 
	{
		if (myObserver != null)
		{
			myObserver.UpdateUnits();
		}
	}
	public void NotifyPowerTokenChange() 
	{
		if (myObserver != null)
		{
			myObserver.UpdatePowerToken();
		}
	}

	public void NotifyOrderTokenChanged() 
	{
		if (myObserver != null) 
		{
			myObserver.UpdateOrderToken();
		}
	}

	public void InitialObserverCall()
	{
		NotifyOrderTokenChanged();
		NotifyUnitChange();
		NotifyPowerTokenChange();
	}
}

	public enum TerritoryType { LandArea, HarborArea, SeaArea }
    public class Territory : TerritorySubject
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
		public OrderToken PlacedOrderToken { get { return _PlacedOrderToken; } private set { _PlacedOrderToken = value; } }
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

        /* Gamelogic info
         * This function shouldn't be called directly. To place a unit on a territory, call the PlaceUnitOnTerritory function in the house class instead. */
        public void AddUnitToList(Unit U) 
		{
			Units.Add(U);
			NotifyUnitChange();
		}

        /* Gamelogic info
         * This function shouldn't be called directly. To place a unit on a territory, call the ReturnUnitFromTerritory function in the house class instead. */
		public void RemoveUnitFromList(Unit U) 
		{
			Units.Remove(U);
			NotifyUnitChange();
		}

        /* Gamelogic info
         * This function shouldn't be called directly. To place an order token on a territory, call the PlaceOrderTokenOnTerritory function in the house class instead. */
		public void PlaceOrderToken(OrderToken ot) 
		{
			PlacedOrderToken = ot;
			NotifyOrderTokenChanged();
		}

        /* Gamelogic info
         * This function shouldn't be called directly. To remove an order token on a territory, call the ReturnOrderTokenFromTerritory function in the house class instead. */
		public void RemoveOrderToken(OrderToken ot) 
		{
			PlacedOrderToken = null;
			NotifyOrderTokenChanged();
		}
    }

