var noMenu : Sprite;
var menu : Sprite;

function Start () {

}

function Update ()
{
	if(EmailIconScript.emailMenu == true)
	{
		GetComponent(SpriteRenderer).sprite = menu;
	}
	if(EmailIconScript.emailMenu == false)
	{
		GetComponent(SpriteRenderer).sprite = noMenu;
	}
	
}

function OnGUI()
{
    if(EmailIconScript.emailMenu == true)
    {
    	GUI.Label(Rect(900,400,Screen.width,Screen.height),"EMAIL\nEMAIL\nEMAIL");
    }
}