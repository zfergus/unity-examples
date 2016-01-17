using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Joystick : MonoBehaviour
{
	/* Axis for the joystick to be movable on. */
	public enum AxisOfMovement{XAxis, YAxis, BothAxes};
	/* The axis the direction that this joystick can move in. */
	public AxisOfMovement axisOfMovement = AxisOfMovement.BothAxes;

	/* Direction that the joystick is being pulled in. */
	public enum JoystickState{Up, Down, Left, Right, Center};
	/* The current state of this joystick. */
	private JoystickState xState = JoystickState.Center, 
		                  yState = JoystickState.Center;
	/* Accessors for the JoystickStates. */
	public JoystickState XState { get{ return this.xState; } }
	public JoystickState YState { get{ return this.yState; } }

	public Vector2 sensitivity = Vector2.zero;

	/* The original position of this joystick. */
	private Vector3 originalPos;

	/* The radius that this joystick can extend out to. */
	public float radius = 1.0f;

	/* The Image used for the backgound. */
	public Image bgImage = null;

	/* Store the orginal position and resize the bgImage. */
	void Start()
	{
		originalPos = this.transform.position;
		print (originalPos);
		if (bgImage != null) {
			float diameter = this.radius * 3.5f;
			bgImage.rectTransform.sizeDelta = new Vector2(diameter, diameter);
		}

		sensitivity.x = Mathf.Clamp (sensitivity.x, 0, 0.95f);
		sensitivity.y = Mathf.Clamp (sensitivity.y, 0, 0.95f);
	}

	/* Update the current state of the joystick. */
	void Update()
	{
		Vector3 delta = this.transform.position - this.originalPos;

		if (delta.x > (this.radius * this.sensitivity.x)) {
			this.xState = JoystickState.Right;
		} else if (delta.x < (-this.radius * this.sensitivity.x)) {
			this.xState = JoystickState.Left;
		} else {
			this.xState = JoystickState.Center;
		}

		if (delta.y > (this.radius * this.sensitivity.y)) {
			this.yState = JoystickState.Up;
		} else if (delta.y < (-this.radius * this.sensitivity.y)) {
			this.yState = JoystickState.Down;
		} else {
			this.yState = JoystickState.Center;
		}
	}

	void OnMouseDrag()
	{
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (mouseRay, out hit, 1 << 8))
		{
			Debug.DrawLine (mouseRay.origin, hit.point);

			Vector3 hitPoint = hit.point;

			if(this.axisOfMovement == AxisOfMovement.XAxis)
			{
				hitPoint.y = originalPos.y;
			}
			else if(this.axisOfMovement == AxisOfMovement.YAxis)
			{
				hitPoint.x = originalPos.x;
			}

			Debug.DrawLine (mouseRay.origin, hitPoint, Color.red);

			if((hitPoint - originalPos).magnitude < radius)
			{
				this.transform.position = hitPoint;
			}
			else
			{
				Vector3 delta = hitPoint - originalPos;
				delta.Normalize();
				delta *= radius;
				this.transform.position = delta + originalPos;
			}
		}
	}

	void OnMouseUp()
	{
		this.transform.position = originalPos;
	}

	public override string ToString()
	{
		return "Joystick:" +
			 "\nOriginal Position: " + this.originalPos + 
			 "\nRadius: "  			 + this.radius      + 
			 "\nSensitivity: "       + this.sensitivity +
			 "\nX: "      			 + this.xState      + 
			 "\nY: "     			 + this.yState;
	}
}
