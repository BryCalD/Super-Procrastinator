using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject[] powerup;
    private float startDelay = 6f;
    private PlayerControl PlayerControl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerups", startDelay, (Random.Range(15,20)));
        PlayerControl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void SpawnPowerups()
    {
        int powerIndex = Random.Range(0,2);
        Vector3 spawnPos = new Vector3(Random.Range(0, 10), Random.Range(1, 5), 0);
        if(PlayerControl.gameOver == false)
            Instantiate(powerup[powerIndex], spawnPos, powerup[powerIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

