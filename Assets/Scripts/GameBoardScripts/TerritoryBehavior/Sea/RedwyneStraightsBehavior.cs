using UnityEngine;
using System.Collections;

public class RedwyneStraightsBehavior : GeneralTerritoryBehavior
{
	// Use this for initialization
	void Start()
	{
        Unit3Pos = new Vector3((float)7.8, (float)0.01, (float)11.85);
        Unit0Pos = new Vector3((float)7.30, (float)0.02, (float)11.85);
        Unit1Pos = new Vector3((float)7.30, (float)0.03, (float)11.35);
        Unit2Pos = new Vector3((float)7.8, (float)0.04, (float)11.35);

        OrderTokenPos = new Vector3((float)7.55, (float)0.06, (float)12.25);

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
			if (T.Name == "RedwyneStraights")
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
