#pragma strict

var score = 0;
var scoreText = "Score: 0";
var mySkin : GUISkin;

function OnTriggerEnter( other : Collider) {
	if (other.tag == "Coin"){
	score+= 1;
	scoreText = "Score: " + score;
	Debug.Log(score);
	Destroy(other.gameObject);	
	}
}

function OnGUI () {
	GUI.skin = mySkin;
	GUI.Label(Rect (10, 10, 500, 200), scoreText.ToString());
	}