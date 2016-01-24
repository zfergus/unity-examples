using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
	/* GameObject for the bullet to spawn and position to spawn at. */
	public GameObject bullet, spawnPosObj;

	/* If space bar down fire a bullet. */
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			/* Create a bullet at the spawn point with the same rotation as the ship. */
			Instantiate(bullet, spawnPosObj.transform.position, this.transform.rotation);
		}
	}
}