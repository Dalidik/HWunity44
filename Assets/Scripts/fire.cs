using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject ball;
    public GameObject gun;
    public GameObject ballclone;
    public float power;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ballclone = Instantiate(ball, gun.transform.position, Quaternion.identity);
            ballclone.GetComponent<Rigidbody>().AddForce(gun.transform.forward * power * 10);
            Destroy(ballclone, 3);
        }
    }
   
}
