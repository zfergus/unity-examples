using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Target")
		{
			ScoreManager sm;
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			if (player != null)
			{
				sm = player.GetComponent<ScoreManager>();
				if(sm != null)
				{
					sm.IncreaseScore();
				}
			}
			else
			{
				Debug.LogWarning("Forgot to tag player as Player.");
			}

			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
	}
}
