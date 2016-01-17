using UnityEngine;
using System.Collections;

public class DirPadMovement : MonoBehaviour {

	public DirPad dPad;
	
	public float speed = 10.0f;
	
	// Update is called once per frame
	void Update ()
	{
		int xDir = 0, yDir = 0;
		
		if (dPad.DPadState == DirPad.DirPadState.Right) {
			xDir = 1;
		} else if (dPad.DPadState == DirPad.DirPadState.Left) {
			xDir = -1;
		} else if (dPad.DPadState == DirPad.DirPadState.Up) {
			yDir = 1;
		} else if (dPad.DPadState == DirPad.DirPadState.Down) {
			yDir = -1;
		}
		
		Vector2 dir = xDir * Vector3.right + yDir * Vector3.up;
		dir.Normalize ();
		
		this.transform.Translate (dir * speed * Time.deltaTime);
	}
}
