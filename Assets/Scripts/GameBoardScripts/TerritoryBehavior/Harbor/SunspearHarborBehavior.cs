using UnityEngine;
using System.Collections;

public class SunspearHarborBehavior : GeneralTerritoryBehavior
{

	// Use this for initialization
	void Start()
	{
        Unit3Pos = new Vector3((float)-2.95, (float)0.01, (float)12.25);
        Unit0Pos = new Vector3((float)-2.75, (float)0.02, (float)12.35);
        Unit1Pos = new Vector3((float)-2.55, (float)0.03, (float)12.45);
        Unit2Pos = new Vector3((float)-2.35, (float)0.04, (float)12.55);

        OrderTokenPos = new Vector3((float)-2.81, (float)0.06, (float)12.72);

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
			if (T.Name == "SunspearHarbor")
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
