using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public void LoadGameScene()
	{
		SceneManager.LoadScene("GameScene");
	}
}
