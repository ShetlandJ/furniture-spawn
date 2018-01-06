﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject chairPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Vector3 randomSpawnPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
			Vector3 randomSpawnRotation = Vector3.up * Random.Range (0, 360);

			GameObject newChair = (GameObject) Instantiate(chairPrefab, randomSpawnPosition, Quaternion.Euler(randomSpawnRotation));
			newChair.transform.parent = transform;
		}
	}
}
