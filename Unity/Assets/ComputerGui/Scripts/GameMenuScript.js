var noMenu : Sprite;
var menuSprite : Sprite;

function Start () {

}

function Update () 
{

	if(GamesIconScript.gameMenu == true)
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