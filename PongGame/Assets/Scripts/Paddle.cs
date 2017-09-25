using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed; //Multiplied by Delta time to be frame rate independent => unchanging across
	//various resolutions
	public Vector3 playerPos;

	public AudioClip playerBlip;
	public AudioClip redBallCollision;
	public AudioSource SFXSource;


	void Awake()
	{
		paddleSpeed = 30 * Time.deltaTime;

	}

	void Update ()
	{

		float yPos = gameObject.transform.position.y + (Input.GetAxis ("Vertical") * paddleSpeed);
		playerPos = new Vector3 (-22, Mathf.Clamp(yPos, -12.5f, 12.5f), 0);
		gameObject.transform.position = playerPos;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "RedBall") {

			SFXSource.clip = redBallCollision;
			SFXSource.Play ();
		} else {

			float y = (other.gameObject.transform.position.y - gameObject.transform.position.y) / 4;
			other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (1, 2*y, 0);
//
//			print (Mathf.Abs (Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)));
//			if ( Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) <  2/10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos(1.0472f), Mathf.Sin (1.0472f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 4 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.872665f), Mathf.Sin (0.872665f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 6 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.698132f), Mathf.Sin (0.698132f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 8 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.523599f), Mathf.Sin (0.523599f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 10 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.261799f), Mathf.Sin (0.261799f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 12 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (1f, 0, 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 14 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.261799f), -Mathf.Sin (0.261799f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 16 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.523599f), -Mathf.Sin (0.523599f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 20 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.698132f), -Mathf.Sin (0.698132f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) < 23 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos (0.872665f), -Mathf.Sin (0.872665f), 0);
//			else if (Mathf.Abs(Mathf.Abs(gameObject.transform.position.y) - Mathf.Abs(other.gameObject.transform.position.y)) <= 26 / 10)
//				other.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (Mathf.Cos(1.0472f), -Mathf.Sin (1.0472f), 0);
//			
			SFXSource.clip = playerBlip;
			SFXSource.Play ();
			}

		}


	}




