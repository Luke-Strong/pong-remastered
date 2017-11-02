using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : MonoBehaviour {

	public float ballVelocity;
	Rigidbody rb; 
	bool isColliding = false;

	int rand;

	void Awake () 
	{
	   
		ballVelocity = Random.Range (13, 20); //Constant velocity of ball

		rb = gameObject.GetComponent<Rigidbody> ();

		//Initial direction
		rand = Random.Range(0, 4); 
		if (rand == 0)
			rb.AddForce (new Vector3 (1000, 1000, 0));
		else if (rand == 1)
			rb.AddForce (new Vector3 (-1000, 1000, 0));
		else if (rand == 2)
			rb.AddForce (new Vector3 (-1000, -1000, 0));
		else if (rand == 3)
			rb.AddForce (new Vector3 (1000, -1000, 0));



	}

	void Update ()
	{
		Vector3 unit = GetComponent<Rigidbody>().velocity.normalized;
		GetComponent<Rigidbody>().velocity = unit * ballVelocity;

		isColliding = false; //Resets collision boolean to 'false'.

	}

	void OnTriggerEnter (Collider other) 
	{

		if (isColliding)
			return; //Break out of collision logic if already collided.
		
		isColliding = true;

		if (other.tag == "EnemyWall") {
			Destroy (gameObject);
			PlayerScore.playerPoints += 1;
		
		} else if (other.tag == "PlayerWall") {
			Destroy (gameObject);
			EnemyScore.enemyPoints += 1;


		}
	
	}

}