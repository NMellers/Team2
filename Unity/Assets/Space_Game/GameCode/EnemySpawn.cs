using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	
	float startPos;
	float endPos;
	
	public float unitsToMove = 6;
	public int moveSpeed=5;
	bool moveRight = true;
	
	// Update is called once per frame
	void awake ()
	{
		startPos = transform.position.x;
		endPos = startPos + unitsToMove;
	}
	void Update ()
	{
		if (moveRight) {
			rigidbody.position += Vector3.right * moveSpeed * Time.deltaTime;
		}
		else
		{
			rigidbody.position += Vector3.left * moveSpeed *Time.deltaTime;
		}
		if (rigidbody.position.x >= endPos + 6)
		{
			moveRight = false;
		}
		if (rigidbody.position.x <= startPos - 6) {
			moveRight=true;
		}
		rigidbody.position += Vector3.down * moveSpeed * Time.deltaTime;
	}
}
