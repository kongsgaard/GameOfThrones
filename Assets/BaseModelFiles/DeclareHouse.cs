using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class DeclareHouseStark
    {

		//These functions should probably be called in the constructor for a house instead.
        public static House CreateHouse(HouseCharacter hc) 
        {

            return null;
        }

        public static List<Unit> CreateUnits(House h) 
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
        public static List<OrderToken> CreateOrderTokens(House h) 
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

