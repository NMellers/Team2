using UnityEngine;
using System.Collections;

public class toSpaceGame : MonoBehaviour {
	public static bool playedOnce = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if (playedOnce == false) 
		{
			HUD.playerMoney -= 10;
			playedOnce = true;
		}
		Application.LoadLevel("intro_Space");
	}
}
