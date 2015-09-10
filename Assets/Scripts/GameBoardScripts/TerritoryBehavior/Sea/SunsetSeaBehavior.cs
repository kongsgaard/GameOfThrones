using UnityEngine;
using System.Collections;

public class SunsetSeaBehavior : GeneralTerritoryBehavior
{
	// Use this for initialization
	void Start()
	{
        Unit3Pos = new Vector3((float)6.72, (float)0.01, (float)6.85);
        Unit0Pos = new Vector3((float)7.1, (float)0.02, (float)6.9);
        Unit1Pos = new Vector3((float)7.48, (float)0.03, (float)6.95);
        Unit2Pos = new Vector3((float)7.86, (float)0.04, (float)7);

        OrderTokenPos = new Vector3((float)8.27, (float)0.06, (float)6.99);

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
			if (T.Name == "SunsetSea")
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
