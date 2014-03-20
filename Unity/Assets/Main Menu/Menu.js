#pragma strict

function Start () {

}

function Update () {

}

function OnGUI () {
	// Make a background box
	GUI.Box (Rect (400,10,500,120), "Game Jouralism Story");

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (410,40,480,20), "Play")) {
		Application.LoadLevel (1);
	}

	// Make the second button.
	if (GUI.Button (Rect (410,70,480,20), "Load Game")) {
	}
}
