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

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		
		if (moveRight)
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (moveLeft)
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}
}
