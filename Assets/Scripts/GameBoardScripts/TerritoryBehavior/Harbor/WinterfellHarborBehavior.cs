using UnityEngine;
using System.Collections;

public class WinterfellHarborBehavior : GeneralTerritoryBehavior
{

    // Use this for initialization
    void Start()
    {

        Unit3Pos = new Vector3((float)4.85, (float)0.01, (float)-5.75);
        Unit0Pos = new Vector3((float)5.05, (float)0.02, (float)-5.65);
        Unit1Pos = new Vector3((float)5.25, (float)0.03, (float)-5.55);
        Unit2Pos = new Vector3((float)5.45, (float)0.04, (float)-5.45);

        OrderTokenPos = new Vector3((float)5.06, (float)0.06, (float)-5.4);

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
            if (T.Name == "WinterfellHarbor")
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
