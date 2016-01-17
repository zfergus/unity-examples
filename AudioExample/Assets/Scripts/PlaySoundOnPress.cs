using UnityEngine;
using System.Collections;

public class PlaySoundOnPress : MonoBehaviour
{
	/* When the mouse clicks on the game object. */
	void OnMouseDown()
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
			                 ", but PlaySoundOnPress trying to access it.");
		}
	}
}
