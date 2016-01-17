using UnityEngine;
using System.Collections;

public class JoystickMovement : MonoBehaviour {

	public Joystick joystick;

	public float speed = 10.0f;

	// Update is called once per frame
	void Update ()
	{
		int xDir = 0, yDir = 0;

		if (joystick.XState == Joystick.JoystickState.Right) {
			xDir = 1;
		} else if (joystick.XState == Joystick.JoystickState.Left) {
			xDir = -1;
		}

		if (joystick.YState == Joystick.JoystickState.Up) {
			yDir = 1;
		} else if (joystick.YState == Joystick.JoystickState.Down) {
			yDir = -1;
		}

		Vector2 dir = xDir * Vector3.right + yDir * Vector3.up;
		dir.Normalize ();

		//Debug.Log (joystick.ToString());

		this.transform.Translate (dir * speed * Time.deltaTime);
	}
}
