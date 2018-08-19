using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour
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
	}
}
