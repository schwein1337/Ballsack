using UnityEngine;
using System.Collections;

public class CharMovement : MonoBehaviour
{
	//int maxSpeed = 20;
	public float speed = 5.0f;
	public bool grounded = false;

	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		grounded = GetComponent<Rigidbody>().velocity.y == 0;


		if(grounded)
		{
			GetComponent<Rigidbody>().AddForce(speed * movement);
		}
		/*
		if(GetComponent<Rigidbody>().velocity.magnitude >= maxSpeed)
		{
		
			speed = maxSpeed;
		}
		print("Grounded: "+grounded);
		print ("velocity: "+GetComponent<Rigidbody>().velocity.x+","+GetComponent<Rigidbody>().velocity.y);
		print ("Speed: "+GetComponent<Rigidbody>().velocity.magnitude);

*/


	}



	void OnCollisionEnter()
	{
		grounded = true;
	}

	void OnCollisionExit()
	{

		grounded = false;
	}

}
