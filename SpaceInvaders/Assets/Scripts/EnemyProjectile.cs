using UnityEngine;
using System.Collections;
 
public class EnemyProjectile : MonoBehaviour 
{
    public GameObject spawnPosObj;
    public GameObject bullet;
     
    // Update is called once per frame
    void Update () 
    {
        if(((int)Random.Range(0, 200)) == 50)
        {
            Instantiate(bullet, spawnPosObj.transform.position, Quaternion.identity);
        }
    }
}