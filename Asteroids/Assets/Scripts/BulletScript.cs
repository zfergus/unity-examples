using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{
	/* Destroy this bullet in 5 seconds. */
	void Start()
	{
		this.GetComponent<Rigidbody> ().AddForce (1000 * (this.transform.rotation * Vector3.up));

		/* Call CleanUp in 5 seconds. */
		//Invoke ("CleanUp", 5);
	}

	/* Move the bullet forward every frame. */
	void Update ()
	{
		/* Destroy the bullet if it leaves the screen. */
		Vector3 viewportCoords = Camera.main.WorldToViewportPoint (this.transform.position);
		if (!Utils.isInViewport(viewportCoords)) 
		{
			CleanUp ();
		}

		print (this.GetComponent<Rigidbody> ().velocity);
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
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Asteroid")
		{
			col.gameObject.GetComponent<AsteroidLives> ().
				TakeDamage (1, this.GetComponent<Rigidbody>().velocity);

			GameObject.FindGameObjectWithTag ("SoundManager").GetComponent<AudioSource> ().Play ();

			Destroy (this.gameObject);
		}
	}
}