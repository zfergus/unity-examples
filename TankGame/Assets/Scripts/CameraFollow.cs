using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	private GameObject player;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		if (player != null)
		{
			this.transform.position = new Vector3(player.transform.position.x,
			                                      this.transform.position.y,
			                                      player.transform.position.z);
		}
	}
}
