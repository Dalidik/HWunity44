using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class RobotMove : MonoBehaviour
{
    

  public float movementSpeed;
  public float rotationSpeed;
    Rigidbody body;
     fire _fire;
    public GameObject fireBall;

    
    void Start()
    {
       body = GetComponent<Rigidbody>();
        _fire = fireBall.GetComponent<fire>();
    }

    
    void Update()
    {
        
        float sideForse = Input.GetAxis("Horizontal") * rotationSpeed;
        if(sideForse != 0.0f)
        {
            body.angularVelocity = new Vector3(0.0f, sideForse, 0.0f);
        }

        float forwardForce = Input.GetAxis("Vertical") * movementSpeed;
        if(forwardForce != 0.0f)
        {
            body.velocity = body.transform.forward * forwardForce;
        }
    }
  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire1" )
        {
            _fire.GetComponent<fire>().enabled = true;
            Debug.Log("+");

        }
        else if (other.gameObject.tag == "Ruber")
        {
            _fire.GetComponent<fire>().enabled = false;
            Debug.Log("-");
        }
        else if (other.gameObject.tag == "Explode")
        {
            _fire.GetComponent<fire>().enabled = false;
            Debug.Log("-+");
        }
    }
    

}
