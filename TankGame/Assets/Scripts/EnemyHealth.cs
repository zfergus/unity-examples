using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
	public GameObject explosion;
	private float health, originalWidth;
	public Image healthBar;

	// Use this for initialization
	void Start ()
	{
		health = 100;

		if (healthBar != null) {
			originalWidth = healthBar.transform.localScale.x;
		}
	}
	
	public void DecreaseHealth()
	{
		health -= 20; // health = health - 20;
		if (healthBar != null) {
			healthBar.transform.localScale = new Vector3((health / 100.0f) * originalWidth, 
			                                             healthBar.rectTransform.localScale.y,
			                                             healthBar.rectTransform.localScale.z);
		} else {
			Debug.LogWarning("HelthBar not found.");
		}
		if (health <= 0) {
			Instantiate (explosion, this.transform.position, Quaternion.Euler(-90, 0, 0));
			// Play Explosion Sound
			Destroy (this.gameObject);
		}
	}
}
