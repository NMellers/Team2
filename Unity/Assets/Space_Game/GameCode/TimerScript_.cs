using UnityEngine;
using System.Collections;

public class TimerScript_ : MonoBehaviour
{
	
	public int timer = 120;
	public int textTimer=15;
	public bool timerStarted = true;
	void Update()
	{
		timerStarted = true;
			if( timerStarted == false )
				timerStarted = true;

		
		if( timerStarted )

			timer -= 1;
		if (timer <= 0) {
			textTimer-=1;
			timer = 120;
				}

		if (textTimer <= 0) {
			Application.LoadLevel("1");
				}
	}
	
	void OnGUI()
	{
		GUI.Label( new Rect( 300, 0, 120, 50 ), "Timer: " +textTimer);
	}
	
}