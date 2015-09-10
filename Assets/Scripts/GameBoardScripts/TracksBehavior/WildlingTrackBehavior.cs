using UnityEngine;
using System.Collections;

public class WildlingTrackBehavior : WildlingTrackBehaviorObserver {

    private WildlingTrackSubject mySubject;


    Vector3 WildlingIconPos0 = new Vector3((float)4.95 ,(float)0.01 ,(float)-8.85);
    Vector3 WildlingIconPos1 = new Vector3((float)4.14 ,(float)0.01 ,(float)-8.85);
    Vector3 WildlingIconPos2 = new Vector3((float)3.27 ,(float)0.01 ,(float)-8.85);
    Vector3 WildlingIconPos3 = new Vector3((float)2.43 ,(float)0.01 ,(float)-8.85);
    Vector3 WildlingIconPos4 = new Vector3((float)1.55 ,(float)0.01 ,(float)-8.85);
    Vector3 WildlingIconPos5 = new Vector3((float)0.71 ,(float)0.01 ,(float)-8.85);
    Vector3 WildlingIconPos6 = new Vector3((float)-0.15 ,(float)0.01 ,(float)-8.85);

    Vector3[] WildlingPosArray = new Vector3[7];

    private GameObject RenderedWildlingIcon;

	// Use this for initialization
	void Start () {

        WildlingPosArray[0] = WildlingIconPos0;
        WildlingPosArray[1] = WildlingIconPos1;
        WildlingPosArray[2] = WildlingIconPos2;
        WildlingPosArray[3] = WildlingIconPos3;
        WildlingPosArray[4] = WildlingIconPos4;
        WildlingPosArray[5] = WildlingIconPos5;
        WildlingPosArray[6] = WildlingIconPos6;


        mySubject = GameBase.wildlingTrack;
        mySubject.DefineObserver(this);
        mySubject.InitialObserverCall();
	}

    public override void WildlingTrackValueChanged(int Value)
    {
        RenderWildlingIcon(Value);
    }

    void RenderWildlingIcon(int Value) 
    {
		Destroy(RenderedWildlingIcon);

        RenderedWildlingIcon = new GameObject();

        RenderedWildlingIcon.name = "WildlingIcon";

        RenderedWildlingIcon.AddComponent<Rigidbody>();
        RenderedWildlingIcon.GetComponent<Rigidbody>().useGravity = false;

        RenderedWildlingIcon.AddComponent<MeshRenderer>();
        RenderedWildlingIcon.GetComponent<Renderer>().castShadows = true;
        RenderedWildlingIcon.GetComponent<Renderer>().receiveShadows = true;

        RenderedWildlingIcon.AddComponent<MeshFilter>().sharedMesh = (Mesh)((GameObject)Resources.Load("Graphics/Models/Track/WildlingIcon")).GetComponent<MeshFilter>().sharedMesh;
        RenderedWildlingIcon.GetComponent<Renderer>().material = (Material)Resources.Load("Graphics/TrackMaterials/WildlingIcon");

        RenderedWildlingIcon.transform.position = WildlingPosArray[Value / 2];

        RenderedWildlingIcon.transform.rotation = Quaternion.Euler(270,0,0);
        RenderedWildlingIcon.transform.localScale = new Vector3((float)0.5,(float)0.5,(float)0.5);
    }

}
