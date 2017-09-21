﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballVelocity = 1300;
    Rigidbody rb;
	bool isPlay = false;
	int randInt;

	void Awake () 
	{
		rb = gameObject.GetComponent<Rigidbody> ();
		randInt = Random.Range (1, 3);
	}
	
	void Update ()
	{

		if ( (Input.GetMouseButton (0) == true || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
			&& isPlay == false && gameObject.transform.position.x == -20) {

			transform.parent = null;
			isPlay = true;

			if(randInt == 1)
			{
				rb.AddForce (new Vector3 (ballVelocity, ballVelocity, 0));
			}

			if (randInt == 2) {
				rb.AddForce (new Vector3 (ballVelocity, -ballVelocity, 0));
			}
		}

		if (gameObject.transform.position.x != -20)
			transform.parent = null;
		
		Vector3 unit = GetComponent<Rigidbody>().velocity.normalized;
		GetComponent<Rigidbody>().velocity = unit * 45;

	}



}
