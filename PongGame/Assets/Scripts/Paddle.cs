using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed; //Multiplied by Delta time to be frame rate independent => unchanging across
	//various resolutions
	public Vector3 playerPos;

	public AudioClip playerBlip;

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
		SFXSource.clip = playerBlip;
		SFXSource.Play ();


	}


}
