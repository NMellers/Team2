using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	public Rigidbody bulletPrefab;
	float attackSpeed=.5f;
	float coolDown;

	//public float yValue =.1f;
	public int yValue =1;
	// Update is called once per frame
	void Update ()
	{
	if (Time.time >= coolDown) 
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				Fire();
			}
		}
	}
	void Fire()
	{
		//Rigidbody bPrefab= Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody;
		Rigidbody bPrefab = Instantiate (bulletPrefab, new Vector3 (transform.position.x, transform.position.y+ yValue , transform.position.z), Quaternion.identity) as Rigidbody;
		bPrefab.rigidbody.AddForce (Vector3.up * 250);
			coolDown =Time.time + attackSpeed;
	}

}
