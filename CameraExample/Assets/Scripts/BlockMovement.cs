using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			this.transform.Translate(Vector3.left * 100);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			this.transform.Translate(Vector3.right * 100);
		}
	}
}
