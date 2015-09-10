using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TrackToken
{
	private House _House;
	private int _Position;

	public int Position 
	{
		get { return _Position; }
		set { _Position = value; }
	}

	public House House
	{
		get { return _House; }
		set { _House = value; }
	}

	public TrackToken(House h, int p) 
	{
		Position = p;
		House = h;
	}
}

