using UnityEngine;
using System.Collections;

public class ComputerScript : MonoBehaviour {

	//Creates a computer GUI prefab
	public GameObject ComputerGui; 
	public bool computerOn = false;

	// Use this for initialization
	void Start () 
	{
		ComputerGui = GameObject.Find ("ComputerGui");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//OnMouseDown ();
	}
	
	void OnMouseDown()
	{
		if (Input.GetMouseButtonDown (0) && computerOn == false) 
		{
			ComputerGui.transform.position = new Vector2(0f, 1f);
			computerOn = true;

			Application.LoadLevel("1");
		}
		else if (Input.GetMouseButton (0) && computerOn == true)
		{
			ComputerGui.transform.position = new Vector2(0f, 11f);
			computerOn = false;
		}
	}
}
