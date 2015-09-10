using UnityEngine;
using System.Collections;

public class PykeHarborBehavior : GeneralTerritoryBehavior {

	// Use this for initialization
	void Start () {

		Unit3Pos = new Vector3((float)5.25, (float)0.01, (float)1.55);
		Unit0Pos = new Vector3((float)5.45, (float)0.02, (float)1.65);
		Unit1Pos = new Vector3((float)5.65, (float)0.03, (float)1.75);
		Unit2Pos = new Vector3((float)5.85, (float)0.04, (float)1.85);

        OrderTokenPos = new Vector3((float)5.38, (float)0.06, (float)1.92);

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
			if (T.Name == "PykeHarbor")
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
