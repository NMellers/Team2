using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class Save_Load : MonoBehaviour {

	public GUIText loaded;

	int[] varArray = { 5,1,8,4,2 };

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	void OnMouseDown () 
	{
		loadFile ();
	}

	void loadFile ()
	{
		StreamReader Load = new StreamReader(File.OpenRead("Save_File.txt"));

		string data = Load.ReadToEnd ();

		int[] dataArray = new int[data.Length];

		int counter2 = 0;

		foreach (char c in data)
		{
			string x = c.ToString();
			dataArray[counter2] = int.Parse(x);
			counter2 ++;
		}

			string loadedString = "Numbers from file: ";

			for (int i = 0; i<dataArray.Length; i++)
			{
				loadedString = loadedString + dataArray[i] + ",";
			}

			loaded.text = loadedString;
	}
}
