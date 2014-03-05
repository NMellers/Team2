using UnityEngine;
using System.Collections;

public class OffScreen : MonoBehaviour {

	public float playerLeft =-6;
	public float playerRight =6;
	
	// Update is called once per frame
	void Update () {
	if(rigidbody.position.x<=playerLeft||rigidbody.position.x>=playerRight)
		{
			Vector3 pos = rigidbody.position;
			pos.x=Mathf.Clamp(pos.x,playerLeft,playerRight);
			rigidbody.position=pos;
	}
}
}