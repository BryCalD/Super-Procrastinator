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
    public bool isOnGround = true;
    public bool gameOver = false;

    void Update()
    {
     if(Input.GetKeyDown(KeyCode.W) && isOnGround){
         PlayerRb.AddForce(Vector3.up * 100, ForceMode.Impulse);
         isOnGround = false;
     }   
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
        } else if(collision.gameObject.CompareTag("Obstacle")){
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
