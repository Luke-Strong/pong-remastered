using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballVelocity = 1300;
    public Rigidbody rb;
	bool isPlay = false;
	int randInt;

	void Awake () 
	{
		rb = gameObject.GetComponent<Rigidbody> ();
		randInt = Random.Range (1, 3);
	}
	
	void Update ()
	{

		//White Ball will not interact with other objects whilst it is on its home axis (i.e. x = -20
		//or whilst the user has not started the point.
		if (gameObject.transform.position.x == -20 && isPlay == false)
			rb.isKinematic = true;
		
		if ( (((Input.GetKeyDown(KeyCode.Mouse0) == true || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)))
			&& isPlay == false)) {

			rb.isKinematic = false; //Ball now interacts with the other balls in motion.

			transform.parent = null; //Ball is no longer 'tethered' to Paddle parent object.

			isPlay = true;

			if(randInt == 1) 
			{
				rb.AddForce (new Vector3 (1, 1, 0));
			}

			if (randInt == 2) {
				rb.AddForce (new Vector3 (1, -1, 0));
			}
		}

		Vector3 unit = rb.velocity.normalized; //"unit velocity" - i.e. magnitude = 1, but direction preserved.
		GetComponent<Rigidbody>().velocity = unit * 45; //Normalized velocity is then multiplied by a constant for desired speed.

	}



}
