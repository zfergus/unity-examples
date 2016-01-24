using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 10.0f, rotSpeed = 90.0f;
	public float maxSpeed = 90.0f;

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
//			/* If S or Down pressed move back. */
//			else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow))
//			{
//				this.transform.Translate (Vector3.down * speed * Time.deltaTime);
//			}
		}

		/* Rotate the ship. */
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow))
		{
			this.transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow))
		{
			this.transform.Rotate(Vector3.back * rotSpeed * Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		SceneManager.LoadScene("GameOver");
	}
}
