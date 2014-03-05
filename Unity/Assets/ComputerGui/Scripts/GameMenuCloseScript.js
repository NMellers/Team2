var noSprite : Sprite;
var closeSprite : Sprite;

function Start () {

}

function Update () 
{
	if(GamesIconScript.gameMenu == true)
	{
		//then sprite = menuSprite
		GetComponent(SpriteRenderer).sprite = closeSprite;
	}
	else
	{
		//sprite = noMenu
		GetComponent(SpriteRenderer).sprite = noSprite;
	}
}

function OnMouseDown()
{
	GamesIconScript.gameMenu = false;
}