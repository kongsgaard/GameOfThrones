using UnityEngine;
using System.Collections;

public class PlayerScreen : MonoBehaviour {


	// Use this for initialization
	void Start () {

        myHouse_name = GameBase.myHouse.HouseCharacter.ToString();

        player_screen_text = GameBase.myHouse.HouseCharacter.ToString();
        powerTokenIcon = (Texture2D)Resources.Load("Graphics/PlayerScreen/PowerIcons/" + myHouse_name + "Power", typeof(Texture2D));
        unit_footman = (Texture2D)Resources.Load("Graphics/UnitTextures/" + myHouse_name + "/" + myHouse_name + "Footman", typeof(Texture2D));
        unit_knight = (Texture2D)Resources.Load("Graphics/UnitTextures/" + myHouse_name + "/" + myHouse_name + "Knight", typeof(Texture2D));
        unit_ship = (Texture2D)Resources.Load("Graphics/UnitTextures/" + myHouse_name + "/" + myHouse_name + "Ship", typeof(Texture2D));
        unit_siege = (Texture2D)Resources.Load("Graphics/UnitTextures/" + myHouse_name + "/" + myHouse_name + "Seige", typeof(Texture2D));
	}
	
	// Update is called once per frame
	void Update () {



        /*
        if (textString == "Mouse is contained!" && width < maxwidth) 
        {
            x = x - speed;
            width = width + speed;
        }
        else if (textString == "Mouse NOT contained" && width > minwidth) 
        {
            x = x + speed;
            width = width - speed;
        }*/
	}

    int speed = 10;
    int x = Screen.width-180;
    int y = 0;
    int width = 180;
    int maxwidth = 400;
    int minwidth = 180;
    int height = Screen.height;

    public Texture2D powerTokenIcon;
    public Texture2D unit_footman;
    public Texture2D unit_knight;
    public Texture2D unit_ship;
    public Texture2D unit_siege;

    public Texture2D tex;

    string myHouse_name;

    Rect guirec;
    string textString = "Test";

    private float PlayerScreenX_start = Screen.width * 0.73f;
    private float PlayerScreenY_start = Screen.height * 0.02f;
    private float PlayerScreen_width = Screen.width * 0.25f;
    private float PlayerScreen_height = Screen.height * 0.96f;

    string player_screen_text;

    void OnGUI() 
    {
        PlayerScreenRect_Proportions(0.5f, 0.03f, 0.25f, 0.067f);

        Rect PlayerScreenBox = new Rect(PlayerScreenX_start, PlayerScreenY_start, PlayerScreen_width, PlayerScreen_height);
        GUI.BeginGroup(PlayerScreenBox);
        GUI.Box(new Rect(0, 0, PlayerScreen_width, PlayerScreen_height), player_screen_text);

        /* Power tokens start */
        GUI.Label(PlayerScreenRect_Proportions(0.5f, 0.03f, 0.25f, 0.067f), "In Hand: " + GameBase.myHouse.PowerTokens );
        GUI.Label(PlayerScreenRect_Proportions(0.75f, 0.03f, 0.25f, 0.067f), "Unused: " + GameBase.myHouse.UnusedPowerTokens);
        GUI.DrawTexture(PlayerScreenRect_Proportions(0.5f, 0.05f, 0.125f, 0.067f), powerTokenIcon);
        GUI.DrawTexture(PlayerScreenRect_Proportions(0.75f, 0.05f, 0.125f, 0.067f), powerTokenIcon);
        /* ------------------ */

        /* Units start */

        GUI.Label(PlayerScreenRect_Proportions(0.115f, 0.03f, 0.25f, 0.067f), "Unused units");

        int footmanCount = 0;
        int KnightCount = 0;
        int ShipCount = 0;
        int SiegeCount = 0;
        foreach (Unit u in GameBase.myHouse.UnusedUnits) 
        {
            if (u.Type == UnitType.Footman) 
            {
                GUI.DrawTexture(PlayerScreenRect_Proportions(0, 0.05f + (0.05f*footmanCount), 0.1f, 0.05f), unit_footman);
                footmanCount++;
            }
            if (u.Type == UnitType.Knight)
            {
                GUI.DrawTexture(PlayerScreenRect_Proportions(0.1f, 0.05f + (0.05f * KnightCount), 0.1f, 0.05f), unit_knight);
                KnightCount++;
            }
            if (u.Type == UnitType.Ship)
            {
                GUI.DrawTexture(PlayerScreenRect_Proportions(0.2f, 0.05f + (0.05f * ShipCount), 0.1f, 0.05f), unit_ship);
                ShipCount++;
            }
            if (u.Type == UnitType.SiegeTower)
            {
                GUI.DrawTexture(PlayerScreenRect_Proportions(0.3f, 0.05f + (0.05f * SiegeCount), 0.1f, 0.05f), unit_siege);
                SiegeCount++;
            }
        }

        


        /* ----------- */

        GUI.EndGroup();

        
        /*
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
         * */
    }

    public Rect PlayerScreenRect_Proportions(float x_start, float y_start, float width, float height) 
    {
        return new Rect(new Rect(PlayerScreen_width * x_start, PlayerScreen_height * y_start, PlayerScreen_width * width, PlayerScreen_height * height));
    }
}
