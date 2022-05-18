using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int collectedCoinsCount = 0;
    private void OnTriggerEnter(Collider other) // Reference to collider Object
    // other represents the collider
    {
        Debug.Log(message: "Collided with " + other.gameObject.name);

        // Reference gameObject ; 
        CoinTag coinTag = other.gameObject.GetComponent<CoinTag>();
        bool isCoin = (coinTag != null); // 

        if (isCoin)
        {
            other.gameObject.SetActive(false);
            collectedCoinsCount++;
        }

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(message: "Collided with " + collision.gameObject.name);
    }
    */
}

// Notes
// Is kinematic -> Coin stops reacting to external influence
// Trigger -> Detects collisions but it does not have influence at other objects