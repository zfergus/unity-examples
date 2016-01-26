using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	public float speed = 10.0f, rotSpeed = 90.0f;
	public float maxSpeed = 90.0f;

	public GameObject sheild;
	public Light sheildLight;
	private int sheildStrength = 100;

	/* Move the ship depending on the inputs. */
	void Update ()
	{
		if (this.GetComponent<Rigidbody> ().velocity.magnitude < maxSpeed)
		{
			/* If W or Up pressed move forwards. */
			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow))
			{
				//this.transform.Translate(Vector3.up * speed * Time.deltaTime);
				Quaternion rot = this.transform.rotation;
				this.GetComponent<Rigidbody> ().AddForce (rot * Vector3.up * speed);
			}
		}

		/* Rotate the ship. */
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow))
		{
			this.gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
			this.transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow))
		{
			this.gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
			this.transform.Rotate(Vector3.back * rotSpeed * Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		this.sheildStrength -= 10;

		this.sheild.GetComponent<AudioSource> ().Play ();

		if (this.sheildStrength < 0)
		{
			SceneManager.LoadScene ("GameOver");
		}
		else
		{
			Color color = this.sheild.GetComponent<Renderer> ().material.color;
			color.a -= 0.05f;

			if (color.a <= 1e-4f)
			{
				this.sheild.SetActive (false);
			}
			else
			{
				this.sheild.GetComponent<Renderer> ().material.color = color;
			}
			sheildLight.intensity -= 0.1f;
		}
	}
}
