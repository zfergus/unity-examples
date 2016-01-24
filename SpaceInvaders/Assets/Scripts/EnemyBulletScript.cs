using UnityEngine;
using System.Collections;
 
public class EnemyBulletScript : MonoBehaviour 
{ 
	private PlayerMovement playerScript;

	void Start()
	{
		playerScript = GameObject.FindGameObjectWithTag("Player").
			GetComponent<PlayerMovement>();
	}

    // Update is called once per frame
    void Update () 
    {
        transform.Translate(Vector3.down * 10 * Time.deltaTime);
        if(Camera.main.WorldToViewportPoint(this.transform.position).y < 0)
        {
            Destroy(this.gameObject);
        }
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			playerScript.LoseLive();
			Destroy(this.gameObject);
		}
		if (other.tag == "Barrier")
		{
			other.GetComponent<BarrierHealth>().DecreaseHealth();
			Destroy(this.gameObject);
		}
	}
}