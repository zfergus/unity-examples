using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
	public string scenename;

	public void LoadSceneByName()
	{
		SceneManager.LoadScene(scenename);
	}
}
