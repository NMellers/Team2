#pragma strict
private var money : int = 7;
private var pageviews : int = 1000;

function Start () {

}

function Update () {

}

function OnGUI()
{
    {
    	GUI.Label(Rect(0,0,Screen.width,Screen.height),"Money:" + money + "\nPageViews:" + pageviews);
    }
}