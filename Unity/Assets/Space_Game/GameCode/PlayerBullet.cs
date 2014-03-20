using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {
	// Use this for initialization
	public float destroyBullet=2;
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, destroyBullet);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "enemy") {
						Destroy (other.gameObject);
						Destroy (gameObject);
			//Debug.Log ("HIT");
				}

	}


}
