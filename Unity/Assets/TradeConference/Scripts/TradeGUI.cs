using UnityEngine;
using System.Collections;

public class TradeGUI : MonoBehaviour {

	int TimeSlots;

	// Use this for initialization
	void Start () 
	{
		TimeSlots = 8;
	}
	
	public void ModifyTime(int TimeMod)
	{
		TimeSlots += TimeMod;
	}


	void OnGUI()
	{
		GUI.Label(new Rect(10,10,300,50), "Hours Left: " + TimeSlots.ToString());
	}
}
