using UnityEngine;
using System.Collections;

public class StartGameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

    public void startGameLoop() 
    {
        GameObject GameLoop = new GameObject();

        GameLoop.AddComponent<GameLoopScript>();

        GameLoop.name = "GameLoopObject";
    }

}
