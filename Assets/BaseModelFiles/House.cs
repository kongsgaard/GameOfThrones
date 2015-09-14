using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

	public enum HouseCharacter {Stark, Greyjoy, Lannister, Baratheon, Martell, Tyrell, Neutral};
    public class House
    {
        private HouseCharacter _Name;
        private List<Territory> _OwnedTerritories = new List<Territory>();
        private List<HouseCard> _HouseCardHand;
        private List<HouseCard> _HouseCardDiscardPile = new List<HouseCard>();
        private List<OrderToken> _UnusedOrderTokens = new List<OrderToken>();
        private List<Unit> _UnusedUnits = new List<Unit>();
		private GamePlayer _GamePlayer;

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
		public GamePlayer GamePlayer { get { return _GamePlayer; } set { _GamePlayer = value; } }

		public int KingsCourtStars { get { return _KingsCourtStars; } set { _KingsCourtStars = value; } }
		public int UnusedPowerTokens { get { return _UnusedPowerTokens; } set { _UnusedPowerTokens = value; } }
		public int PowerTokens { get { return _PowerTokens; } set { _PowerTokens = value; } }
		public int FoodTrack { get { return _FoodTrack; } set { _FoodTrack = value; } }
		public int VictoryTrack { get { return _VictoryTrackPosition; } set { _VictoryTrackPosition = value; } }


		public House(HouseCharacter name, List<Territory> Territories, List<HouseCard> HouseCards, int UnusedPowerToken, int PowerToken, GamePlayer gameplayer) 
		{
			HouseCharacter = name;
			OwnedTerritories = Territories;
			foreach (Territory T in OwnedTerritories) { T.Owner = this; }
			HouseCardHand = HouseCards;
			UnusedUnits = CreateUnits(this);
            UnusedOrderTokens = CreateOrderTokens(this);
			UnusedPowerTokens = UnusedPowerToken;
			PowerTokens = PowerToken;
			GamePlayer = gameplayer;

			foreach (Territory T in OwnedTerritories) 
			{
				T.Owner = this;
			}



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

        /* Used on gamelogic level
         * Place an order token on a territory from the players hand
         * */
		public void PlaceOrderTokenOnTerritory(Territory T, OrderToken ot) 
		{
			T.PlaceOrderToken(ot);
			PlaceOrderToken(ot);
		}

        /* Used on gamelogic level
         * Return an order token from a territory to the players hand
         * */
		public void ReturnOrderTokenFromTerritory(Territory T, OrderToken ot) 
		{
			T.RemoveOrderToken(ot);
            ReturnOrderToken(ot);
		}

        /* Not used on gamelogic level
         * 
         * --Missing--
         * Notify player hand class when this happens.
         * */
        public void ReturnOrderToken(OrderToken ot) 
        {
            UnusedOrderTokens.Add(ot);
        }

        /* Not used on gamelogic level
         * 
         * --Missing--
         * Notify player hand class when this happens.
         * */
        public void PlaceOrderToken(OrderToken ot) 
        {
            UnusedOrderTokens.Remove(ot);
        }

        /* Not used on gamelogic level.
         * Used to inform UI of changes
         * 
         * --Missing--
         *  Needs to setup observer pattern of player hand
         * */
        public void PlaceUnit(Unit U) 
        { 
            UnusedUnits.Remove(U); 
        }

        /* Not used on Gamelogic level.
         * Used to inform UI of changes
         * 
         * --Missing--
         *  Needs to setup observer pattern of player hand
         * */
        public void ReturnUnit(Unit U) 
        { 
            UnusedUnits.Add(U); 
        }

        /* Used on gamelogic level
         * If a power token should be added to the unused pile, but not removed from the player power token pile
         * 
         * --Missing--
         * Setup and notify player hand class that power token is placed in the unused pile
         * */
        public void AddPowerTokenToUnusedPile() 
        {
            UnusedPowerTokens = UnusedPowerTokens + 1;
        }

        /* Not used on Gamelogic level.
         * Used to inform UI of changes
         * 
         * --Missing--
         *  Setup and notify player hand class that power token is gained + one removed from unused.
         * */
        public void GainOnePowerToken() 
        {
            PowerTokens = PowerTokens + 1;
            UnusedPowerTokens = UnusedPowerTokens - 1;
        }

        /* Not used on Gamelogic level.
         * When power token is removed from the hand, and put into the unused power token pile.
         * 
         * --Missing--
         * Setup and notify player hand class that power token is removed + one added to unused.
         * */
        public void LoseOnePowerToken_ToUnused() 
        {
            PowerTokens = PowerTokens - 1;
            UnusedPowerTokens = UnusedPowerTokens + 1;
        }

        /* Not used on GameLogic level
         * When power token is removed from the hand, but not put into the unused power pile. (When placed on territory)
         * 
         * --Missing--
         * Setup and notify player hand class that power token is removed.
         * */
        public void LoseOnePowerToken_ToTerritory()
        {
            PowerTokens = PowerTokens - 1;
        }

        /* Used on gamelogic level
         * Use this function to place a unit on on a territory
         */ 
		public void PlaceUnitOnTerritory(Territory T, Unit U) 
		{
			UnusedUnits.Remove(U);
			T.AddUnitToList(U);
		}

        /* Used on gamelogic level
         * Use this function to remove a unit from a territory
         */ 
		public void ReturnUnitFromTerritory(Territory T, Unit U) 
		{
			UnusedUnits.Add(U);
			T.RemoveUnitFromList(U);
		}

        /* Used on gamelogic level
         * Use this function to place a power token on a territory
         * 
         * UI info
         * --Missing--
         * Setup observer pattern/call with the player hand class
         */ 
		public void PlacePowerTokenOnTerritory(Territory T) 
		{
			T.ContainsPowerToken = true;
            LoseOnePowerToken_ToTerritory();
		}

        /* Used on gamelogic level
         * Use this function to remove a power token from a territory
         */ 
		public void RemovePowerTokenFromTerritory(Territory T) 
		{
			T.ContainsPowerToken = false;
			UnusedPowerTokens = UnusedPowerTokens + 1;
		}

        /* Not used on gamelogic level
         * Request a unit from the player hand. If null is returned, no unit of that type is left.
         * */
        public Unit ReturnSomeUnitGivenType(UnitType type) 
        {
            Unit u = null;

            if (type == UnitType.Footman) 
            {
                foreach (Unit U in UnusedUnits)
                {
                    if (U.Type == UnitType.Footman)
                    {
                        u = U;
                        break;
                    }
                }
                return u;
            }
            else if (type == UnitType.Knight) 
            {
                foreach (Unit U in UnusedUnits)
                {
                    if (U.Type == UnitType.Knight)
                    {
                        u = U;
                        break;
                    }
                }
                return u;
            }
            else if (type == UnitType.Ship) 
            {
                foreach (Unit U in UnusedUnits)
                {
                    if (U.Type == UnitType.Ship)
                    {
                        u = U;
                        break;
                    }
                }
                return u;
                
            }
            else if (type == UnitType.SiegeTower) 
            {
                foreach (Unit U in UnusedUnits)
                {
                    if (U.Type == UnitType.SiegeTower)
                    {
                        u = U;
                        break;
                    }
                }
                return u;
            }
            return u;
        }

        /* Used on gamelogic level
         * Collect power tokens from a territory, not based on a consolidate token
         */
		public void CollectPowerFromTerritory(Territory T) 
		{
            int PowerTokensToGain = T.PowerIcons;

            for (int n = 0; n < PowerTokensToGain; n++)
            {
                GainOnePowerToken();
            }
		}

        /* Used on gamelogic level
         * Collect power tokens from a territory, using a consolidate token placed.
         * */
		public void CollectPowerFromTerritoryWithConsolidateToken(Territory T) 
		{
            int PowerTokensToGain = T.PowerIcons + 1;

            for (int n = 0; n < PowerTokensToGain; n++) 
            {
                GainOnePowerToken();
            }
		}

        /* Used on gamelogic level
         * Remove power tokens from a players hand, and add them to the unused power token pile.
         * */
		public void RemovePowerTokens(int i) 
		{
			if (i < PowerTokens)
			{
                for (int n = 0; n < i; n++)
                {
                    LoseOnePowerToken_ToUnused();
                }
			}
			else 
			{
                while (PowerTokens > 0) 
                {
                    LoseOnePowerToken_ToUnused();
                }
			}
		}

        /* Used on gamelogic level
         * Add powertokens to the players hand, and remove them from the unused power token pule.
         * */
		public void GainPowerTokens(int i) 
		{
			if (i < UnusedPowerTokens)
			{
                for (int n = 0; n < i; n++) 
                {
                    GainOnePowerToken();
                }
			}
			else
			{
                for (int n = 0; n < UnusedPowerTokens; n++) 
                {
                    GainOnePowerToken();
                }
			}
		}

        /* Used on gamelogic level
         * Upgrade a unit on a given territory. */
		public void UpgradeUnitOnTerritory(Unit Previous, Unit Upgraded, Territory T) 
		{
			T.RemoveUnitFromList(Previous);
			UnusedUnits.Add(Previous);

			T.AddUnitToList(Upgraded);
			UnusedUnits.Remove(Upgraded);
		}

        /* Create units when the game is initiated. */
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
                string FootmanName = "SiegeTower_" + i.ToString() + "_" + h.HouseCharacter.ToString();
                Unit u = new Unit(h, UnitType.SiegeTower, true, FootmanName);
                units.Add(u);
            }

            for (int i = 0; i < 6; i++)
            {
                string FootmanName = "Ship_" + i.ToString() + "_" + h.HouseCharacter.ToString();
                Unit u = new Unit(h, UnitType.Ship, true, FootmanName);
                units.Add(u);
            }

            return units;
        }

        /* Create order tokens when the game is initiated. */
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

