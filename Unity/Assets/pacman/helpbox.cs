using UnityEngine;
using System.Collections;

public class helpbox : MonoBehaviour {

	public int boxHeight = 100;
	public int boxWidth = 100;
	public int Height = 0;
	public int Width = 0;


	//help box on screen
	void OnGUI ()
	{
		// background box for text
		GUI.Box(new Rect( ((Screen.width-boxWidth)/2),((Screen.height-boxHeight)/2), boxWidth, boxHeight), "PukMan! \n collect coins \n WASD to move");
		
		// makes start game button. LoadLevel 1 (when creating full build code will have to be changed for each load screen (make sure each mini game scene loaded to build)
		if(GUI.Button(new Rect(((Screen.width/2)-40),(((Screen.height/2)+(boxHeight/2))-20),80,20), "Start Game"))
		   {
			Application.LoadLevel("pacman mini game");
			}
	}
}
