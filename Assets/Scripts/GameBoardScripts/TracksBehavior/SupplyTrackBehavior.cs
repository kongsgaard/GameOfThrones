using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SupplyTrackBehavior : SupplyTrackBehaviorObserver {

    private SupplyTrackSubject mySubject;
    private SupplyTrack supplyTrack;
    private List<GameObject> RenderedIcons = new List<GameObject>();


    public override void NotifySupplyChanged()
    {
        RenderSupplyTrack();
    }

    #region IconPositions + Scales
    private Vector3[] ScaleDependingOnCountArray = new Vector3[7];
    private Vector3 ScaleOneCount = new Vector3((float)0.5, (float)0.5, (float)0.5);
    private Vector3 ScaleTwoToFour = new Vector3((float)0.35, (float)0.35, (float)(0.35));
    private Vector3 ScaleFiveToSix = new Vector3((float)0.3, (float)0.3, (float)(0.3));

    private Vector3[] PositionsOneArray = new Vector3[7];
    private Vector3 PositionOne0 = new Vector3((float)-5.51, (float)0.01, (float)5.84);
    private Vector3 PositionOne1 = new Vector3((float)-5.51, (float)0.01, (float)5.04);
    private Vector3 PositionOne2 = new Vector3((float)-5.51, (float)0.01, (float)4.24);
    private Vector3 PositionOne3 = new Vector3((float)-5.51, (float)0.01, (float)3.44);
    private Vector3 PositionOne4 = new Vector3((float)-5.51, (float)0.01, (float)2.63);
    private Vector3 PositionOne5 = new Vector3((float)-5.51, (float)0.01, (float)1.83);
    private Vector3 PositionOne6 = new Vector3((float)-5.51, (float)0.01, (float)1.04);

    private Vector3[,] PositionTwoArray = new Vector3[7,2];
    private Vector3 PositionTwo0First = new Vector3((float)-5.51, (float)0.01, (float)6.01);
    private Vector3 PositionTwo0Second = new Vector3((float)-5.51, (float)0.01, (float)5.66);

    private Vector3 PositionTwo1First = new Vector3((float)-5.51, (float)0.01, (float)4.86);
    private Vector3 PositionTwo1Second = new Vector3((float)-5.51, (float)0.01, (float)5.21);

    private Vector3 PositionTwo2First = new Vector3((float)-5.51, (float)0.01, (float)4.39);
    private Vector3 PositionTwo2Second = new Vector3((float)-5.51, (float)0.01, (float)4.04);

    private Vector3 PositionTwo3First = new Vector3((float)-5.51, (float)0.01, (float)3.63);
    private Vector3 PositionTwo3Second = new Vector3((float)-5.51, (float)0.01, (float)3.28);

    private Vector3 PositionTwo4First = new Vector3((float)-5.51, (float)0.01, (float)2.80);
    private Vector3 PositionTwo4Second = new Vector3((float)-5.51, (float)0.01, (float)2.46);

    private Vector3 PositionTwo5First = new Vector3((float)-5.51, (float)0.01, (float)2.02);
    private Vector3 PositionTwo5Second = new Vector3((float)-5.51, (float)0.01, (float)1.67);

    private Vector3 PositionTwo6First = new Vector3((float)-5.51, (float)0.01, (float)1.2);
    private Vector3 PositionTwo6Second = new Vector3((float)-5.51, (float)0.01, (float)0.85);

    private Vector3[,] PositionThreeArray = new Vector3[7, 3];
    private Vector3 PositionThree0First = new Vector3((float)-5.24, (float)0.01, (float)6.01);
    private Vector3 PositionThree0Second = new Vector3((float)-5.24, (float)0.01, (float)5.66);
    private Vector3 PositionThree0Third = new Vector3((float)-5.69, (float)0.01, (float)5.88);

    private Vector3 PositionThree1First = new Vector3((float)-5.24, (float)0.01, (float)4.86);
    private Vector3 PositionThree1Second = new Vector3((float)-5.24, (float)0.01, (float)5.21);
    private Vector3 PositionThree1Third = new Vector3((float)-5.69, (float)0.01, (float)5.03);

    private Vector3 PositionThree2First = new Vector3((float)-5.24, (float)0.01, (float)4.39);
    private Vector3 PositionThree2Second = new Vector3((float)-5.24, (float)0.01, (float)4.04);
    private Vector3 PositionThree2Third = new Vector3((float)-5.69, (float)0.01, (float)4.20);

    private Vector3 PositionThree3First = new Vector3((float)-5.24, (float)0.01, (float)3.63);
    private Vector3 PositionThree3Second = new Vector3((float)-5.24, (float)0.01, (float)3.28);
    private Vector3 PositionThree3Third = new Vector3((float)-5.69, (float)0.01, (float)3.46);

    private Vector3 PositionThree4First = new Vector3((float)-5.24, (float)0.01, (float)2.80);
    private Vector3 PositionThree4Second = new Vector3((float)-5.24, (float)0.01, (float)2.46);
    private Vector3 PositionThree4Third = new Vector3((float)-5.69, (float)0.01, (float)2.63);

    private Vector3 PositionThree5First = new Vector3((float)-5.24, (float)0.01, (float)2.02);
    private Vector3 PositionThree5Second = new Vector3((float)-5.24, (float)0.01, (float)1.67);
    private Vector3 PositionThree5Third = new Vector3((float)-5.69, (float)0.01, (float)1.85);

    private Vector3 PositionThree6First = new Vector3((float)-5.24, (float)0.01, (float)1.2);
    private Vector3 PositionThree6Second = new Vector3((float)-5.24, (float)0.01, (float)0.85);
    private Vector3 PositionThree6Third = new Vector3((float)-5.69, (float)0.01, (float)1.02);

    private Vector3[,] PositionFourArray = new Vector3[7, 4];
    private Vector3 PositionFour0First = new Vector3((float)-5.24, (float)0.01, (float)6.01);
    private Vector3 PositionFour0Second = new Vector3((float)-5.24, (float)0.01, (float)5.66);
    private Vector3 PositionFour0Third = new Vector3((float)-5.69, (float)0.01, (float)6.01);
    private Vector3 PositionFour0Fourth = new Vector3((float)-5.69, (float)0.01, (float)5.66);

    private Vector3 PositionFour1First = new Vector3((float)-5.24, (float)0.01, (float)4.86);
    private Vector3 PositionFour1Second = new Vector3((float)-5.24, (float)0.01, (float)5.21);
    private Vector3 PositionFour1Third = new Vector3((float)-5.69, (float)0.01, (float)4.86);
    private Vector3 PositionFour1Fourth = new Vector3((float)-5.69, (float)0.01, (float)5.21);

    private Vector3 PositionFour2First = new Vector3((float)-5.24, (float)0.01, (float)4.39);
    private Vector3 PositionFour2Second = new Vector3((float)-5.24, (float)0.01, (float)4.04);
    private Vector3 PositionFour2Third = new Vector3((float)-5.69, (float)0.01, (float)4.39);
    private Vector3 PositionFour2Fourth = new Vector3((float)-5.69, (float)0.01, (float)4.04);

    private Vector3 PositionFour3First = new Vector3((float)-5.24, (float)0.01, (float)3.63);
    private Vector3 PositionFour3Second = new Vector3((float)-5.24, (float)0.01, (float)3.28);
    private Vector3 PositionFour3Third = new Vector3((float)-5.69, (float)0.01, (float)3.63);
    private Vector3 PositionFour3Fourth = new Vector3((float)-5.69, (float)0.01, (float)3.28);

    private Vector3 PositionFour4First = new Vector3((float)-5.24, (float)0.01, (float)2.80);
    private Vector3 PositionFour4Second = new Vector3((float)-5.24, (float)0.01, (float)2.46);
    private Vector3 PositionFour4Third = new Vector3((float)-5.69, (float)0.01, (float)2.80);
    private Vector3 PositionFour4Fourth = new Vector3((float)-5.69, (float)0.01, (float)2.46);

    private Vector3 PositionFour5First = new Vector3((float)-5.24, (float)0.01, (float)2.02);
    private Vector3 PositionFour5Second = new Vector3((float)-5.24, (float)0.01, (float)1.67);
    private Vector3 PositionFour5Third = new Vector3((float)-5.69, (float)0.01, (float)2.02);
    private Vector3 PositionFour5Fourth = new Vector3((float)-5.69, (float)0.01, (float)1.67);

    private Vector3 PositionFour6First = new Vector3((float)-5.24, (float)0.01, (float)1.2);
    private Vector3 PositionFour6Second = new Vector3((float)-5.24, (float)0.01, (float)0.85);
    private Vector3 PositionFour6Third = new Vector3((float)-5.69, (float)0.01, (float)1.2);
    private Vector3 PositionFour6Fourth = new Vector3((float)-5.69, (float)0.01, (float)0.85);

    private Vector3[,] PositionSixArray = new Vector3[7, 6];
    private Vector3 PositionSix0First = new Vector3((float)-5.24, (float)0.01, (float)5.21);
    private Vector3 PositionSix0Second = new Vector3((float)-5.24, (float)0.01, (float)4.86);
	private Vector3 PositionSix0Third = new Vector3((float)-5.59, (float)0.01, (float)5.21);
	private Vector3 PositionSix0Fourth = new Vector3((float)-5.59, (float)0.01, (float)4.86);
    private Vector3 PositionSix0Fifth = new Vector3((float)-5.94, (float)0.01, (float)5.21);
    private Vector3 PositionSix0Sixth = new Vector3((float)-5.94, (float)0.01, (float)4.86);

    private Vector3 PositionSix1First = new Vector3((float)-5.24, (float)0.01, (float)5.21);
    private Vector3 PositionSix1Second = new Vector3((float)-5.24, (float)0.01, (float)4.86);
	private Vector3 PositionSix1Third = new Vector3((float)-5.59, (float)0.01, (float)5.21);
	private Vector3 PositionSix1Fourth = new Vector3((float)-5.59, (float)0.01, (float)4.86);
    private Vector3 PositionSix1Fifth = new Vector3((float)-5.94, (float)0.01, (float)5.21);
    private Vector3 PositionSix1Sixth = new Vector3((float)-5.94, (float)0.01, (float)4.86);

    private Vector3 PositionSix2First = new Vector3((float)-5.24, (float)0.01, (float)4.39);
    private Vector3 PositionSix2Second = new Vector3((float)-5.24, (float)0.01, (float)4.04);
	private Vector3 PositionSix2Third = new Vector3((float)-5.59, (float)0.01, (float)4.39);
	private Vector3 PositionSix2Fourth = new Vector3((float)-5.59, (float)0.01, (float)4.04);
    private Vector3 PositionSix2Fifth = new Vector3((float)-5.94, (float)0.01, (float)4.39);
    private Vector3 PositionSix2Sixth = new Vector3((float)-5.94, (float)0.01, (float)4.04);

    private Vector3 PositionSix3First = new Vector3((float)-5.24, (float)0.01, (float)3.63);
    private Vector3 PositionSix3Second = new Vector3((float)-5.24, (float)0.01, (float)3.28);
    private Vector3 PositionSix3Third = new Vector3((float)-5.69, (float)0.01, (float)3.63);
    private Vector3 PositionSix3Fourth = new Vector3((float)-5.69, (float)0.01, (float)3.28);
    private Vector3 PositionSix3Fifth = new Vector3((float)-5.94, (float)0.01, (float)3.63);
    private Vector3 PositionSix3Sixth = new Vector3((float)-5.94, (float)0.01, (float)3.28);

    private Vector3 PositionSix4First = new Vector3((float)-5.24, (float)0.01, (float)2.80);
    private Vector3 PositionSix4Second = new Vector3((float)-5.24, (float)0.01, (float)2.46);
    private Vector3 PositionSix4Third = new Vector3((float)-5.69, (float)0.01, (float)2.80);
    private Vector3 PositionSix4Fourth = new Vector3((float)-5.69, (float)0.01, (float)2.46);
    private Vector3 PositionSix4Fifth = new Vector3((float)-5.94, (float)0.01, (float)2.80);
    private Vector3 PositionSix4Sixth = new Vector3((float)-5.94, (float)0.01, (float)2.46);

    private Vector3 PositionSix5First = new Vector3((float)-5.24, (float)0.01, (float)2.02);
    private Vector3 PositionSix5Second = new Vector3((float)-5.24, (float)0.01, (float)1.67);
	private Vector3 PositionSix5Third = new Vector3((float)-5.59, (float)0.01, (float)2.02);
	private Vector3 PositionSix5Fourth = new Vector3((float)-5.59, (float)0.01, (float)1.67);
    private Vector3 PositionSix5Fifth = new Vector3((float)-5.94, (float)0.01, (float)2.02);
    private Vector3 PositionSix5Sixth = new Vector3((float)-5.94, (float)0.01, (float)1.67);

    private Vector3 PositionSix6First = new Vector3((float)-5.24, (float)0.01, (float)1.2);
    private Vector3 PositionSix6Second = new Vector3((float)-5.24, (float)0.01, (float)0.85);
	private Vector3 PositionSix6Third = new Vector3((float)-5.59, (float)0.01, (float)1.2);
	private Vector3 PositionSix6Fourth = new Vector3((float)-5.59, (float)0.01, (float)0.85);
    private Vector3 PositionSix6Fifth = new Vector3((float)-5.94, (float)0.01, (float)1.2);
    private Vector3 PositionSix6Sixth = new Vector3((float)-5.94, (float)0.01, (float)0.85);
    #endregion


    // Use this for initialization
	void Start ()
    {
        #region InitializePositionArrays

        //Single Supply Icon
        PositionsOneArray[0] = PositionOne0;
        PositionsOneArray[1] = PositionOne1;
        PositionsOneArray[2] = PositionOne2;
        PositionsOneArray[3] = PositionOne3;
        PositionsOneArray[4] = PositionOne4;
        PositionsOneArray[5] = PositionOne5;
        PositionsOneArray[6] = PositionOne6;

        //Two Supply Icons
        PositionTwoArray[0, 0] = PositionTwo0First; PositionTwoArray[0, 1] = PositionTwo0Second;
        PositionTwoArray[1, 0] = PositionTwo1First; PositionTwoArray[1, 1] = PositionTwo1Second;
        PositionTwoArray[2, 0] = PositionTwo2First; PositionTwoArray[2, 1] = PositionTwo2Second;
        PositionTwoArray[3, 0] = PositionTwo3First; PositionTwoArray[3, 1] = PositionTwo3Second;
        PositionTwoArray[4, 0] = PositionTwo4First; PositionTwoArray[4, 1] = PositionTwo4Second;
        PositionTwoArray[5, 0] = PositionTwo5First; PositionTwoArray[5, 1] = PositionTwo5Second;
        PositionTwoArray[6, 0] = PositionTwo6First; PositionTwoArray[6, 1] = PositionTwo6Second;

        PositionThreeArray[0, 0] = PositionThree0First; PositionThreeArray[0, 1] = PositionThree0Second; PositionThreeArray[0, 2] = PositionThree0Third;
        PositionThreeArray[1, 0] = PositionThree1First; PositionThreeArray[1, 1] = PositionThree1Second; PositionThreeArray[1, 2] = PositionThree1Third;
        PositionThreeArray[2, 0] = PositionThree2First; PositionThreeArray[2, 1] = PositionThree2Second; PositionThreeArray[2, 2] = PositionThree2Third;
        PositionThreeArray[3, 0] = PositionThree3First; PositionThreeArray[3, 1] = PositionThree3Second; PositionThreeArray[3, 2] = PositionThree3Third;
        PositionThreeArray[4, 0] = PositionThree4First; PositionThreeArray[4, 1] = PositionThree4Second; PositionThreeArray[4, 2] = PositionThree4Third;
        PositionThreeArray[5, 0] = PositionThree5First; PositionThreeArray[5, 1] = PositionThree5Second; PositionThreeArray[5, 2] = PositionThree5Third;
        PositionThreeArray[6, 0] = PositionThree6First; PositionThreeArray[6, 1] = PositionThree6Second; PositionThreeArray[6, 2] = PositionThree6Third;

        PositionFourArray[0, 0] = PositionFour0First; PositionFourArray[0, 1] = PositionFour0Second; PositionFourArray[0, 2] = PositionFour0Third; PositionFourArray[0, 3] = PositionFour0Fourth;
        PositionFourArray[1, 0] = PositionFour1First; PositionFourArray[1, 1] = PositionFour1Second; PositionFourArray[1, 2] = PositionFour1Third; PositionFourArray[1, 3] = PositionFour1Fourth;
        PositionFourArray[2, 0] = PositionFour2First; PositionFourArray[2, 1] = PositionFour2Second; PositionFourArray[2, 2] = PositionFour2Third; PositionFourArray[2, 3] = PositionFour2Fourth;
        PositionFourArray[3, 0] = PositionFour3First; PositionFourArray[3, 1] = PositionFour3Second; PositionFourArray[3, 2] = PositionFour3Third; PositionFourArray[3, 3] = PositionFour3Fourth;
        PositionFourArray[4, 0] = PositionFour4First; PositionFourArray[4, 1] = PositionFour4Second; PositionFourArray[4, 2] = PositionFour4Third; PositionFourArray[4, 3] = PositionFour4Fourth;
        PositionFourArray[5, 0] = PositionFour5First; PositionFourArray[5, 1] = PositionFour5Second; PositionFourArray[5, 2] = PositionFour5Third; PositionFourArray[5, 3] = PositionFour5Fourth;
        PositionFourArray[6, 0] = PositionFour6First; PositionFourArray[6, 1] = PositionFour6Second; PositionFourArray[6, 2] = PositionFour6Third; PositionFourArray[6, 3] = PositionFour6Fourth;

        PositionSixArray[0, 0] = PositionSix0First; PositionSixArray[0, 1] = PositionSix0Second; PositionSixArray[0,2] = PositionSix0Third; PositionSixArray[0, 3] = PositionSix0Fourth; PositionSixArray[0, 4] = PositionSix0Fifth; PositionSixArray[0, 5] = PositionSix0Sixth;
        PositionSixArray[1, 0] = PositionSix1First; PositionSixArray[1, 1] = PositionSix1Second; PositionSixArray[1, 2] = PositionSix1Third; PositionSixArray[1, 3] = PositionSix1Fourth; PositionSixArray[1, 4] = PositionSix1Fifth; PositionSixArray[1, 5] = PositionSix1Sixth;
        PositionSixArray[2, 0] = PositionSix2First; PositionSixArray[2, 1] = PositionSix2Second; PositionSixArray[2, 2] = PositionSix2Third; PositionSixArray[2, 3] = PositionSix2Fourth; PositionSixArray[2, 4] = PositionSix2Fifth; PositionSixArray[2, 5] = PositionSix2Sixth;
        PositionSixArray[3, 0] = PositionSix3First; PositionSixArray[3, 1] = PositionSix3Second; PositionSixArray[3, 2] = PositionSix3Third; PositionSixArray[3, 3] = PositionSix3Fourth; PositionSixArray[3, 4] = PositionSix3Fifth; PositionSixArray[3, 5] = PositionSix3Sixth;
        PositionSixArray[4, 0] = PositionSix4First; PositionSixArray[4, 1] = PositionSix4Second; PositionSixArray[4, 2] = PositionSix4Third; PositionSixArray[4, 3] = PositionSix4Fourth; PositionSixArray[4, 4] = PositionSix4Fifth; PositionSixArray[4, 5] = PositionSix4Sixth;
        PositionSixArray[5, 0] = PositionSix5First; PositionSixArray[5, 1] = PositionSix5Second; PositionSixArray[5, 2] = PositionSix5Third; PositionSixArray[5, 3] = PositionSix5Fourth; PositionSixArray[5, 4] = PositionSix5Fifth; PositionSixArray[5, 5] = PositionSix5Sixth;
        PositionSixArray[6, 0] = PositionSix6First; PositionSixArray[6, 1] = PositionSix6Second; PositionSixArray[6, 2] = PositionSix6Third; PositionSixArray[6, 3] = PositionSix6Fourth; PositionSixArray[6, 4] = PositionSix6Fifth; PositionSixArray[6, 5] = PositionSix6Sixth;

        #endregion
		supplyTrack = GameBase.supplyTrack;
        mySubject = GameBase.supplyTrack;
        mySubject.DefineObserver(this);
        mySubject.InitialObserverCall();
	}

    private void RenderSupplyTrack() 
    {
        foreach (GameObject go in RenderedIcons) 
        {
            Destroy(go);
        }

        for (int i = 0; i < 7; i++) 
        {
            if (supplyTrack.AllSupplyTracks[i].Count > 0) 
            {
                RenderSupplyPosition(i, supplyTrack.AllSupplyTracks[i].Count);
            }
        }
    }

    private void RenderSupplyPosition(int Position, int Players) 
    {
        for (int i = 0; i < Players; i++) 
        {
            GameObject RenderIcon = new GameObject();
            RenderedIcons.Add(RenderIcon);

            RenderIcon.AddComponent<Rigidbody>();
            RenderIcon.GetComponent<Rigidbody>().useGravity = false;

            RenderIcon.AddComponent<MeshRenderer>();
            RenderIcon.GetComponent<Renderer>().castShadows = true;
            RenderIcon.GetComponent<Renderer>().receiveShadows = true;

            RenderIcon.AddComponent<MeshFilter>();
            RenderIcon.GetComponent<MeshFilter>().mesh = (Mesh)((GameObject)Resources.Load("Graphics/Models/Track/SupplyIcon")).GetComponent<MeshFilter>().mesh;

            string MaterialLoad = "Graphics/TrackMaterials/";
            if (supplyTrack.AllSupplyTracks[Position][i].HouseCharacter == HouseCharacter.Baratheon) 
            {
                MaterialLoad = MaterialLoad + "BaratheonSupply";
				RenderIcon.name = "BaratheonSupplyIcon";
            }
            else if (supplyTrack.AllSupplyTracks[Position][i].HouseCharacter == HouseCharacter.Greyjoy)
            {
                MaterialLoad = MaterialLoad + "GreyjoySupply";
				RenderIcon.name = "GreyjoySupplyIcon";
            }
            else if (supplyTrack.AllSupplyTracks[Position][i].HouseCharacter == HouseCharacter.Lannister)
            {
                MaterialLoad = MaterialLoad + "LannisterSupply";
				RenderIcon.name = "LannisterSupplyIcon";
            }
            else if (supplyTrack.AllSupplyTracks[Position][i].HouseCharacter == HouseCharacter.Martell)
            {
                MaterialLoad = MaterialLoad + "MartellSupply";
				RenderIcon.name = "MartellSupplyIcon";
            }
            else if (supplyTrack.AllSupplyTracks[Position][i].HouseCharacter == HouseCharacter.Stark)
            {
                MaterialLoad = MaterialLoad + "StarkSupply";
				RenderIcon.name = "StarkSupplyIcon";
            }
            else if (supplyTrack.AllSupplyTracks[Position][i].HouseCharacter == HouseCharacter.Tyrell)
            {
                MaterialLoad = MaterialLoad + "TyrellSupply";
				RenderIcon.name = "TyrellSupplyIcon";
            }

            RenderIcon.GetComponent<Renderer>().material = (Material)Resources.Load(MaterialLoad);

            RenderIcon.transform.rotation = Quaternion.Euler(270,0,0);

            if (Players == 1) 
            {
                RenderIcon.transform.localScale = ScaleOneCount;
                if (Position == 0)  { RenderIcon.transform.position = PositionOne0; }
                else if (Position == 1) { RenderIcon.transform.position = PositionOne1; }
				else if (Position == 2) { RenderIcon.transform.position = PositionOne2; }
				else if (Position == 3) { RenderIcon.transform.position = PositionOne3; }
				else if (Position == 4) { RenderIcon.transform.position = PositionOne4; }
				else if (Position == 5) { RenderIcon.transform.position = PositionOne5; }
				else if (Position == 6) { RenderIcon.transform.position = PositionOne6; }
            }
			if (Players == 2) 
			{
				RenderIcon.transform.localScale = ScaleTwoToFour;
				if (Position == 0) { RenderIcon.transform.position = PositionTwoArray[0,i]; }
				else if (Position == 1) { RenderIcon.transform.position = PositionTwoArray[1, i]; }
				else if (Position == 2) { RenderIcon.transform.position = PositionTwoArray[2, i]; }
				else if (Position == 3) { RenderIcon.transform.position = PositionTwoArray[3, i]; }
				else if (Position == 4) { RenderIcon.transform.position = PositionTwoArray[4, i]; }
				else if (Position == 5) { RenderIcon.transform.position = PositionTwoArray[5, i]; }
				else if (Position == 6) { RenderIcon.transform.position = PositionTwoArray[6, i]; }
			}
			if (Players == 3)
			{
				RenderIcon.transform.localScale = ScaleTwoToFour;
				if (Position == 0) { RenderIcon.transform.position = PositionThreeArray[0, i]; }
				else if (Position == 1) { RenderIcon.transform.position = PositionThreeArray[1, i]; }
				else if (Position == 2) { RenderIcon.transform.position = PositionThreeArray[2, i]; }
				else if (Position == 3) { RenderIcon.transform.position = PositionThreeArray[3, i]; }
				else if (Position == 4) { RenderIcon.transform.position = PositionThreeArray[4, i]; }
				else if (Position == 5) { RenderIcon.transform.position = PositionThreeArray[5, i]; }
				else if (Position == 6) { RenderIcon.transform.position = PositionThreeArray[6, i]; }
			}
			if (Players == 4)
			{
				RenderIcon.transform.localScale = ScaleTwoToFour;
				if (Position == 0) { RenderIcon.transform.position = PositionFourArray[0, i]; }
				else if (Position == 1) { RenderIcon.transform.position = PositionFourArray[1, i]; }
				else if (Position == 2) { RenderIcon.transform.position = PositionFourArray[2, i]; }
				else if (Position == 3) { RenderIcon.transform.position = PositionFourArray[3, i]; }
				else if (Position == 4) { RenderIcon.transform.position = PositionFourArray[4, i]; }
				else if (Position == 5) { RenderIcon.transform.position = PositionFourArray[5, i]; }
				else if (Position == 6) { RenderIcon.transform.position = PositionFourArray[6, i]; }
			}
			if (Players == 5 || Players == 6)
			{
				RenderIcon.transform.localScale = ScaleFiveToSix;
				if (Position == 0) { RenderIcon.transform.position = PositionSixArray[0, i]; }
				else if (Position == 1) { RenderIcon.transform.position = PositionSixArray[1, i]; }
				else if (Position == 2) { RenderIcon.transform.position = PositionSixArray[2, i]; }
				else if (Position == 3) { RenderIcon.transform.position = PositionSixArray[3, i]; }
				else if (Position == 4) { RenderIcon.transform.position = PositionSixArray[4, i]; }
				else if (Position == 5) { RenderIcon.transform.position = PositionSixArray[5, i]; }
				else if (Position == 6) { RenderIcon.transform.position = PositionSixArray[6, i]; }
			}
        }
    }
}
