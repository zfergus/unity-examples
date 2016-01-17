using UnityEngine;
using System.Collections;

/**
 * Rotate around a set point.
 **/
public class RotateAroundPivot : MonoBehaviour
{
	public Vector3 axis = new Vector3(0,0,0);

	/**
	 * Rotates if the keyboard is pressed.
	 **/
	void Update ()
	{
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow))
		{
			this.transform.Rotate (axis * 90 * Time.deltaTime); 
		}
		else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow))
		{
			this.transform.Rotate (axis * -90 * Time.deltaTime);
		}
	}
}
