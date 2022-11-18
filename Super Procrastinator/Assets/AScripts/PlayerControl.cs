using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space)){
         PlayerRb.AddForce(Vector3.up * 100, ForceMode.Impulse);
     }   
    }
}
