using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubber : MonoBehaviour
{
    public GameObject ball;
    public GameObject gun;
    public GameObject ballclone;
    public float power;


 
    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            ballclone = Instantiate(ball, gun.transform.position, Quaternion.identity);
            ballclone.GetComponent<Rigidbody>().AddForce(gun.transform.forward * power * 10);
            Destroy(ballclone, 2);
        }
    }
   
}
