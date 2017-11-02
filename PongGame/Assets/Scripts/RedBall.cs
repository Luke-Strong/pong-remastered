using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : MonoBehaviour {

	public float ballVelocity = 1000;
	Rigidbody rb;
	int rand;
	bool isColliding = false;
	int bounce = 0; //How many times has the red ball bounced off a border?
	void Awake () 
	{

		rb = gameObject.GetComponent<Rigidbody> ();
	    rand = Random.Range(0, 4);

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
		isColliding = false;

		Vector3 unit = GetComponent<Rigidbody>().velocity.normalized;
		GetComponent<Rigidbody>().velocity = unit * 22;
	}

	void OnTriggerEnter (Collider other) 
	{
		

		if (other.tag == "Wall")
			bounce++;
		if (bounce >= 7)
			Destroy (gameObject);

		if (isColliding) return;
		isColliding = true;
		if (other.tag == "Paddle") {
			Destroy (gameObject);
			PlayerScore.redBallHit = true;
			if (PlayerScore.playerPoints > 0) {
				PlayerScore.playerPoints -= 1;
			}
		}

		}

}





