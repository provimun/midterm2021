using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupDestroy : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
    {
       if (col.gameObject.name == "adderall pickup(Clone)"
       || col.gameObject.name == "gum pickup(Clone)"
       || col.gameObject.name == "banana pickup(Clone)"
       || col.gameObject.name == "pizza pickup(Clone)"
       || col.gameObject.name == "music pickup(Clone)"
       || col.gameObject.name == "phone pickup(Clone)"
       || col.gameObject.name == "controller pickup(Clone)"
       || col.gameObject.name == "textbook pickup(Clone)"
       || col.gameObject.name == "essay pickup(Clone)"
       || col.gameObject.name == "laptop pickup(Clone)"){
            Destroy(col.gameObject);
        }
    }
}
