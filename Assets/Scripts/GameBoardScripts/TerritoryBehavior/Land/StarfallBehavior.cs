using UnityEngine;
using System.Collections;

public class StarfallBehavior : GeneralTerritoryBehavior
{
    // Use this for initialization
    void Start()
    {
        Unit0Pos = new Vector3((float)3.78, (float)0.02, (float)12.94);
        Unit1Pos = new Vector3((float)3.42, (float)0.03, (float)12.94);
        Unit2Pos = new Vector3((float)3.06, (float)0.04, (float)12.94);
        Unit3Pos = new Vector3((float)4.12, (float)0.01, (float)12.94);

        OrderTokenPos = new Vector3((float)3.22, (float)0.06, (float)13.37);

        UnitPositions[0] = Unit0Pos;
        UnitPositions[1] = Unit1Pos;
        UnitPositions[2] = Unit2Pos;
        UnitPositions[3] = Unit3Pos;

        RenderedUnits[0] = Unit0;
        RenderedUnits[1] = Unit1;
        RenderedUnits[2] = Unit2;
        RenderedUnits[3] = Unit3;

        foreach (Territory T in GameBase.TerritoryList)
        {
            if (T.Name == "Starfall")
            {
                myTerritory = T;
                mySubject = T;
                mySubject.DefineObserver(this);
                break;
            }
        }

        //Call the update on power token and units, to render them properly
        mySubject.InitialObserverCall();
    }
}
