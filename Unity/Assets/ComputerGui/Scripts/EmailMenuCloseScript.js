var noSprite : Sprite;
var closeSprite : Sprite;

function Start () {

}

function Update () 
{
	if(EmailIconScript.emailMenu == true)
	{
		//then sprite = menuSprite
		GetComponent(SpriteRenderer).sprite = closeSprite;
	}
	if(EmailIconScript.emailMenu == false)
	{
		//sprite = noMenu
		GetComponent(SpriteRenderer).sprite = noSprite;
	}
}

function OnMouseDown()
{
	EmailIconScript.emailMenu = false;
}