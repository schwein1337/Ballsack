using UnityEngine;
using System.Collections;

public class CharMovement : MonoBehaviour
{
	int maxSpeed = 5;
	public float speed = 2.0f;
	public bool grounded = false;

	// Update is called once per frame
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		grounded = GetComponent<Rigidbody2D>().velocity.y == 0;


		if(grounded)
		{
			GetComponent<Rigidbody2D>().AddForce(speed*movement);
		}

		if(GetComponent<Rigidbody2D>().velocity.magnitude >= maxSpeed)
		{
		
			speed = maxSpeed;
		}
		print("Grounded: "+grounded);
		print ("velocity: "+GetComponent<Rigidbody2D>().velocity.x+","+GetComponent<Rigidbody2D>().velocity.y);
		print ("Speed: "+GetComponent<Rigidbody2D>().velocity.magnitude);




	}



	void OnCollisionEnter()
	{
		grounded = true;
	}

	void OnCollisionExit()
	{
	//	print ("got here mothfu");
		grounded = false;
	}

}
