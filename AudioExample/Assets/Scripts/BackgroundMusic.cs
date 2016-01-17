using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour
{
	/* Instance of the background music that is playing. */
	private static BackgroundMusic instance = null;

	void Awake()
	{
		/* Checks if their is already background music. */
		if (instance != null && instance != this)
		{
			Destroy (this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}

		/* Does not destroy the music when the scene changes. */
		DontDestroyOnLoad (this.gameObject);
	}
}
