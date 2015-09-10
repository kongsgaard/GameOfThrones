using UnityEngine;
using System.Collections;

public class InfluenceTrackSubject 
{
	private InfluenceTrackBehaviorObserver myObserver;
	public void DefineObserver(InfluenceTrackBehaviorObserver obs) 
	{
		myObserver = obs;
	}

	protected void TrackValuechanged() 
	{
		if (myObserver != null) 
		{
			myObserver.NotifyValueChanged();
		}
	}

	public void InitialObserverCall() 
	{
		TrackValuechanged();
	}

}

public class InfluenceTrack : InfluenceTrackSubject
{
	private House[] TrackEnteries;

	public InfluenceTrack(int Lenght) 
	{
		TrackEnteries = new House[Lenght];
	}

	public int ReturnTrackLenght() 
	{
		return TrackEnteries.Length;
	}

	public void InsertHouseAtPosition(int i, House h) 
	{
		TrackEnteries[i-1] = h;
		TrackValuechanged();
	}

	public House ReturnHouseAtPosition(int i) 
	{
		return TrackEnteries[i-1];
	}
}


