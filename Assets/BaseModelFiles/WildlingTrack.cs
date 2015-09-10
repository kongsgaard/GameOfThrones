using UnityEngine;
using System.Collections;

public abstract class WildlingTrackSubject 
{
    protected WildlingTrackBehaviorObserver myObserver;

    public void DefineObserver(WildlingTrackBehaviorObserver obs) 
    {
        myObserver = obs;
    }

    public abstract void NotifyValueChange();

    public void InitialObserverCall()
    {
        NotifyValueChange();
    }
}

public class WildlingTrack : WildlingTrackSubject {

    private int _WildlingTrackValue;

    public int WildlingTrackValue 
    {
        get { return _WildlingTrackValue; }
        private set 
		{ 
			_WildlingTrackValue = value;
			NotifyValueChange();
		}
    }

    public WildlingTrack(int StartValue) 
    {
        WildlingTrackValue = StartValue;
    }

    public int Value()
    {
        return WildlingTrackValue;
    }

    public void ValuePlusTwo() 
    {
        WildlingTrackValue = WildlingTrackValue + 2;
    }

    public override void NotifyValueChange()
    {
        if (myObserver != null)
        {
            myObserver.WildlingTrackValueChanged(_WildlingTrackValue);
        }
    }

}
