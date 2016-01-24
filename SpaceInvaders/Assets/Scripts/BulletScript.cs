using UnityEngine;
using System.Collections;
 
public class BulletScript : MonoBehaviour 
{
    // Update is called once per frame
    void Update () 
    {
        transform.Translate(Vector3.up * 10 * Time.deltaTime);
        if(Camera.main.WorldToViewportPoint(this.transform.position).y > 1)
        {
            Destroy(this.gameObject);
        }
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
		{
			Destroy(other.gameObject);
			PlayerMovement.IncreaseScore();
			Destroy(this.gameObject);
		}
		if (other.tag == "Barrier")
		{
			other.GetComponent<BarrierHealth>().DecreaseHealth();
			Destroy(this.gameObject);
		}
	}
}