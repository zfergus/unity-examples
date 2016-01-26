using UnityEngine;
using System.Collections;

public class WrapScreen : MonoBehaviour
{
	Transform[] transforms;

	bool isWrappingX, isWrappingY;

	// Use this for initialization
	void Start ()
	{
		isWrappingX = false;
		isWrappingY = false;

		transforms = this.GetComponentsInChildren<Transform>();
	}

	bool CheckChildren()
	{
		foreach(Transform t in transforms)
		{
			if (Utils.isInViewport(Camera.main.WorldToViewportPoint(t.position)))
			{
				return true;
			}
		}

		return false;
	}

	// Update is called once per frame
	void Update ()
	{
		bool isVisible = CheckChildren();

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

		Vector3 pos = this.transform.position;
		Vector3 viewportPos = Camera.main.WorldToViewportPoint (pos);

		if (!isWrappingX && (viewportPos.x < 0 || viewportPos.x > 1))
		{
			pos.x = -pos.x;
			isWrappingX = true;
		}
		if (!isWrappingY && (viewportPos.y < 0 || viewportPos.y > 1))
		{
			pos.y = -pos.y;
			isWrappingY = true;
		}

		this.transform.position = pos;
	}
}