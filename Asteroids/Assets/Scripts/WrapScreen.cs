using UnityEngine;
using System.Collections;

public class WrapScreen : MonoBehaviour
{
	Renderer[] renderers;

	bool isWrappingX, isWrappingY;

	// Use this for initialization
	void Start ()
	{
		isWrappingX = false;
		isWrappingY = false;

		renderers = this.GetComponentsInChildren<Renderer>();
	}

	bool CheckRenders()
	{
		foreach(Renderer r in renderers)
		{
			if (r.isVisible)
			{
				return true;
			}
		}

		return false;
	}

	// Update is called once per frame
	void Update ()
	{
		bool isVisible = CheckRenders ();

		if (isVisible)
		{
			isWrappingX = false;
			isWrappingY = false;
			return;
		}

		if (isWrappingX && isWrappingY)
		{
			return;
		}

		Vector3 pos = this.gameObject.GetComponent<Transform> ().position;
		Vector3 viewportPos = Camera.main.WorldToViewportPoint (pos);

		if (!isWrappingX && (viewportPos.x < 0 || viewportPos.x > 1))
		{
			pos.x = -pos.x;
			isWrappingX = true;
		} 

		this.gameObject.GetComponent<Transform> ().position = pos;
	}
}