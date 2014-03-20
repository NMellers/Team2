using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class Save : MonoBehaviour {

	HUD score;

	string commandBlock;

	// Use this for initialization
	void Start () 
	{
		score = GameObject.FindGameObjectWithTag ("HUD").gameObject.GetComponent<HUD>();
	}
	
	// Update is called once per frame
	void Update () {}

	void OnMouseDown () 
	{
		saveFile ();
	}

	void saveFile ()
	{
		StreamWriter Save = new StreamWriter ("Save_File.txt");

		int[] varArray = new int[2];
		int[] varLengthArray = new int[varArray.Length];
		int[] spacerLengthArray = new int[varArray.Length + 1];

		for (int i = 0; i < spacerLengthArray.Length; i++)
		{
			spacerLengthArray[i] = UnityEngine.Random.Range(1,9);
		}

		//varArray [0] = score.money;
		//varArray [1] = score.pageviews;

		commandBlock = varArray.Length + spacerLengthArray[0].ToString();

		int counter = 0;

		foreach (int  x in varArray)
		{
			varLengthArray[counter] = x.ToString().Length;


			commandBlock = commandBlock + varLengthArray[counter].ToString() + spacerLengthArray[counter + 1].ToString() ; 

			counter++;
		}

		Save.Write(commandBlock);

		for (int i = 0; i < spacerLengthArray[0]; i++)
		{
			int r = UnityEngine.Random.Range(1,9);

			Save.Write(r);
		}

		for (int i = 0; i < varArray.Length;i++)
		{
			Save.Write(varArray[i]);

			for (int j = 0; j < spacerLengthArray[i+1]; j++)
			{
				int r = UnityEngine.Random.Range(1,9);
				
				Save.Write(r);
			}
		}

		Save.Close();
	}
}	