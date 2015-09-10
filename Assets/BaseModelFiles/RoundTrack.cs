using UnityEngine;
using System.Collections;

public abstract class RoundTrackSubject 
{
	protected RoundTrackBehaviorObserver myObserver;

	public void DefineObserver(RoundTrackBehaviorObserver obs) 
	{
		myObserver = obs;
	}

	protected void RoundTrackValueChanged() 
	{
		if (myObserver != null) 
		{
			myObserver.RoundTrackChanged();
		}
	}

	public void InitialObserverCall() 
	{
		RoundTrackValueChanged();
	}
}

public class RoundTrack : RoundTrackSubject
{
	private int RoundNumber;
	
	private bool _InitialRound = true;

	public bool InitialRound 
	{
		get { return _InitialRound; }
		private set { _InitialRound = value; }
	}


	public RoundTrack(int StartRound) 
	{
		RoundNumber = StartRound;
	}

	public void NextRound() 
	{
		RoundNumber = RoundNumber + 1;
		InitialRound = false;
		RoundTrackValueChanged();
	}

	public int CurrentRound() 
	{
		return RoundNumber;
	}
}
