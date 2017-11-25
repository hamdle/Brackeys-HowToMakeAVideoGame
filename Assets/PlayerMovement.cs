using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	bool moveLeft = false;
	bool moveRight = false;
	
	void Update()
	{
		if (Input.GetKey("d"))
		{
			moveRight = true;
		}
		else
		{
			moveRight = false;
		}
		if (Input.GetKey("a"))
		{
			moveLeft = true;
		}
		else
		{
			moveLeft = false;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		Debug.Log(moveRight);
		if (moveRight)
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		}
		if (moveLeft)
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		}
	}
}
