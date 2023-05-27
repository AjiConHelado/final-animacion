using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] ConstrainControl pam;
  void start()
    {
        //pam.proceduralInfluence = 0f;
    }
    /* public void OnCollisionEnter()
     {
         Debug.Log("aaaaaaaaaaaaaaaaaa");

         pam.UpdateInfuelnce(0.7f);
     }*/
    float lerptime = 2f;
    float value;
   
        
     void OnTriggerEnter()
    {
       
        pam.UpdateInfuelnce(0.5f);
    }
    void OnTriggerExit()
    {
        pam.UpdateInfuelnce(0f);
    }

  
}
