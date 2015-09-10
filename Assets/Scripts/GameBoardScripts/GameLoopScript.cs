using UnityEngine;
using System.Collections;

public enum GamePhase { PlacingOrders, MovingOrders, DrawingCards }

public class GameLoopScript : MonoBehaviour {

    public GamePhase currentPhase;

    public bool allOrdersPlaced;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (currentPhase == GamePhase.PlacingOrders) 
        {
        
        }

	}

    void PlacingOrdersPhase() 
    {
        if (!allOrdersPlaced)
        {
            return;
        }
        else 
        {
            currentPhase = GamePhase.MovingOrders;
        }
    }



}
