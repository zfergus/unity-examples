using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	void Update()
	{
		/* If the left mouse button is pressed. */
		if (Input.GetMouseButtonDown (0))
		{
			/* Get the AudioSource from the game object. */
			AudioSource sound = this.GetComponent<AudioSource> ();
			
			/* If there is an AudioSource. */
			if (sound != null)
			{
				/* Play the AudioSource from on the game object. */
				sound.Play ();
			}
			else
			{
				/* Warn that their is no AudioSource */
				Debug.LogWarning("No AudioSouce on " + this.gameObject.name + 
				                 ", but PlaySound trying to access it.");
			}
		}
	}
}
