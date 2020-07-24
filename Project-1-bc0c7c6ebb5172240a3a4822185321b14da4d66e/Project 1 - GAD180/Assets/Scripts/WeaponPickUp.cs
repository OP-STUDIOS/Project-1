using System.Collections;
using System.Collections.Generic;
using Opsive.UltimateCharacterController.Items;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{

    void OnTriggerEnter(Collider _collider)
    {
        if(_collider.gameObject.tag == "Player")
        {
            // Find current item perspective
            // Add current item bullet value & item value
            
        }
    }
}

