using System;
using System.Collections;
using System.Collections.Generic;

public class BannedOrders
{
	public List<OrderTokenType> BannedList = new List<OrderTokenType>();

	public BannedOrders()
	{
	}

	public void AddBannedOrderTokenType(OrderTokenType t) 
	{
		BannedList.Add(t);
	}

	public void ResetBannedOrders() 
	{
		BannedList = new List<OrderTokenType>();
	}
}
