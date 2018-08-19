/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * MoveTowards.cs
 * Script for moving a GameObject towards another GameObject. Also rotates the
 * game object towards the target.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using System.Collections;

public class MoveTowards : MonoBehaviour
{
	/* GameObject for the target to move towards. */
	public GameObject target;
	/* Float value for the speed at which to move and rotate. */
	public float speed = 10.0f, rotSpeed = 90.0f;

	/* Get the rigidbody of this game object. */
	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player");
	}

	/* Moves this object towards the target every frame. */
	void Update()
	{
		/* If the target has been set and still exists in the game. */
		if(target != null)
		{
			/* Vector from this game object to the target. */
			Vector3 targetDir = target.transform.position - this.transform.position;

			/* Turn this object to face the target. */
			Quaternion rotationAngle = Quaternion.LookRotation(targetDir);
			transform.rotation = Quaternion.Slerp(this.transform.rotation,
			                                      rotationAngle, Time.deltaTime * rotSpeed);

			if(targetDir.magnitude > 25)
			{
				/* Translate this object towards the target object. */
				Vector3 towardsVector = Vector3.MoveTowards(this.transform.position,
				                                            target.transform.position,
				                                            Time.deltaTime * speed);
				towardsVector.y = 0;
				Debug.DrawRay(transform.position, towardsVector, Color.red);
				this.transform.position = towardsVector;
			}
		}
	}
}
