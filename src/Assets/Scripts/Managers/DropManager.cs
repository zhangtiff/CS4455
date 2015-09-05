﻿using UnityEngine;

public class DropManager : MonoBehaviour
{
	public GameObject drop;
	public float spawnTime = 10.0f;
	public Transform[] spawnPoints;
	
	GameObject[] spawn;
	
	
	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		spawn = new GameObject[spawnPoints.Length];
		Spawn ();
		transform.position += new Vector3(0, 1.0f, 0);
	}
	
	
	void Spawn ()
	{
		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (spawn[i] == null) 
			{
				Transform p = spawnPoints[i];
				spawn[i] = (GameObject) Instantiate (drop, p.position, p.rotation);
			}
		}
	}
}
