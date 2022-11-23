using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject[] powerup;
    private Vector3 spawnpos = new Vector3(-5, 4, 0);
    private float startDelay = 6;
    private PlayerControl PlayerControl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerups", startDelay, (Random.Range(20,35)));
        PlayerControl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void SpawnPowerups()
    {
        int powerIndex = Random.Range(0,0);

        if(PlayerControl.gameOver == false)
            Instantiate(powerup[powerIndex], spawnpos, powerup[powerIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

