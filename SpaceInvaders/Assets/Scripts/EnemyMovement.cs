//Expand for the EnemyMovement script
using UnityEngine;
using System.Collections;
 
public class EnemyMovement : MonoBehaviour 
{
    private int speed = 5;
    public int direction = 1;
	public int moveState = 0;
	public float timer = 0.0f;
     
	public bool justSwitched = false;

    // Update is called once per frame
    void Update () 
    {
        if(moveState == 0)
        {
            MoveLeftAndRight();
        }
        if(moveState == 1)
        {
            MoveDown();
        }
    }
 
    private void MoveLeftAndRight()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
        justSwitched = false;
    }
 
    private void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        timer += Time.deltaTime;
        if(timer > 0.5f)
        {
            SwitchDirection();
        }
    }
 
    public void HitAWall()
    {
        if (moveState == 0 && !justSwitched)
		{
			moveState = 1;
		}
    }
 
    private void SwitchDirection()
    {
        direction *= -1; // direction = direction * -1;
        timer = 0;
        justSwitched = true;
        moveState = 0;
    }
}
