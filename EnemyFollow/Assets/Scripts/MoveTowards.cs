/*
MoveTowards.cs
Script for moving a GameObject towards another GameObject. Also rotates the
game object towards the target.
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MoveTowards : MonoBehaviour
{
	/* GameObject for the target to move towards. */
	public Transform target;
	/* Tag of the target colliding with. */
	public string targetTag = "Player";
	/* Float value for the speed at which to move and rotate. */
	public float speed = 10.0f;
	/* Float value for the minimum distance to follow behind. */
	public float minDistance = 0.0f;
	/* Should the position be randomized at the start of the game? */
	public bool isPosRandom = true;
	/* Minimum distance from the target if a random position is used. */
	public float startMinDistance = 5.0f;

	private Rigidbody myRigidbody;

	void Start()
	{
		this.myRigidbody = this.GetComponent<Rigidbody>();
		if(this.isPosRandom){
			do{
				float margin = 10.0f;
				Vector3 screenPosition = Camera.main.ScreenToWorldPoint(
					new Vector3(Random.Range(margin, Screen.width - margin),
								Random.Range(margin, Screen.height - margin),
								Camera.main.transform.position.y));
				screenPosition.y = 0;
				this.transform.position = screenPosition;
			}while(Vector3.Magnitude(this.transform.position -
				this.target.position) < this.startMinDistance);
		}
	}

	/* Moves this object towards the target every frame. */
	void Update()
	{
		/* If the target has been set and still exists in the game. */
		if(target != null)
		{
			/* A float for the amount to step per frame. */
			float step = speed * Time.deltaTime;

			/* Turn this object to face the target. */
			Vector3 targetDir = target.position - this.transform.position;
			Vector3 newDir =
				Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			//newDir.x = this.transform.eulerAngles.x;
			//newDir.z = this.transform.eulerAngles.z;
			//Debug.DrawRay(transform.position, newDir, Color.red);
			this.myRigidbody.MoveRotation(Quaternion.LookRotation(newDir));

			/* Check that the target is a minimum distance away. */
			if(Vector3.Magnitude(this.target.position - this.transform.position)
				> minDistance)
			{

				/* Translate this object towards the target object. */
				Vector3 towardsVector = Vector3.MoveTowards(
					this.transform.position, target.position, step);
				towardsVector.y = 0;
				this.myRigidbody.MovePosition(towardsVector);
			}
		}
	}

	/* Collision event handler with another object. */
	void OnTriggerEnter(Collider other)
	{
		/* If the object colliding with is tagged as player destroy it. */
		if(other.tag == targetTag)
		{
			Destroy(other.gameObject);
			/* Set the target to null to prevent null reference exceptions. */
			target = null;
			SceneManager.LoadScene("main");
		}
	}
}
