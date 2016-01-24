using UnityEngine;
using System.Collections;
 
public class PlayerProjectile : MonoBehaviour 
{
    public GameObject spawnPosObj;
    public GameObject bullet;
     
    // Update is called once per frame
    void Update () 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, spawnPosObj.transform.position, Quaternion.identity);
        }
    }
}