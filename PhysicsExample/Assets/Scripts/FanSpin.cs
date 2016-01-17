using UnityEngine;
using System.Collections;

public class FanSpin : MonoBehaviour {

	public float rotSpeed = 90;
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.Rotate (Vector3.up * rotSpeed * Time.deltaTime);
	}

	public float GetRotationalSpeed()
	{
		return Mathf.Abs(this.rotSpeed);
	}

	public void SetRotationalSpeed(float newSpeed)
	{
		this.rotSpeed = -Mathf.Abs(newSpeed);
	}
}
