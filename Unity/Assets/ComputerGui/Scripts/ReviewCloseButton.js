var noSprite : Sprite;
var closeSprite : Sprite;

function Start () {

}

function Update () 
{
	if(ReviewButtonScript.review == true)
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
	ReviewButtonScript.review = false;
}