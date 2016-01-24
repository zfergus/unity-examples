using UnityEngine;
using System.Collections;

public class BarrierHealth : MonoBehaviour
{
	private int health;

	// Use this for initialization
	void Start ()
	{
		health = 5;
 	}
	
	// Update is called once per frame
	void Update ()
	{
		if (this.health <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	public void DecreaseHealth()
	{
		this.health--;
		Color color = this.GetComponent<Renderer> ().material.color;
		this.GetComponent<Renderer>().material.color = new Color(color.r, color.g, color.b, health / 5.0f);
	}
}
