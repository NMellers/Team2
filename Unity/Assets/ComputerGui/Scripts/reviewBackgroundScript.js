var noSprite : Sprite;
var menuSprite: Sprite;


function Start () 
{

}

function Update () 
{
	if(ReviewButtonScript.review == true)
	{
		GetComponent(SpriteRenderer).sprite = menuSprite;
	}
	else
	{
		GetComponent(SpriteRenderer).sprite = noSprite;
	}

}