using UnityEngine;
using System.Collections;

public class OldtownHarborBehavior : GeneralTerritoryBehavior
{
	// Use this for initialization
	void Start()
	{
        Unit3Pos = new Vector3((float)6.6, (float)0.01, (float)10.2);
        Unit0Pos = new Vector3((float)6.8, (float)0.02, (float)10.3);
        Unit1Pos = new Vector3((float)7, (float)0.03, (float)10.4);
        Unit2Pos = new Vector3((float)7.2, (float)0.04, (float)10.5);

        OrderTokenPos = new Vector3((float)6.72, (float)0.06, (float)10.94);

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
			if (T.Name == "OldtownHarbor")
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
