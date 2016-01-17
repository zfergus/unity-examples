using UnityEngine;
using System.Collections;

public class RespawnBall : MonoBehaviour
{
	/* The orgininal position of the ball. */
	private Vector3 originalPos;

	void Start ()
	{
		/* Save the orginal position of the ball. */
		originalPos = this.transform.position;
	}

	void Update ()
	{
		/* Get the ball's point in viewport coordinates. */
		Vector3 viewportCoords = Camera.main.WorldToViewportPoint (this.transform.position);
		/* Respawn the ball if it is below the screen */
		if (viewportCoords.y < -0.4)
		{
			/* Reset the ball's position to its original position. */
			this.transform.position = originalPos;
		}
	}
}
