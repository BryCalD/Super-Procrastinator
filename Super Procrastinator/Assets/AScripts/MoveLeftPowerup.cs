using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftPowerup : MonoBehaviour
{
    private float speed = 7;
    private PlayerControl PlayerControl;
    private float destroy = -70;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControl.gameOver == false)
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        if(transform.position.x < destroy && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
