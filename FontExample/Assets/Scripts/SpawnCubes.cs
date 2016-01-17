using UnityEngine;
using System.Collections;

public class SpawnCubes : MonoBehaviour
{
	private bool canSpawn;
	
	public GameObject redCube, blueCube;
	
	void Start()
	{
		canSpawn = true;
	}
	
	void Update ()
	{
		/* Spawn a cube every one second. */
		if(canSpawn)
		{
			/* Spawn a cube in one second. */
			Invoke("SpawnCube", 0.01f);
			canSpawn = false;
		}
	}
	
	void SpawnCube()
	{
		GameObject cube;
		
		int rand  = (int)Random.Range(0, 2);
		if(rand == 0)
		{
			cube = Instantiate(redCube, this.transform.position, 
				Quaternion.identity) as GameObject;
		}
		else
		{
			cube = Instantiate(blueCube, this.transform.position, 
				Quaternion.identity) as GameObject;
		}
		
		cube.transform.parent = this.transform;
		
		canSpawn = true;
	}
}
