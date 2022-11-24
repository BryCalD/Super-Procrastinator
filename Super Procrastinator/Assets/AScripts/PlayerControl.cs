using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public bool isOnGround = true;
    public bool gameOver = false;
    private ScoreManager theScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.W) && isOnGround){
         PlayerRb.AddForce(Vector3.up * 200, ForceMode.Impulse);
         isOnGround = false;
     }   
    }
    public IEnumerator OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
        } else if(collision.gameObject.CompareTag("DeathOver")){
            gameOver = true;
            theScoreManager.scoreIncrease = false;
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(2);
        }
    }
    
}
