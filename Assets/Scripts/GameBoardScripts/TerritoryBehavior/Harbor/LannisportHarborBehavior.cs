using UnityEngine;
using System.Collections;

public class LannisportHarborBehavior : GeneralTerritoryBehavior
{
	// Use this for initialization
	void Start()
	{
        Unit3Pos = new Vector3((float)5.95, (float)0.01, (float)4.55);
        Unit0Pos = new Vector3((float)6.15, (float)0.02, (float)4.65);
        Unit1Pos = new Vector3((float)6.35, (float)0.03, (float)4.75);
        Unit2Pos = new Vector3((float)6.55, (float)0.04, (float)4.85);

        OrderTokenPos = new Vector3((float)6.04, (float)0.06, (float)4.96);

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
			if (T.Name == "LannisportHarbor")
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
