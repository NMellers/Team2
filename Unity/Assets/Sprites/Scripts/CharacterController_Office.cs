using UnityEngine;
using System.Collections;

public class CharacterController_Office : MonoBehaviour {

	public float speed = 5;
	bool faceRight = true;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2 (move * speed, rigidbody2D.velocity.y);

		if (move > 0 && !faceRight)
					flip ();
		else if (move < 0 && faceRight)
					flip ();

	}

	//Will flip the sprite depending on the way it is facing
	void flip()
	{
		faceRight = !faceRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
