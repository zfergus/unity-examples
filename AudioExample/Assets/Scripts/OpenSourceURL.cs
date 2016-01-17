using UnityEngine;
using System.Collections;

public class OpenSourceURL : MonoBehaviour
{
	/* String for the URL to open. */
	public string url = null;

	/* Go to the URL designated. */
	public void OpenSource()
	{
		/* If the url has been set. */
		if (url != null && url != "")
		{
			/* Open the URL in the default web browser. */
			Application.OpenURL (url);
		}
		else
		{
			/* Warn that their is no scene name. */
			Debug.LogWarning("No URL assigned to " + this.gameObject.name + 
			                 ", but OpenSourceURL.OpenSource() trying to access it.");
		}
	}
}
