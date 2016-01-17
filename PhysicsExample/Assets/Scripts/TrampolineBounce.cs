using UnityEngine;
using System.Collections;

public class TrampolineBounce : MonoBehaviour
{
	/* When a collision occurs apply an impulse in the direction of the */
	/* collision.                                                       */
	void OnCollisionEnter(Collision col)
	{
		Rigidbody colRb = col.gameObject.GetComponent<Rigidbody> ();
		if(colRb != null)
		{
			colRb.velocity = Vector3.zero;
			/* Get the direction from the trampoline to the collider's */
			/* position.                                               */
			Vector3 dir = col.gameObject.transform.position - 
				this.transform.position;
			dir = Mathf.Sign(dir.y) * this.transform.up;
			colRb.AddForce (dir * 10, ForceMode.Impulse);
		}
	}
	
		/* When a collision occurs apply an impulse in the direction of the */
	/* collision.                                                       */
	void OnCollisionExit(Collision col)
	{
		Rigidbody colRb = col.gameObject.GetComponent<Rigidbody> ();
		if(colRb != null)
		{
			/* Remove the velocity form before the collision. */
			Debug.Log(colRb.velocity);
		}
	}
}
