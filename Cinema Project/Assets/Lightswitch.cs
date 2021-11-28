using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour

   
    
  {
    private Light myLight;
    private Collider col;


    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        
      

            if  (Input.GetKeyDown(KeyCode.E))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}