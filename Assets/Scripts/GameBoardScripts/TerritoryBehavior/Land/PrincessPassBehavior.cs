using UnityEngine;
using System.Collections;

public class PrincessPassBehavior : GeneralTerritoryBehavior
{
    // Use this for initialization
    void Start()
    {
        Unit0Pos = new Vector3((float)3.55, (float)0.02, (float)11.18);
        Unit1Pos = new Vector3((float)3.69, (float)0.03, (float)11.6);
        Unit2Pos = new Vector3((float)3.93, (float)0.04, (float)11.18);
        Unit3Pos = new Vector3((float)3.27, (float)0.01, (float)11.6);

        OrderTokenPos = new Vector3((float)3.00, (float)0.06, (float)11.03);

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
            if (T.Name == "PrincesPass")
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
