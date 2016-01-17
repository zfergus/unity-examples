using UnityEngine;
using System.Collections;

public class SetMirrorAspect : MonoBehaviour
{
	/* Set the aspect ratio of the camera. */
	void Start ()
	{
		Transform mirror = this.transform.parent;
		if (mirror != null)
		{
			Vector3 deminsions = mirror.localScale;
			this.GetComponent<Camera> ().aspect = deminsions.x / deminsions.z;
		} 
		else
		{
			this.GetComponent<Camera> ().aspect = 0.5f;
		}
	}
}
