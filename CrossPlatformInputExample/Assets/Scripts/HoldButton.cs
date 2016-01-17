using UnityEngine;
using System.Collections;

public class HoldButton : MonoBehaviour
{
	private bool down = false;
	public bool Down { get{ return this.down; } }

	void OnMouseDrag()
	{
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (mouseRay, out hit) && hit.collider.gameObject == this.gameObject) {
			Debug.DrawLine (mouseRay.origin, hit.point);
			down = true;
		} else {
			down = false;
		}
	}

	void OnMouseUp()
	{
		down = false;
	}
}
