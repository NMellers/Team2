using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public int money = 56;
	public int pageviews = 24;

	void Start () {
		
	}
	
	void Update () {
		
	}
	
	void OnGUI()
	{
		{
			GUI.Label(new Rect(0,0,Screen.width,Screen.height),"Money:" + money + "\nPageViews:" + pageviews);
		}
	}
}
