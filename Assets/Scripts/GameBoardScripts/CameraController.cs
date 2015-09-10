using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    float currentPosition = 0;

    //These are inverted.. Bottom is positive, and top is negative.
    float maxTopPosition = -1f;
    float maxBottomPosition = 2f;

	float CameraSensitivity = 2f;


    void Update() 
    {
        //HorizontalMovement();
    }

    void HorizontalMovement()
    {
        float camMoveHori = -Input.GetAxis("Mouse ScrollWheel");

        if (camMoveHori < 0 && currentPosition > maxTopPosition) 
        {
            camMoveHori = -0.5f;
            Vector3 HoriMove = new Vector3(0, 0, CameraSensitivity * camMoveHori);
            currentPosition = currentPosition + camMoveHori;
            CharacterController cc = GetComponent<CharacterController>();

            cc.Move(HoriMove);
        }
        else if (camMoveHori > 0 && currentPosition < maxBottomPosition)
        {
            camMoveHori = 0.5f;
            Vector3 HoriMove = new Vector3(0, 0, CameraSensitivity * camMoveHori);
            currentPosition = currentPosition + camMoveHori;
            CharacterController cc = GetComponent<CharacterController>();

            cc.Move(HoriMove);
        }


    }

    void VerticalMovement()
    {
        float camMoveVerti = Input.GetAxis("Vertical");

        Vector3 VertiMove = new Vector3(-CameraSensitivity * camMoveVerti, 0, 0);

        CharacterController cc = GetComponent<CharacterController>();

        //VertiMove = Quaternion.Euler(0, tiltAroundX, 0) * VertiMove;

        cc.Move(VertiMove);
    }

    /*
	// Update is called once per frame
	void Update () {



		ZoomMovement ();

		if (Input.GetKey ("left shift")) 
		{
			RotateCam ();
		} 
		else 
		{
			VerticalMovement ();
			HorizontalMovement ();
		}	
	}

	private float tiltAroundX = 0f;
	private float tiltAroundZ = 0f;

	void RotateCam()
	{
			tiltAroundX = tiltAroundX + Input.GetAxis("Horizontal");
			tiltAroundZ = tiltAroundZ + Input.GetAxis("Vertical");
			Quaternion target = Quaternion.Euler(0, tiltAroundX, tiltAroundZ);
			transform.rotation = target;
	}

	float ZoomAmount = 0;
	float MaxZoom = 13;

	void ZoomMovement()
	{
		CharacterController cc = GetComponent<CharacterController> ();

		ZoomAmount += Input.GetAxis("Mouse ScrollWheel");
		ZoomAmount = Mathf.Clamp (ZoomAmount, -MaxZoom, MaxZoom);
		float ActualZoom = Mathf.Min (Mathf.Abs (Input.GetAxis ("Mouse ScrollWheel")), MaxZoom - Mathf.Abs (ZoomAmount));

		cc.transform.Translate(0,-ActualZoom * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel")),0);
	}


	void HorizontalMovement()
	{
		float camMoveHori = Input.GetAxis("Horizontal");
		
		Vector3 HoriMove = new Vector3 (0, 0, CameraSensitivity * camMoveHori);

		HoriMove = Quaternion.Euler(0, tiltAroundX, 0) * HoriMove;



		CharacterController cc = GetComponent<CharacterController> ();
		
		cc.Move (HoriMove);
	}

	void VerticalMovement()
	{
		float camMoveVerti = Input.GetAxis("Vertical");
		
		Vector3 VertiMove = new Vector3 (-CameraSensitivity * camMoveVerti, 0, 0);
		
		CharacterController cc = GetComponent<CharacterController> ();

		VertiMove = Quaternion.Euler(0, tiltAroundX, 0) * VertiMove;

		cc.Move (VertiMove);
	}



    */



}
