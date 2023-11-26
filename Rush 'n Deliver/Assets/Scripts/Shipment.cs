using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipment : MonoBehaviour
{
    bool hasPackage = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if((other.gameObject.tag == "Shipment") && (!hasPackage))
        {
            Debug.Log("Shipment picked up!");
            hasPackage = true;
            Destroy(other.gameObject, 0.8f);
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if((other.gameObject.tag == "Customer") && (hasPackage))
        {
            Debug.Log("Shipment delivered!");
            hasPackage = false;
            Destroy(other.gameObject, 0.8f);
        }
    }
}
