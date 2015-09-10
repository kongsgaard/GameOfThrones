using UnityEngine;
using System.Collections;

public class BlackwaterBehavior : GeneralTerritoryBehavior
{
    // Use this for initialization
    void Start()
    {
        Unit0Pos = new Vector3((float)2.66, (float)0.02, (float)6.46);
        Unit1Pos = new Vector3((float)2.24, (float)0.03, (float)6.46);
        Unit2Pos = new Vector3((float)2.48, (float)0.04, (float)6);
        Unit3Pos = new Vector3((float)2.03, (float)0.01, (float)6);

        OrderTokenPos = new Vector3((float)-0.76, (float)0.06, (float)6.06);

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
            if (T.Name == "Blackwater")
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
