using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour {
	// Use this for initialization
	void Start () {
		this.transform.rotation = Quaternion.Euler(
			Random.Range(15f, 75f), 
			Random.Range(0f, 360f), 
			Random.Range(15f, 75f));
	}
}
