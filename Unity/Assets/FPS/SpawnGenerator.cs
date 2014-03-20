using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnGenerator : MonoBehaviour {
	public enum State
		{
			Idle, 
			Initialise,
			Setup,
			SpawnEnemy
		}
	public GameObject[] enemyPrefab;
	public GameObject[] spawnPoints;

	private State state;

	void Awake()
	{
		state = State.Initialise;
	}

	// Use this for initialization
	IEnumerator Start () {
		while (true) 
		{
			switch(state)
			{
			case State.Initialise:
				Initialise();
				break;
			case State.Setup:
				Setup();
				break;
			case State.SpawnEnemy:
				SpawnEnemy();
				break;
			}

			yield return 0;
		}
	}

	private void Initialise()
	{
		if (!CheckForEnemy ())
						return;
		if (!CheckForSpawn ())
						return;
			
		state = State.Setup;
		Debug.Log ("Init");
	}

	private void Setup()
	{
		GameObject[] gObs = AvailableSpawn ();
		for (int i = 0; i < gObs.Length; i++) 
		{
			GameObject go = Instantiate(enemyPrefab[Random.Range(0, 1)],
			                              gObs[i].transform.position,
			                              Quaternion.identity) as GameObject;

			go.transform.parent = gObs[i].transform;
		}
		state = State.SpawnEnemy;
		Debug.Log ("Setup");
	}

	private void SpawnEnemy()
	{
		state = State.Idle;
		Debug.Log ("SpawnEnemy");
	}

	//Check to see if we have an enemy to spawn
	private bool CheckForEnemy()
	{
		if (enemyPrefab.Length > 0)
			return true;
		else 
			return false;
	}

	//Check that there are spawn points
	private bool CheckForSpawn()
	{
		if (spawnPoints.Length > 0)
			return true;
		else 
			return false;
	}

	//Lists avaliable spawn points, that are not currently in use
	private GameObject[] AvailableSpawn()
	{
		List<GameObject> gObs = new List<GameObject> ();

		for (int i = 0; i < spawnPoints.Length; i++) 
		{
			if(spawnPoints[i].transform.childCount == 0)
			{
				gObs.Add(spawnPoints[i]);
			}
		}

		return gObs.ToArray ();
	}
}
