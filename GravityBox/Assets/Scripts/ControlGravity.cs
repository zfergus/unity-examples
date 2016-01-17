using UnityEngine;
using System.Collections;

public class ControlGravity : MonoBehaviour
{
	/* Change the gravity depending on the input. */
	void Update ()
	{
		//KeyBoardControls ();
		//AccelerationControls ();
		FluidAccelerationControls ();
	}

	/* Change the gravity with keyboard controls. */
	void FluidAccelerationControls()
	{
		Physics.gravity = new Vector3(Input.acceleration.x * 9.8f, 
		                              Input.acceleration.z * 9.8f, 
		                              Input.acceleration.y * 9.8f);
	}

	/* Change the gravity with acclerometer controls. */
	void AccelerationControls()
	{
		float x = 0, y = -9.8f, z = 0;
		
		if (Mathf.Abs (Input.acceleration.x) > 0.1) {
			x = Mathf.Sign(Input.acceleration.x) * 9.8f;
		}

		if (Input.acceleration.z > 0.1) {
			y = 9.8f;
		}

		if (Mathf.Abs (Input.acceleration.y) > 0.1) {
			z = Mathf.Sign(Input.acceleration.y) * 9.8f;
		}

		Physics.gravity = new Vector3(x, y, z);
	}

	/* Change the gravity with keyboard controls. */
	void KeyBoardControls()
	{
		float x = 0, y = -9.8f, z = 0;
		
		if (Input.GetKey (KeyCode.UpArrow))
		{
			z =  9.8f;
		}
		else if (Input.GetKey (KeyCode.DownArrow))
		{
			z = -9.8f;
		}
		
		if (Input.GetKey (KeyCode.RightArrow))
		{
			x =  9.8f;
		}
		else if (Input.GetKey (KeyCode.LeftArrow))
		{
			x = -9.8f;
		}
		
		if (Input.GetKey (KeyCode.W))
		{
			y *= -1.0f;
		}
		
		Physics.gravity = new Vector3(x, y, z);
	}
}
