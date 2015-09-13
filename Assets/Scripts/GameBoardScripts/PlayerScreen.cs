using UnityEngine;
using System.Collections;

public class PlayerScreen : MonoBehaviour {


	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {
        if (textString == "Mouse is contained!" && width < maxwidth) 
        {
            x = x - speed;
            width = width + speed;
        }
        else if (textString == "Mouse NOT contained" && width > minwidth) 
        {
            x = x + speed;
            width = width - speed;
        }
	}

    int speed = 10;
    int x = Screen.width-180;
    int y = 0;
    int width = 180;
    int maxwidth = 400;
    int minwidth = 180;
    int height = Screen.height;
    

    public Texture2D tex;

    Rect guirec;
    string textString = "Test";


    void OnGUI() 
    {


        guirec = new Rect(x, y, width, height);


        GUI.BeginGroup(guirec);
        GUI.Label(new Rect(0,0,200,100), "Overall box!!");
        GUI.Box(new Rect(0,50,100,100), "First rec");
        GUI.Box(new Rect(100, 50, 100, 100), "Second rec");
        GUI.EndGroup();

        //GUI.Box(guirec, textString);

        if (guirec.Contains(Event.current.mousePosition))
        {
            textString = "Mouse is contained!";
        }
        else 
        {
            textString = "Mouse NOT contained";
        }
    }
}
