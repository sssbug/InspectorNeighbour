using Hel.Interactables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDisable : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            { 
                Destroy(other.gameObject.GetComponent<InteractionHandler>());
            }
        
        }
    }
}
