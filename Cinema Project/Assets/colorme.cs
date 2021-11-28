using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorme : MonoBehaviour
{

    void OnTriggerStay(Collider gay)
    {

        if (gay.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
         
                GetComponent<Renderer>().material.color = Color.yellow;

        if (gay.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))

            GetComponent<Renderer>().material.color = Color.red;
    }
         
    }

    