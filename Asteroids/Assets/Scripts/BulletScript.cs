using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{
	/* Destroy this bullet in 5 seconds. */
	void Start()
	{
		/* Call CleanUp in 5 seconds. */
		Invoke ("CleanUp", 5);
	}

	/* Move the bullet forward every frame. */
	void Update ()
	{
		this.transform.Translate (Vector3.up * 20 * Time.deltaTime);

		/* Destroy the bullet if it leaves the screen. */
		Vector3 viewportCoords = Camera.main.WorldToViewportPoint (this.transform.position);
		if (viewportCoords.x < 0 || viewportCoords.x > 1 ||
			viewportCoords.y < 0 || viewportCoords.y > 1   ) 
		{
			Destroy (this.gameObject);
		}
	}

	/* Destroys this bullet in order to free up memory. */
	void CleanUp()
	{
		if (this.gameObject != null)
		{
			Destroy (this.gameObject);
		}
	}

	/* On collision with a rigidbody destroy it if it is an asteroid. */
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Asteroid")
		{
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
	}
}