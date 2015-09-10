using UnityEngine;
using System.Collections;

public class StormsEndHarborBehavior : GeneralTerritoryBehavior
{

	// Use this for initialization
	void Start()
	{
        Unit3Pos = new Vector3((float)-1.5, (float)0.01, (float)9);
        Unit0Pos = new Vector3((float)-1.3, (float)0.02, (float)9.1);
        Unit1Pos = new Vector3((float)-1.1, (float)0.03, (float)9.2);
        Unit2Pos = new Vector3((float)-0.9, (float)0.04, (float)9.3);

        OrderTokenPos = new Vector3((float)-1.44, (float)0.06, (float)9.51);

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
			if (T.Name == "StormsEndHarbor")
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
