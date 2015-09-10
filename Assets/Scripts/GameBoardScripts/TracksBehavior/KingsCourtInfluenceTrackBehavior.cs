using UnityEngine;
using System.Collections;

public class KingsCourtInfluenceTrackBehavior : InfluenceTrackBehaviorObserver
{

	private InfluenceTrackSubject mySubject;

	private Vector3 Position1Pos = new Vector3((float)-7.23, (float)0, (float)-2.44);
	private Vector3 Position2Pos = new Vector3((float)-7.23, (float)0, (float)-3.67);
	private Vector3 Position3Pos = new Vector3((float)-7.23, (float)0, (float)-4.95);
	private Vector3 Position4Pos = new Vector3((float)-7.23, (float)0, (float)-6.19);
	private Vector3 Position5Pos = new Vector3((float)-7.23, (float)0, (float)-7.44);
	private Vector3 Position6Pos = new Vector3((float)-7.23, (float)0, (float)-8.69);

	private Vector3[] PositionArray = new Vector3[6];

	private GameObject[] RenderedTrack = new GameObject[6];

	private InfluenceTrack myTrack;

	void Start()
	{

		PositionArray[0] = Position1Pos;
		PositionArray[1] = Position2Pos;
		PositionArray[2] = Position3Pos;
		PositionArray[3] = Position4Pos;
		PositionArray[4] = Position5Pos;
		PositionArray[5] = Position6Pos;

		myTrack = GameBase.KingsCourtTrack;

		mySubject = GameBase.KingsCourtTrack;
		mySubject.DefineObserver(this);

		mySubject.InitialObserverCall();
	}

	public override void NotifyValueChanged()
	{
		RenderTrack();
	}

	private void RenderTrack()
	{
		foreach (GameObject go in RenderedTrack)
		{
			if (go != null)
			{
				Destroy(go);
			}
		}

		for (int i = 1; i < myTrack.ReturnTrackLenght() + 1; i++)
		{
            if (myTrack.ReturnHouseAtPosition(i) != null)
            {
                GameObject RenderedTrackIcon = new GameObject();

                RenderedTrackIcon.AddComponent<MeshRenderer>();
                RenderedTrackIcon.GetComponent<Renderer>().castShadows = true;
                RenderedTrackIcon.GetComponent<Renderer>().receiveShadows = true;

                RenderedTrackIcon.AddComponent<Rigidbody>();
                RenderedTrackIcon.GetComponent<Rigidbody>().useGravity = false;

                RenderedTrackIcon.AddComponent<MeshFilter>();
                RenderedTrackIcon.GetComponent<MeshFilter>().mesh = (Mesh)((GameObject)Resources.Load("Graphics/Models/Track/Influence")).GetComponent<MeshFilter>().mesh;

                string MaterialLoad = "Graphics/TrackMaterials/";

                if (myTrack.ReturnHouseAtPosition(i).HouseCharacter == HouseCharacter.Baratheon)
                {
                    MaterialLoad = MaterialLoad + "Baratheon";
                }
                else if (myTrack.ReturnHouseAtPosition(i).HouseCharacter == HouseCharacter.Greyjoy)
                {
                    MaterialLoad = MaterialLoad + "Greyjoy";
                }
                else if (myTrack.ReturnHouseAtPosition(i).HouseCharacter == HouseCharacter.Lannister)
                {
                    MaterialLoad = MaterialLoad + "Lannister";
                }
                else if (myTrack.ReturnHouseAtPosition(i).HouseCharacter == HouseCharacter.Martell)
                {
                    MaterialLoad = MaterialLoad + "Martell";
                }
                else if (myTrack.ReturnHouseAtPosition(i).HouseCharacter == HouseCharacter.Stark)
                {
                    MaterialLoad = MaterialLoad + "Stark";
                }
                else if (myTrack.ReturnHouseAtPosition(i).HouseCharacter == HouseCharacter.Tyrell)
                {
                    MaterialLoad = MaterialLoad + "Tyrell";
                }
                MaterialLoad = MaterialLoad + "Influence";

                RenderedTrackIcon.GetComponent<Renderer>().material = (Material)Resources.Load(MaterialLoad);


                RenderedTrackIcon.transform.position = PositionArray[i - 1];
                RenderedTrackIcon.transform.rotation = Quaternion.Euler(270, 270, 0);
                RenderedTrackIcon.transform.localScale = new Vector3((float)0.7, (float)0.7, (float)0.7);
                RenderedTrack[i - 1] = RenderedTrackIcon;
            }
		}


	}
}
