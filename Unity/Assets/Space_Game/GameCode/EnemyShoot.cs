using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
	public Rigidbody bulletPrefab;
	float coolDown;
	
	//public float yValue =-.75f;
	public int yValue =-1;
	// Update is called once per frame
	void Update ()
	{
		if (Time.time >= coolDown) 
		{
			{
				Fire();
			}
		}
	}
	void Fire()
	{
		//Rigidbody bPrefab= Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody;
		Rigidbody bPrefab = Instantiate (bulletPrefab, new Vector3 (transform.position.x, transform.position.y + yValue, transform.position.z), Quaternion.identity) as Rigidbody;
		bPrefab.rigidbody.AddForce (Vector3.down * 250);
		coolDown =Time.time + Random.Range (2,6);
	}

}
