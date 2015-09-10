using UnityEngine;
using System.Collections;

public class RoundTrackBehavior : RoundTrackBehaviorObserver {

	private RoundTrackSubject mySubject;

	private GameObject TrackIcon;

	// Use this for initialization
	void Start () {
		mySubject = GameBase.roundTrack;

		mySubject.DefineObserver(this);
		mySubject.InitialObserverCall();
	}

	public override void RoundTrackChanged()
	{
		RenderTrackIcon();
	}

	private void RenderTrackIcon() 
	{
		Destroy(TrackIcon);

		TrackIcon = new GameObject();
		TrackIcon.name = "RoundIcon";

		TrackIcon.AddComponent<MeshRenderer>();
		TrackIcon.GetComponent<Renderer>().receiveShadows = true;

		TrackIcon.AddComponent<Rigidbody>();
		TrackIcon.GetComponent<Rigidbody>().useGravity = false;

		TrackIcon.AddComponent<MeshFilter>();
		TrackIcon.GetComponent<MeshFilter>().sharedMesh = (Mesh)((GameObject)Resources.Load("Graphics/Models/Track/RoundIcon")).GetComponent<MeshFilter>().sharedMesh;

		TrackIcon.GetComponent<Renderer>().material = (Material)Resources.Load("Graphics/TrackMaterials/RoundIcon");

		TrackIcon.transform.localScale = new Vector3((float)0.5 , (float)0.5, (float)0.5);
		TrackIcon.transform.rotation = Quaternion.Euler(270,0,0);
		TrackIcon.transform.position = new Vector3((float)-5.25 ,(float)0.01, (float)(14.87 - 0.73*GameBase.roundTrack.CurrentRound()) );

	}
}
