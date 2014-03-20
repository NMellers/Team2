var noSprite : Sprite;
var gameSprite : Sprite;
public static var emailMenu = false;

function Start () {

}

function Update () 
{

	if(ComputerClickScript.ToggleMenu == true)
		{
			//then sprite = menuSprite
			GetComponent(SpriteRenderer).sprite = gameSprite;
		}
	else
		{
			//sprite = noMenu
			GetComponent(SpriteRenderer).sprite = noSprite;
		}
		
}

function OnMouseDown()
{
	emailMenu = true;
}