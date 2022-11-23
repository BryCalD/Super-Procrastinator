using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public float multiplier = 0.3f;
    public float duration = 6f;
    
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider Player){
        Debug.Log("Powerup picked up!");
        Player.transform.localScale *= multiplier;
        Player.GetComponent<BoxCollider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(duration);
        Player.transform.localScale /= multiplier;
        Player.GetComponent<BoxCollider>().enabled = true;
        Destroy(gameObject);
    }
}

