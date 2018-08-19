using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public string sceneName;
	public LoadSceneMode mode = LoadSceneMode.Single;

	public void LoadSceneByName(){
		SceneManager.LoadScene(this.sceneName, this.mode);
	}
}
