using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour
{
	/* String for the scene to open. */
	public string sceneName = null;

	/* Go to the scene designated. */
	public void OpenScene()
	{
		/* If the scene name has been set. */
		if (sceneName != null && sceneName != "")
		{
			/* Open the specified scene. */
			Application.LoadLevel (sceneName);
		}
		else
		{
			/* Warn that their is no scene name. */
			Debug.LogWarning("No scene name assigned to " + this.gameObject.name + 
			                 ", but LoadScene.OpenScene() trying to access it.");
		}
	}
}
