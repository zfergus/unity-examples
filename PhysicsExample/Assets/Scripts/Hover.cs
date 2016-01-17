using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour
{
	public float force = 50;

	void Update()
	{
		GameObject fan = GameObject.FindGameObjectWithTag ("Fan");
		if (fan != null)
		{
			FanSpin fanSpin = fan.GetComponent<FanSpin>();
			if(fanSpin != null)
			{
				this.force = 0.069f * fanSpin.GetRotationalSpeed();
			}
			else
			{
				Debug.LogWarning("Fan object, " + fan.name + 
					", missing FanSpin script.");
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Hoverable")
		{
			other.GetComponent<Rigidbody> ().drag = 0;
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Hoverable")
		{
			other.GetComponent<Rigidbody> ().AddForce (Vector3.up * this.force,
				ForceMode.Force);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Hoverable")
		{
			other.GetComponent<Rigidbody> ().drag = 0.5f;
		}
	}
}
