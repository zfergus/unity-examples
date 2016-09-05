using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public Text livesText;
	private int speed, lives;
	private static int score;

	void Start()
	{
		speed = 20;
		lives = 3;
		score = 0;
	}

	// Update is called once per frame
	void Update ()
	{
		if ((Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) && 
			Camera.main.WorldToViewportPoint( this.transform.position ).x > 0.05f) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		if ((Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) && 
			Camera.main.WorldToViewportPoint( this.transform.position ).x < 0.95f) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		
		livesText.text = "Lives: " + lives + "\nScore: " + score;

		if (lives <= 0)
			GameOver();
		if(GameObject.FindGameObjectWithTag ("Enemy") == null)
			SceneManager.LoadScene ("WinScene");
	}
	
	public void LoseLive()
	{
		if(lives > 0)
		{
			lives--;
		}
	}

	public static void IncreaseScore()
	{
		score++;
	}

	public static int GetScore()
	{
		return score;
	}

	public static void GameOver()
	{
		SceneManager.LoadScene("GameOver");
	}
}