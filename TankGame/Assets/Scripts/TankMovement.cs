using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TankMovement : MonoBehaviour
{
	public float speed = 10.0f, rotSpeed = 90.0f;
	private Text gpsText;

	void Start()
	{
		GameObject textObject = GameObject.FindGameObjectWithTag("GPSText");
		if (textObject != null) {
			gpsText = textObject.GetComponent<Text>();
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.W)) {
			this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.S)) {
			this.transform.Translate(Vector3.back * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.A)) {
			this.transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.D)) {
			this.transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
		}


		if (gpsText != null) {
			gpsText.text = "X: " + this.transform.position.x +
						 "\nY: " + this.transform.position.z;
		}
	}
}
