using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsBall : MonoBehaviour {

	public int ballVel = 500;

	public Rigidbody rb;

	void Awake()
	{
		rb.velocity = new Vector3 (ballVel, 0, 0);
	}
}
