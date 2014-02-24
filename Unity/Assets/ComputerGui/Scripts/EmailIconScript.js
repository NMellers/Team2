var noSprite : Sprite;
var gameSprite : Sprite;
public static var emailMenu = false;

function Start () {

}

function Update () 
{
	if(ComputerClickScript.ToggleMenu == true)
	{
		GetComponent(SpriteRenderer).sprite = gameSprite;
	}
	
	if(ComputerClickScript.ToggleMenu == false)
	{
		GetComponent(SpriteRenderer).sprite = noSprite;
	}
}

function OnMouseDown()
{
	emailMenu = true;
}