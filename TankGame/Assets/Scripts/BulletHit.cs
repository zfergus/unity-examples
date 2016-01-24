using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "EnemyTank")
		{
			//Destroy(other.gameObject);
			EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
			if(enemyHealth != null)
			{
				enemyHealth.DecreaseHealth();
			}
			else
			{
				Debug.LogWarning("No EnemyHealth found on EnemyTank.");
			}
			Destroy(this.gameObject);
		}
	}
}
