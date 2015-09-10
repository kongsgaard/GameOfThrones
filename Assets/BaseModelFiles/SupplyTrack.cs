using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class SupplyTrackSubject 
{
    protected SupplyTrackBehaviorObserver myObserver;

    public void DefineObserver(SupplyTrackBehaviorObserver obs) 
    {
        myObserver = obs;
    }

    public void SupplyValueChanged() 
    {
        if (myObserver != null)
        {
            myObserver.NotifySupplyChanged();
        }
    }

    public void InitialObserverCall() 
    {
        SupplyValueChanged();
    }

}

public class SupplyTrack : SupplyTrackSubject
{
    private List<House> Position0 = new List<House>();
    private List<House> Position1 = new List<House>();
    private List<House> Position2 = new List<House>();
    private List<House> Position3 = new List<House>();
    private List<House> Position4 = new List<House>();
    private List<House> Position5 = new List<House>();
    private List<House> Position6 = new List<House>();
    public List<House>[] AllSupplyTracks = new List<House>[7];

	public void SetSupplyForAllBasedOnTerritory() 
    {
        foreach (House h in GameBase.HouseList)
        {
            RemoveHouseFromPosition(h);

            int supply = CountSupplyForHouseTerritory(h);

            if (supply == 0) { InsertHouseAtPosition(h, supply); }
            else if (supply == 1) { InsertHouseAtPosition(h, supply); }
            else if (supply == 2) { InsertHouseAtPosition(h, supply); }
            else if (supply == 3) { InsertHouseAtPosition(h, supply); }
            else if (supply == 4) { InsertHouseAtPosition(h, supply); }
            else if (supply == 5) { InsertHouseAtPosition(h, supply); }
            else if (supply == 6) { InsertHouseAtPosition(h, supply); }
        }
        SupplyValueChanged();
    }

	public void SetSupplyForHouse(House h, int i) 
    {
        RemoveHouseFromPosition(h);
        InsertHouseAtPosition(h, i);
        SupplyValueChanged();
    }

	public void SetSupplyReduceHouseByOne(House h) 
    {
        int previousPosition = CurrentSupplyForHouse(h);
        RemoveHouseFromPosition(h);
        SetSupplyForHouse(h, previousPosition - 1);
        SupplyValueChanged();
    }

    public void SetSupplyIncreaseHouseByOne(House h, int i) 
    {
        int previousPosition = CurrentSupplyForHouse(h);
        RemoveHouseFromPosition(h);
        SetSupplyForHouse(h, previousPosition + 1);
        SupplyValueChanged();
    }

    public int CountSupplyForHouseTerritory(House h) 
    {
        int supply = 0;
        foreach (Territory T in h.OwnedTerritories) 
        {
            supply = supply + T.Barrels;
        }

        return supply;
    }

    public int CurrentSupplyForHouse(House h1) 
    {
        foreach (House h in Position0)
        {
            if (h.HouseCharacter == h1.HouseCharacter)
            {
                Position0.Remove(h);
                return 0;
            }
        }
        foreach (House h in Position1)
        {
            if (h.HouseCharacter == h1.HouseCharacter)
            {
                Position1.Remove(h);
                return 1;
            } 
        }
        foreach (House h in Position2)
        {
            if (h.HouseCharacter == h1.HouseCharacter)
            {
                Position2.Remove(h);
                return 2;
            }
        }
        foreach (House h in Position3)
        {
            if (h.HouseCharacter == h1.HouseCharacter)
            {
                Position3.Remove(h);
                return 3;
            }
        }
        foreach (House h in Position4)
        {
            if (h.HouseCharacter == h1.HouseCharacter)
            {
                Position4.Remove(h);
                return 4;
            }
        }
        foreach (House h in Position5)
        {
            if (h.HouseCharacter == h1.HouseCharacter)
            {
                Position5.Remove(h);
                return 5;
            }
        }
        foreach (House h in Position6)
        {
            if (h.HouseCharacter == h1.HouseCharacter)
            {
                Position6.Remove(h);
                return 6;
            }
        }
        return 0;
    }


    private void RemoveHouseFromPosition(House targetRemove) 
    {
        foreach (House h in Position0) 
        {
            if (h.HouseCharacter == targetRemove.HouseCharacter) 
            {
                Position0.Remove(h);
                return;
            }
        }
        foreach (House h in Position1)
        {
            if (h.HouseCharacter == targetRemove.HouseCharacter)
            {
                Position1.Remove(h);
                return;
            }
        }
        foreach (House h in Position2)
        {
            if (h.HouseCharacter == targetRemove.HouseCharacter)
            {
                Position2.Remove(h);
                return;
            }
        }
        foreach (House h in Position3)
        {
            if (h.HouseCharacter == targetRemove.HouseCharacter)
            {
                Position3.Remove(h);
                return;
            }
        }
        foreach (House h in Position4)
        {
            if (h.HouseCharacter == targetRemove.HouseCharacter)
            {
                Position4.Remove(h);
                return;
            }
        }
        foreach (House h in Position5)
        {
            if (h.HouseCharacter == targetRemove.HouseCharacter)
            {
                Position5.Remove(h);
                return;
            }
        }
        foreach (House h in Position6)
        {
            if (h.HouseCharacter == targetRemove.HouseCharacter)
            {
                Position6.Remove(h);
                return;
            }
        }
    }
    private void InsertHouseAtPosition(House h, int i)
    {
        if (i == 0) { Position0.Add(h); }
        else if (i == 1) { Position1.Add(h); }
        else if (i == 2) { Position2.Add(h); }
        else if (i == 3) { Position3.Add(h); }
        else if (i == 4) { Position4.Add(h); }
        else if (i == 5) { Position5.Add(h); }
        else if (i == 6) { Position6.Add(h); }
    }

    public SupplyTrack() 
    {
        AllSupplyTracks[0] = Position0; AllSupplyTracks[1] = Position1; AllSupplyTracks[2] = Position2; AllSupplyTracks[3] = Position3;
        AllSupplyTracks[4] = Position4; AllSupplyTracks[5] = Position5; AllSupplyTracks[6] = Position6;
    }

}
