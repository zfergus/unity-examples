using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
	public float speed = 20;

	void Start()
	{
		Invoke ("DestroyBullet", 1);
	}

	// Update is called once per frame
	void Update ()
	{
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
	
	void DestroyBullet()
	{
		Destroy (this.gameObject);
	}
}
