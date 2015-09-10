using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotBaseModel
{
	public enum HouseCharacter {Stark, Greyjoy, Lannister, Baratheon, Martell, Tyrell, Neutral};
    class House
    {
        private HouseCharacter _Name;
        private List<Territory> _OwnedTerritories = new List<Territory>();
        private List<HouseCard> _HouseCardHand;
        private List<HouseCard> _HouseCardDiscardPile = new List<HouseCard>();
        private List<OrderToken> _UnusedOrderTokens = new List<OrderToken>();
        private List<Unit> _UnusedUnits = new List<Unit>();

        private int _IronThroneTrackPosition;
        private int _FeifdomTrackPosition;
        private int _KingsCourtTrackPosition;
		private int _KingsCourtStars;
        private int _UnusedPowerTokens;
        private int _PowerTokens;
		private int _FoodTrack;
		private int _VictoryTrackPosition;

		public HouseCharacter HouseCharacter { get { return _Name; } set { _Name = value; } }
		public List<Territory> OwnedTerritories { get { return _OwnedTerritories; } set { _OwnedTerritories = value; } }
		public List<HouseCard> HouseCardHand { get { return _HouseCardHand; } set { _HouseCardHand = value; } }
		public List<HouseCard> HouseCardDiscardPile { get { return _HouseCardDiscardPile; } set { _HouseCardDiscardPile = value; } }
		public List<OrderToken> UnusedOrderTokens { get { return _UnusedOrderTokens; } set { _UnusedOrderTokens = value; } }
		public List<Unit> UnusedUnits { get { return _UnusedUnits; } set { _UnusedUnits = value; } }

		public int IronThroneTrackPosition { get { return _IronThroneTrackPosition; } set { _IronThroneTrackPosition = value; } }
		public int FeifdomTrackPosition { get { return _FeifdomTrackPosition; } set { _FeifdomTrackPosition = value; } }
		public int KingsCourtTrackPosition { get { return _KingsCourtTrackPosition; } set { _KingsCourtTrackPosition = value; } }
		public int KingsCourtStars { get { return _KingsCourtStars; } set { _KingsCourtStars = value; } }
		public int UnusedPowerTokens { get { return _UnusedPowerTokens; } set { _UnusedPowerTokens = value; } }
		public int PowerTokens { get { return _PowerTokens; } set { _PowerTokens = value; } }
		public int FoodTrack { get { return _FoodTrack; } set { _FoodTrack = value; } }
		public int VictoryTrack { get { return _VictoryTrackPosition; } set { _VictoryTrackPosition = value; } }


		public House(HouseCharacter name, List<Territory> Territories, List<HouseCard> HouseCards, int IronThronePos, 
					 int FeifdomPos, int KingsCourtPos, int UnusedPowerToken, int PowerToken) 
		{
			HouseCharacter = name;
			OwnedTerritories = Territories;
			HouseCardHand = HouseCards;
			UnusedUnits = CreateUnits(this);
            UnusedOrderTokens = CreateOrderTokens(this);
			IronThroneTrackPosition = IronThronePos;
			FeifdomTrackPosition = FeifdomPos;
			KingsCourtTrackPosition = KingsCourtPos;
			UnusedPowerTokens = UnusedPowerToken;
			PowerTokens = PowerToken;
		}

		public void AddTerritory(Territory T) { _OwnedTerritories.Add(T); } 
		public void RemoveTerritory(Territory T) { _OwnedTerritories.Remove(T); }

		public void HouseCardHandToDiscardPile(HouseCard H) 
		{
			_HouseCardHand.Remove(H);
			_HouseCardDiscardPile.Add(H);
		}

		public void HouseCardDiscardPileToHand(HouseCard H) 
		{
			_HouseCardDiscardPile.Remove(H);
			_HouseCardHand.Add(H);
		}

		public void UseOrderToken(OrderToken O) { UnusedOrderTokens.Remove(O); }
		public void ReturnOrderToken(OrderToken O) { UnusedOrderTokens.Add(O); }
		public void PlaceUnit(Unit U) { UnusedUnits.Remove(U); }
		public void ReturnUnit(Unit U) { UnusedUnits.Add(U); }


        private static List<Unit> CreateUnits(House h)
        {
            List<Unit> units = new List<Unit>();

            for (int i = 0; i < 5; i++)
            {
                string KnightName = "Knight_" + i.ToString() + "_" + h.HouseCharacter.ToString();
                Unit u = new Unit(h, UnitType.Knight, true, KnightName);
                units.Add(u);
            }

            for (int i = 0; i < 10; i++)
            {
                string FootmanName = "Footman_" + i.ToString() + "_" + h.HouseCharacter.ToString();
                Unit u = new Unit(h, UnitType.Footman, true, FootmanName);
                units.Add(u);
            }

            for (int i = 0; i < 3; i++)
            {
                string FootmanName = "Footman_" + i.ToString() + "_" + h.HouseCharacter.ToString();
                Unit u = new Unit(h, UnitType.SiegeTower, true, FootmanName);
                units.Add(u);
            }

            for (int i = 0; i < 6; i++)
            {
                string FootmanName = "Footman_" + i.ToString() + "_" + h.HouseCharacter.ToString();
                Unit u = new Unit(h, UnitType.Ship, true, FootmanName);
                units.Add(u);
            }

            return units;
        }
        private static List<OrderToken> CreateOrderTokens(House h)
        {

            List<OrderToken> Tokens = new List<OrderToken>();

            //MoveOrders
            OrderToken Token_A_Star = new OrderToken(h, OrderTokenType.MoveOrder, OrderTokenStrenght.Star);
            Tokens.Add(Token_A_Star);

            OrderToken Token_A_Norm = new OrderToken(h, OrderTokenType.MoveOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_A_Norm);

            OrderToken Token_A_Minus = new OrderToken(h, OrderTokenType.MoveOrder, OrderTokenStrenght.MinusOne);
            Tokens.Add(Token_A_Minus);


            //SupportOrders
            OrderToken Token_S_Star = new OrderToken(h, OrderTokenType.SupportOrder, OrderTokenStrenght.Star);
            Tokens.Add(Token_S_Star);

            OrderToken Token_S_Norm1 = new OrderToken(h, OrderTokenType.SupportOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_S_Norm1);

            OrderToken Token_S_Norm2 = new OrderToken(h, OrderTokenType.SupportOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_S_Norm2);


            //DefenseOrders
            OrderToken Token_D_Star = new OrderToken(h, OrderTokenType.DefendOrder, OrderTokenStrenght.Star);
            Tokens.Add(Token_D_Star);

            OrderToken Token_D_Norm1 = new OrderToken(h, OrderTokenType.DefendOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_D_Norm1);

            OrderToken Token_D_Norm2 = new OrderToken(h, OrderTokenType.DefendOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_D_Norm2);


            //RaidOrders
            OrderToken Token_R_Star = new OrderToken(h, OrderTokenType.RaidOrder, OrderTokenStrenght.Star);
            Tokens.Add(Token_R_Star);

            OrderToken Token_R_Norm1 = new OrderToken(h, OrderTokenType.RaidOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_R_Norm1);

            OrderToken Token_R_Norm2 = new OrderToken(h, OrderTokenType.RaidOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_R_Norm2);


            //ConsolidatePower
            OrderToken Token_C_Star = new OrderToken(h, OrderTokenType.ConsolidatePowerOrder, OrderTokenStrenght.Star);
            Tokens.Add(Token_C_Star);

            OrderToken Token_C_Norm1 = new OrderToken(h, OrderTokenType.ConsolidatePowerOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_C_Norm1);

            OrderToken Token_C_Norm2 = new OrderToken(h, OrderTokenType.ConsolidatePowerOrder, OrderTokenStrenght.Normal);
            Tokens.Add(Token_C_Norm2);

            return Tokens;
        }

    }
}
