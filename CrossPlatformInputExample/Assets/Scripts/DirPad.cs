using UnityEngine;
using System.Collections;

public class DirPad : MonoBehaviour
{
	public enum DirPadState{ Center, Right, Left, Up, Down };

	private DirPadState dPadState = DirPadState.Center;
	public DirPadState DPadState { get{ return dPadState; } }

	void OnMouseDrag()
	{
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (mouseRay, out hit, 1 << 8)) {
			Debug.DrawLine (mouseRay.origin, hit.point);

			Vector3 delta = hit.point - this.transform.position;

			if (delta.x > 0.5) {
				this.dPadState = DirPadState.Right;
			} else if (delta.x < -0.5) {
				this.dPadState = DirPadState.Left;
			} else if (delta.y > 0.5) {
				this.dPadState = DirPadState.Up;
			} else if (delta.y < -0.5) {
				this.dPadState = DirPadState.Down;
			} else {
				this.dPadState = DirPadState.Center;
			}
		}else {
			this.dPadState = DirPadState.Center;
		}
	}

	void OnMouseUp()
	{
		this.dPadState = DirPadState.Center;
	}
}
