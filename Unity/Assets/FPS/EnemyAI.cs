using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public bool active = true;
	float endPos;

	// Use this for initialization
	void Awake () 
	{
		endPos = transform.position.y + 20;
	}
	
	// Update is called once per frame
	void Update () {
		OnMouseDown ();

		if (transform.position.y < endPos && active) 
		{
			MoveObject();
		}
	}

	void MoveObject()
	{
		transform.Translate(Vector2.up * 2 * Time.deltaTime);
	}

	void OnMouseDown()
	{
		Destroy (this);
	}
}
