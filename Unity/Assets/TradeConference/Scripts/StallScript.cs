using UnityEngine;
using System.Collections;

public class StallScript : MonoBehaviour {

	bool MessageActive;

	// Use this for initialization
	void Start () 
	{
		MessageActive = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if(MessageActive == false)
		{
			MessageActive = true;
		}
	}

	void OnGUI()
	{
		if(MessageActive)
		{
			GUI.Box(new Rect((Screen.width / 2) - 150.0f, 300.0f, 300.0f, 110.0f), "Preview " + gameObject.name + "?");
			if(GUI.Button (new Rect((Screen.width / 2) - 140.0f, 330.0f, 135.0f, 70.0f), "Yes"))
			{
				MessageActive = false;
				Camera.main.GetComponent<TradeGUI>().ModifyTime(-2);
			}
			if(GUI.Button (new Rect((Screen.width / 2) + 5.0f, 330.0f, 135.0f, 70.0f), "Nah"))
			{
				MessageActive = false;
			}
		}
	}

}
