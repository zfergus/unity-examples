using UnityEngine;
using System.Collections;

public class DestroyCube : MonoBehaviour
{
	void Update()
	{
		Vector3 viewportCoords = Camera.main.WorldToViewportPoint(this.
			transform.position);
		if(viewportCoords.y < -0.05 || viewportCoords.z < -0.05)
			Destroy(this.gameObject);
	}
}
