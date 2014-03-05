using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
	
	public Transform player;
	public Rigidbody playerBody;
	public GUIText timer;

	public int remainingTime = 10;
	public int counter = 120;

	public float speed = 3f;
	public int jumpDelay = 120;
	private int currentDelay = 0;

	void Start () {}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			player.localScale = new Vector3 (-1, 1, 0);
			if (player.transform.position.x > -8.7)	{player.transform.Translate(new Vector3 (-1.0f*speed,0.0f,0.0f));}
		}
		
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			player.localScale = new Vector3 (1, 1, 0);
			if (player.transform.position.x < 8.7)	{player.transform.Translate(new Vector3 (1.0f*speed,0.0f,0.0f));}
		}

		if (Input.GetKey (KeyCode.Space)) 
		{
			if (currentDelay == 0) {playerBody.AddForce(new Vector3 (0.0f,300.0f,0.0f)); currentDelay = jumpDelay;}
		}

		if (currentDelay != 0) {currentDelay -- ;}

		if (remainingTime != 0) {UpdateTimer ();}

		else if(remainingTime == 0)
		{
			Application.LoadLevel("1");
		}
	}
	

	void UpdateTimer()
	{
		if (counter == 0) { remainingTime --; counter = 120;}

		counter --;

		timer.text = "Remaining Time: " + remainingTime + "s";
	}
}