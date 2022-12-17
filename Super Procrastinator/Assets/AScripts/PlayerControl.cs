using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip Caught;
    public AudioClip Obs;
    public ParticleSystem dust;
    private Rigidbody PlayerRb;
    public bool isOnGround = true;
    public bool gameOver = false;
    private ScoreManager theScoreManager;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

     if(Input.GetKeyDown(KeyCode.W) && isOnGround){
        PlayerRb.AddForce(Vector3.up * 200, ForceMode.Impulse);
        playerAnim.SetBool("IsJumping", true);
        isOnGround = false;
        dust.Stop();
     }

     if(Input.GetKeyDown(KeyCode.S)){
         PlayerRb.AddForce(Vector3.down * 250, ForceMode.Impulse);
         isOnGround = false;
     }      
    }

    public IEnumerator OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
            playerAnim.SetBool("IsJumping", false);
            Createdust();
        }else if(collision.gameObject.CompareTag("Obstacle")){
            playerAudio.PlayOneShot(Obs, 0.5f);
        }else if(collision.gameObject.CompareTag("DeathOver")){
            gameOver = true;
            playerAudio.PlayOneShot(Caught, 1.0f);
            theScoreManager.scoreIncrease = false;
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(2);
        }
    }

    void Createdust()
    {
        dust.Play();
    }
}
