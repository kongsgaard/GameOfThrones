using UnityEngine;
using System.Collections;

public class MouseOver_TransTerri : MonoBehaviour
{



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void test1()
    {
        foreach (Territory T in GameBase.myHouse.OwnedTerritories)
        {
            GameObject obj = GameObject.Find(T.Name + "Trans");

            obj.GetComponent<Renderer>().sharedMaterial = (Material)Resources.Load("Materials/Trans" + GameBase.myHouse.HouseCharacter.ToString());
        }
    }

   /*
    void OnMouseEnter() 
    {
        foreach (Territory T in GameBase.myHouse.OwnedTerritories) 
        {
            GameObject obj = GameObject.Find(T.Name + "Trans");

            obj.renderer.sharedMaterial = (Material)Resources.Load("Materials/Trans" + GameBase.myHouse.HouseCharacter.ToString());
        }
    }

    void OnMouseExit() 
    {
        foreach (Territory T in GameBase.myHouse.OwnedTerritories)
        {
            GameObject obj = GameObject.Find(T.Name + "Trans");
            obj.renderer.sharedMaterial = (Material)Resources.Load("Materials/TransInvis");
        }
    } */
}
