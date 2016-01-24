using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	private Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () 
	{
		GameObject textObj = GameObject.FindGameObjectWithTag("ScoreText");
		if (textObj != null)
		{
			this.scoreText = textObj.GetComponent<Text>();
		}
	}

	public void IncreaseScore()
	{
		this.score++; //score = score + 1; score += 1;
		if (score > 10)
		{
			//GameOver
		}
		if (scoreText != null)
		{
			scoreText.text = "Score: " + score;
		}
	}
}
