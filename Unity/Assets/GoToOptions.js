#pragma strict

var guiEnable : boolean = false;

function Start () {

}

function Update () {
	AudioListener.volume = hSliderValue/10.0;
	if (Input.GetKey ("p"))
	{
		guiEnable = true;
	}
}

var hSliderValue : float = 0.0;

function OnGUI()
{	
	if (guiEnable == true)
	{
	//GUI.Label(new Rect(550,70,5,5), "Volume: ");
	GUI.Box (Rect (400,10,500,200), "Options");
	
	//Volume Slider
	GUI.Label(Rect (625,50,500,200), "Volume");
	hSliderValue = GUI.HorizontalSlider (Rect (550, 75, 200, 30), hSliderValue, 0.0, 1000.0);
	
	if (GUI.Button (Rect (600,100,100,30), "Back to Game")) 
	{
		guiEnable = false;
	}
	
	if (GUI.Button(Rect(600,140,100,30),"Exit Game"))
	{
		Application.Quit();
	}
	}
			
}