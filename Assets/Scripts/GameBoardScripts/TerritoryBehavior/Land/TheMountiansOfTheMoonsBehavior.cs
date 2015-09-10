using UnityEngine;
using System.Collections;

public class TheMountiansOfTheMoonsBehavior : GeneralTerritoryBehavior
{
    // Use this for initialization
    void Start()
    {
        Unit0Pos = new Vector3((float)-0.72, (float)0.02, (float)2.22);
        Unit1Pos = new Vector3((float)-1.16, (float)0.03, (float)2.22);
        Unit2Pos = new Vector3((float)-1, (float)0.04, (float)1.77);
        Unit3Pos = new Vector3((float)-1.41, (float)0.01, (float)1.77);

        OrderTokenPos = new Vector3((float)-0.19, (float)0.06, (float)2.35);

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
            if (T.Name == "TheMountiansOfTheMoon")
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
