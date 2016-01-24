using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour
{
	public string sceneName;

//	public string SceneName
//	{
//		get
//		{
//			return sceneName;
//		}
//
//		set
//		{
//			sceneName = value;
//		}
//	}

	public void Load()
	{
		Application.LoadLevel(sceneName);
	}
}
