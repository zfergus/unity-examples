using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate(Vector3.forward * 10 * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(Vector3.back * 10 * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate(Vector3.left * 10 * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate(Vector3.right * 10 * Time.deltaTime);
		}
		
		if(Input.GetKey(KeyCode.Q))
		{
			this.transform.Rotate(Vector3.down * 90 * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.E))
		{
			this.transform.Rotate(Vector3.up * 90 * Time.deltaTime);
		}
	}
}
