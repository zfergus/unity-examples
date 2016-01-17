using UnityEngine;
using System.Collections;

public class SpriteAnchor : MonoBehaviour
{
	// Use this for initialization
	void Awake ()
	{
		SetScreenLocation (Screen.width - 200, 200);
	}
	
	void SetScreenLocation(float x, float y)
	{
		Ray mouseRay = Camera.main.ScreenPointToRay(new Vector2(x,y));
		RaycastHit hit;
		if (Physics.Raycast (mouseRay, out hit, 1 << 8)) {
			this.transform.position = hit.point;
		}
	}
}
