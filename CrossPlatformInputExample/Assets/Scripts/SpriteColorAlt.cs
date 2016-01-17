using UnityEngine;
using System.Collections;

public class SpriteColorAlt : MonoBehaviour {

	private Color originalColor;
	public  Color newColor = new Color(1,1,1);

	public HoldButton button;

	// Use this for initialization
	void Start () {
		originalColor = this.GetComponent<SpriteRenderer> ().color;
	}
	
	// Update is called once per frame
	void Update () {
		if (button != null) {
			if(button.Down)
			{
				this.GetComponent<SpriteRenderer> ().color = newColor;
			}
			else
			{
				this.GetComponent<SpriteRenderer> ().color = originalColor;
			}
		}
	}
}
