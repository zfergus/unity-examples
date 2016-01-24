using UnityEngine;
using System.Collections;

public class TankShoot : MonoBehaviour 
{
	public GameObject bullet, spawnPosObj;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			//Create a bullet
			Instantiate(bullet, spawnPosObj.transform.position, this.transform.rotation);
			//Instantiate(bullet, spawnPosObj.transform.position, Quaternion.identity);
		}
	}
}
