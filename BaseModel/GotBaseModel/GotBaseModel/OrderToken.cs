using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotBaseModel
{
	public enum OrderTokenType { MoveOrder, DefendOrder, SupportOrder, RaidOrder, ConsolidatePowerOrder  }
    public enum OrderTokenStrenght { Star, Normal, MinusOne }
    class OrderToken
    {
		private House _Owner;
		private OrderTokenType _Type;
		private OrderTokenStrenght _Strenght;
		public House Owner { get { return _Owner; } set { _Owner = value; } }
		public OrderTokenType Type { get { return _Type; } set { _Type = value; } }
        public OrderTokenStrenght Strenght { get { return _Strenght; } set { _Strenght = value; } }

		public OrderToken(House owner, OrderTokenType type, OrderTokenStrenght strenght) 
		{
			Owner = owner;
			Type = type;
            Strenght = strenght;
		}
    }
}
