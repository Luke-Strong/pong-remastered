using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : MonoBehaviour {

	public float ballVelocity;
	Rigidbody rb; 

	int rand;

	void Awake () 
	{
	    rand = Random.Range(0, 4); //Initial direction
		ballVelocity = Random.Range(250, 351); //Initial power
		rb = gameObject.GetComponent<Rigidbody> ();

		if (rand == 0)
			rb.AddForce (new Vector3 (ballVelocity, ballVelocity, 0));
		else if (rand == 1)
			rb.AddForce (new Vector3 (-ballVelocity, ballVelocity, 0));
		else if (rand == 2)
			rb.AddForce (new Vector3 (-ballVelocity, -ballVelocity, 0));
		else if (rand == 3)
			rb.AddForce (new Vector3 (ballVelocity, -ballVelocity, 0));



	}

	void Update ()
	{

	
	}

	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "EnemyWall") {
			Destroy (gameObject);
			PlayerScore.playerPoints += 1;
		
		} else if (other.tag == "PlayerWall") {
			Destroy (gameObject);
			EnemyScore.enemyPoints += 1;


		}
	
	}

}