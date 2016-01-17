using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour 
{
	private Camera cam;
	
	void Start()
	{
		cam = this.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(cam != null)
		{
			if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) &&
				cam.fieldOfView > 3)
			{
				cam.fieldOfView -= 1;
			}	
			if((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
				&& cam.fieldOfView < 60)
			{
				cam.fieldOfView += 1;
			}
		}
	}
}
