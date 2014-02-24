using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public int playerSpeed =5; 
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.RightArrow)== true)
			{
			rigidbody.position += Vector3.right * playerSpeed * Time.deltaTime;
			}
		if (Input.GetKey (KeyCode.LeftArrow) == true)
		{
			rigidbody.position += Vector3.left * playerSpeed * Time.deltaTime;
		}
	}
}
