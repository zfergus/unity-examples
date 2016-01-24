using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 10.5f, rotSpeed = 90;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
		{
			this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		} 
		else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(Vector3.back * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Rotate(Vector3.up * rotSpeed *  Time.deltaTime);
		}
	}
}
