using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
   public float radius = 5.0F; 
   public float power = 10.0F; 
   public float lift = 30; 
   public float speed = 40; 
   public bool exploder = false;
    public GameObject explosion;
    public Rigidbody patrons;
    



    void Update()
    {


        if (Input.GetMouseButtonDown(0))

        {
            Rigidbody clonePatrons;
            clonePatrons = Instantiate(patrons, transform.position, Quaternion.identity);
            clonePatrons.velocity = transform.TransformDirection(Vector3.forward * speed);

        }

    }

    void FixedUpdate() { 
      if(exploder){ 
         Vector3 explosionPos = transform.position; 
         Collider[] colliders = Physics.OverlapSphere(explosionPos, radius); 
         foreach (Collider hit in colliders) { 
            if (hit.GetComponent<Rigidbody>()) { 
               hit.GetComponent<Rigidbody>().AddExplosionForce(power, explosionPos, radius, lift); 
            } 
         } 
       } 
   } 
   void OnCollisionEnter(Collision collision) {    
      if(collision.gameObject.tag == "Enemy"){ 
         exploder = true;
            Instantiate(explosion, transform.position, Quaternion.identity);
        } 
   }



    
}
