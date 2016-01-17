using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DebugAcceleration : MonoBehaviour {

	private Text debugText;

	// Use this for initialization
	void Start () {
		debugText = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		string debugStr = "X: " + Input.acceleration.x +
						"\nY: " + Input.acceleration.y +
						"\nZ: " + Input.acceleration.z;
		debugText.text = debugStr;
	}
}
