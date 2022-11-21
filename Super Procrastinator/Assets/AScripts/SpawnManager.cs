using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obsPrefab;
    private Vector3 spawnpos = new Vector3(-5, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControl PlayerControl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        PlayerControl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    void SpawnObstacle()
    {
        int obsIndex = Random.Range(0, 5);

        if(PlayerControl.gameOver == false)
            Instantiate(obsPrefab[obsIndex], spawnpos, obsPrefab[obsIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
