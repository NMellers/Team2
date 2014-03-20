var noMenu : Sprite;
var menuSprite : Sprite;

function Start () {

}

function Update () 
{

	if(EmailIconScript.emailMenu == true)
	{
		//then sprite = menuSprite
		GetComponent(SpriteRenderer).sprite = menuSprite;
	}
	else
	{
		//sprite = noMenu
		GetComponent(SpriteRenderer).sprite = noMenu;
	}

}