using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class RobotMove : MonoBehaviour
{
    

    public float movementSpeed;
    public float rotationSpeed;
    Rigidbody body;
    

    
    
    void Start()
    {
       body = GetComponent<Rigidbody>();
      
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
  
    
    
   
}
