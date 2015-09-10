
using UnityEngine;
using System.Collections;

public class KingsLandingBehavior : GeneralTerritoryBehavior
{
    // Use this for initialization
    void Start()
    {
        Unit0Pos = new Vector3((float)0.65, (float)0.02, (float)6.78);
        Unit1Pos = new Vector3((float)1, (float)0.03, (float)6.78);
        Unit2Pos = new Vector3((float)1, (float)0.04, (float)6.36);
        Unit3Pos = new Vector3((float)0, (float)0.01, (float)7.21);

        OrderTokenPos = new Vector3((float)0.63, (float)0.06, (float)6.36);

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
            if (T.Name == "KingsLanding")
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
