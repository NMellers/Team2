using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	// Use this for initialization
	public float destroyBullet=2;
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, destroyBullet);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "player")
		{
						Destroy (other.gameObject);
						Destroy (gameObject);
			//Debug.Log ("YOU GOT HIT");		
			Application.LoadLevel("office");
		}
	}

}