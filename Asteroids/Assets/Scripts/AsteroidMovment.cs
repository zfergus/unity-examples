using UnityEngine;
using System.Collections;

public class AsteroidMovment : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Vector3 randVec = new Vector3 (Random.Range (0, 20), Random.Range (0, 20), 0);
		this.GetComponent<Rigidbody> ().AddForce (randVec);
	}
}
