using UnityEngine;
using System.Collections;

public class BlackwaterBayBehavior : GeneralTerritoryBehavior
{
	// Use this for initialization
	void Start()
	{
        Unit3Pos = new Vector3((float)-0.46, (float)0.01, (float)6.46);
        Unit0Pos = new Vector3((float)-1.17, (float)0.02, (float)5.66);
        Unit1Pos = new Vector3((float)-0.72, (float)0.03, (float)5.6);
        Unit2Pos = new Vector3((float)-0.95, (float)0.04, (float)6.46);

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
			if (T.Name == "BlackwaterBay")
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
