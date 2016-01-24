using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
	public float speed = 30.0f;

	void Start()
	{
		Invoke ("DestroyBullet", 5);
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
