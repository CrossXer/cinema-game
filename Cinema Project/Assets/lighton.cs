using UnityEngine;
using System.Collections;

public class lighton : MonoBehaviour
{
    //this tells that im going to use gameobject light (game objects are light, shapes etc.)
    public GameObject light;
    

    //this tells that if Im touching something 
    void OnTriggerStay(Collider gay)
    { 
        if (gay.gameObject.tag == "Player")
        {
            

            if (Input.GetKeyDown(KeyCode.E))
             

            {
                // toggle the light. If off turn it on,  if on turn it off
                light.SetActive(!light.activeSelf);
                // update the texts based on the new active state.

            }
        }
    }
}