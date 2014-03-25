using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	GameObject TargetPlayer;

	// Use this for initialization
	void Start () 
	{
		TargetPlayer = GameObject.Find("PlayerSprite");	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(TargetPlayer.transform.position.x < (transform.position.x - 0.7f))
		{
			transform.position = Vector3.Lerp(transform.position, TargetPlayer.transform.position + (new Vector3(0.7f, 0.0f,0.0f)), 0.5f);
			Vector3 CameraReset = transform.position;
			CameraReset.y = 0.5f;
			CameraReset.z = -10.0f;
			transform.position = CameraReset;
		}
		if(TargetPlayer.transform.position.x > (transform.position.x + 0.7f))
		{
			transform.position = Vector3.Lerp(transform.position, TargetPlayer.transform.position - (new Vector3(0.7f, 0.0f,0.0f)), 0.5f);
			Vector3 CameraReset = transform.position;
			CameraReset.y = 0.5f;
			CameraReset.z = -10.0f;
			transform.position = CameraReset;
		}
	}
}
