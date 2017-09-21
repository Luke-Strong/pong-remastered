using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 6.75f;
	Vector3 targetPos;
	Vector3 playerPos;
	GameObject ballObj;

	public AudioClip enemyBlip2;
	public AudioSource SFXSource;
	void Update () 
	{

		ballObj = GameObject.FindGameObjectWithTag ("Ball");

		if (ballObj != null) {
			targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
			playerPos = new Vector3 (-20, Mathf.Clamp (targetPos.y, -12.5f, 12.5f), 0);
			gameObject.transform.position = new Vector3 (22, playerPos.y, 0); 
		}

	}

	void OnTriggerEnter (Collider other)
	{
		SFXSource.clip = enemyBlip2;
		SFXSource.Play ();
	}
}
