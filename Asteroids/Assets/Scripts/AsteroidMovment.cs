using UnityEngine;
using System.Collections;

public class AsteroidMovment : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		Vector3 randVec;
		do{
			randVec = new Vector3(Random.Range (-1, 1), Random.Range (-1, 1), 0);
			randVec.Normalize();
		}while(randVec.magnitude < 1);
		randVec *= Random.Range(20, 30);
		this.GetComponent<Rigidbody>().AddForce (randVec);
	}
}
