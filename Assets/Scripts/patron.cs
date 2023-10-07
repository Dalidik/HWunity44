using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class patron : MonoBehaviour
{
    public GameObject ball;
    public GameObject gun;
    public GameObject ballclone;
    public float power;


  
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            ballclone = Instantiate(ball, gun.transform.position, Quaternion.identity);
            ballclone.GetComponent<Rigidbody>().AddForce(gun.transform.forward * power * 10);
            Destroy(ballclone, 3);
        }
    }
    
}
   

