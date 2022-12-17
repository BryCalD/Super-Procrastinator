using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup2 : MonoBehaviour
{

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Pickup();
        }
    }

    void Pickup()
    {
        Debug.Log("Powerup picked up!");
        transform.position = transform.position;
        Destroy(gameObject);
    }

}

