using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {
	public string sceneName;

	public void Load()
	{
		Application.LoadLevel (sceneName);
	}
}
