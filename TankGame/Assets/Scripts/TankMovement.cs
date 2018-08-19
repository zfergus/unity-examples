using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TankMovement : MonoBehaviour
{
	public float speed = 10.0f, turnSpeed = 90.0f;
	private Text gpsText;

	private Rigidbody mRigidbody;
	private float movmentMag;
	private float rotateMag;

	void Start()
	{
		GameObject textObject = GameObject.FindGameObjectWithTag("GPSText");
		if (textObject != null) {
			gpsText = textObject.GetComponent<Text>();
		}
		this.mRigidbody = this.GetComponent<Rigidbody>();
	}

	// // Update is called once per frame
	// void Update ()
	// {
	// 	if (Input.GetKey(KeyCode.W)) {
	// 		this.mRigidbody.MovePosition(this.transform.forward * speed);
	// 		Debug.Log(this.mRigidbody.position + this.transform.forward * speed);
	// 	}
	// 	else if (Input.GetKey(KeyCode.S)) {
	// 		this.mRigidbody.MovePosition(this.mRigidbody.position - this.transform.forward * speed * Time.deltaTime);
	// 	}
	//
	// 	if (Input.GetKey(KeyCode.A)) {
	// 		this.transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime);
	// 	}
	// 	else if (Input.GetKey(KeyCode.D)) {
	// 		this.transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
	// 	}
	// }

	void Update()
	{
		this.movmentMag = 0;
		this.rotateMag = 0;

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow))
		{
			movmentMag += 1;
		}
		if (Input.GetKey (KeyCode.S)  || Input.GetKey (KeyCode.DownArrow))
		{
			movmentMag -= 1;
		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow))
		{
			rotateMag -= 1;
		}
		if (Input.GetKey (KeyCode.D)  || Input.GetKey (KeyCode.RightArrow))
		{
			rotateMag += 1;
		}

	}

	void FixedUpdate ()
	{
		Vector3 movement = this.transform.forward * this.movmentMag *
			this.speed * Time.deltaTime;

		this.mRigidbody.MovePosition(
			this.mRigidbody.position + movement);

		Quaternion turnRotation = Quaternion.Euler(
			0f, this.rotateMag * this.turnSpeed * Time.deltaTime, 0f);

		this.mRigidbody.MoveRotation(this.mRigidbody.rotation *
			turnRotation);

		if (gpsText != null) {
			gpsText.text = "X: " + this.transform.position.x +
			"\nY: " + this.transform.position.z;
		}
	}
}
