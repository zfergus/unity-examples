using UnityEngine;
using System.Collections;

/**
 * Collection of utility functions.
 * @author Zachary Ferguson
 */
public class Utils : MonoBehaviour
{
	/**
	 * Check if the given coordinates are on screen.
	 * @param pos Viewport Coordinates to check.
	 * @return Returns if the given coord is in the viewport.
	 */
	public static bool isInViewport(Vector3 pos)
	{
		return pos.x >= 0 && pos.x <= 1 && pos.y >= 0 && pos.y <= 1;
	}
}
