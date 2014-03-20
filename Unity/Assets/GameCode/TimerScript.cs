//Script needs more messages given to user, aswell as other variables such as gender and company standing
//taken into account, as of first draft, these variables are yet to exist.

using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour
{
	public static bool active = false;
	//Based on feedback given from the review of the game, lower score worst comments,
	//top score good company feedback and sellout mentions etc.
	//By Default variable set to 5, based on feedback from minigame review.
	public int feedback=10;
	public int timerFeedback = 0;
	public bool timerFeedbackStarted = true;
	public GUIStyle customGui;

	void Update()
	{
		//feedback displayed based on a timer so the feedback 
		if (timerFeedbackStarted == false)
			timerFeedbackStarted = true;
		if (timerFeedbackStarted)
			timerFeedback += 1;

	}
	
	void OnGUI()
	{
		if (active == true)
		{
		
		customGui.fontSize = 24;
		customGui.wordWrap = true;
		customGui.normal.textColor = Color.black;
		feedback = 10;

		//Average Score Feedback and feedback can be randomly taken from an array.
			if (timerFeedback >= 200 & timerFeedback <= 500 & feedback >= 4 & feedback <= 7){
						GUI.Box (new Rect (100, 250, 300, 50), "'Average Feedback Here!'", customGui);
			if(timerFeedback>=500)
							timerFeedback=0;

		}
		////Poor Score Feedback and feedback can be randomly taken from an array.
		if (timerFeedback >= 200 & timerFeedback <= 500 & feedback <= 3) {
			GUI.Box (new Rect (100, 250, 300, 50), "'Bad Feedback Here!'", customGui);
						if (timerFeedback >= 500)
								timerFeedback = 0;
				}
		////Good Score Feedback and feedback can be randomly taken from an array.
		if (timerFeedback >= 200 & timerFeedback <= 500 & feedback >= 8) {
			GUI.Box (new Rect (100, 250, 300, 50), "'Good Feedback Here!' (Sellout!)", customGui);
		if (timerFeedback >= 500)
				timerFeedback = 0;
		}

		}
	}
}