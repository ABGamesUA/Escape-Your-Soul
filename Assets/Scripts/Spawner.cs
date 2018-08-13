using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] spawnPoints;
	public GameObject obstacle;
	public float timeToSpawn = 2f;
	public float timeBWWawes = 3f;
	public float increment = 0.005f;
	
		
	// Update is called once per frame
	void Update () {
		timeToSpawn -= Time.deltaTime;
		if(timeBWWawes <= 0.75f) increment = 0;
		if(timeToSpawn <= 0)
		{
			int random = Random.Range(0, spawnPoints.Length);
			for (int i = 0; i < spawnPoints.Length; i++)
			{
				if(i != random)
				{
					Instantiate(obstacle, spawnPoints[i].transform.position, Quaternion.identity);
				}
			}
			timeBWWawes -= increment;
			timeToSpawn = timeBWWawes;
		}
		
	}
}
