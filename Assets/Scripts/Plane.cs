using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour 
{
    public GameObject Ball;
   private void OnTriggerEnter()
   {

        Ball.SetActive(true);

   }

    private void OnTriggerExit()
    {
        Ball.SetActive(false);
    }
}
