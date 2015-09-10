using UnityEngine;
using System.Collections;

public class HouseSelect 
{
	public Texture2D icon;
	public string House;
	public GamePlayer gp = null;

	public HouseSelect(string name) 
	{
		House = name;
		icon = (Texture2D)Resources.Load("Graphics/HouseSelectionIcons/" + name);
	}
}
