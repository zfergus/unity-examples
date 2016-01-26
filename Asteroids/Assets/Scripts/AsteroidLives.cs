using UnityEngine;
using System.Collections;

public class AsteroidLives : MonoBehaviour
{
	public int lives = 3;

	public int Lives
	{
		get{ return lives; }
		set{ lives = value; }
	}

	public void TakeDamage(int damage, Vector3 hitDir)
	{
		this.lives -= damage;
		if(this.lives > 0)
		{
			this.BreakApart(hitDir);
		}
		else
		{
			// TODO: Increase Score
			// TODO: Add Level Up
			Destroy(this.gameObject);
		}
	}

	void BreakApart (Vector3 hitDir)
	{
		Vector3 newScale = 0.5f * this.transform.localScale;
	
		hitDir.Normalize();
		Vector3[] dirs = new Vector3[]{
			Quaternion.AngleAxis(90, Vector3.forward) * hitDir,
			hitDir, 
			Quaternion.AngleAxis(90, Vector3.back) * hitDir
		};
		print (hitDir);
		print (dirs[0]);
		print (dirs[1]);
		print (dirs[2]);
		for (int i = 0; i < 3; i++)
		{
			GameObject asteroid = Instantiate (this.gameObject);
			asteroid.transform.localScale = newScale;
			asteroid.transform.position = asteroid.transform.position + dirs [i];
			asteroid.GetComponent<AsteroidLives> ().Lives = this.lives;

			asteroid.GetComponent<Rigidbody> ().velocity = 
				this.GetComponent<Rigidbody> ().velocity;
			asteroid.GetComponent<Rigidbody> ().AddForce (45 * 1/this.lives * dirs [i]);
		}
		Destroy(this.gameObject);
	}
}
