using UnityEngine;
using System.Collections;
 
public class ScreenCollision : MonoBehaviour 
{
    public EnemyMovement moverScript;
    
	private float timer;

	void Start()
	{
		timer = 0.0f;
	}
	
    void Update () 
    {
		timer += Time.deltaTime;
        if(Camera.main.WorldToViewportPoint( this.transform.position ).x > 0.95f ||
		   Camera.main.WorldToViewportPoint( this.transform.position ).x < 0.05f)        
        {
			if(timer > 0.6)
			{
           		moverScript.HitAWall();
				timer = 0.0f;
			}
        }
    }
}