using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class patron : MonoBehaviour
{
    public GameObject ball;
    public GameObject gun;
    public GameObject  ballclone;
    public float power;

   

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ballclone = Instantiate(ball, gun.transform.position, Quaternion.identity);
            ballclone.GetComponent<Rigidbody>().AddForce(gun.transform.forward * power * 10);
            Destroy(ballclone, 3);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire1")
        {
            ball.SetActive(true);
            
        } 
        else if (other.gameObject.tag == "Rubbel1")
        {
            Destroy(ballclone);
        }
    }
}
   

