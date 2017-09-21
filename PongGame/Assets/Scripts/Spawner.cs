using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	int RandX;
	int RandY;

	public GameObject ball;

	void Start () {
		Spawn ();
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(0) ) {
			Spawn();
		}
	}

			void CreateRandomPosition()
	{
		RandX = Random.Range (-8, 8);
		RandY = Random.Range (-4, 4);

	}
	void Spawn()
	{
		CreateRandomPosition ();

		Instantiate (ball, new Vector3 (RandX, RandY, 0), Quaternion.identity);

	}
}

