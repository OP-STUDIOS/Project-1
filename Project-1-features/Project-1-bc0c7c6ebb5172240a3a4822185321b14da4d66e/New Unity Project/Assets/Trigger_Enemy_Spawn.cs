﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;

public class Trigger_Enemy_Spawn : MonoBehaviour
{
    public GameObject enemyAI;
    public Transform spawnLocation;
    public Transform spawnLocation2;
    public Transform spawnLocation3;
    public Transform spawnLocation4;


    private bool done;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            SpawnEnemy();
            DestroySelf();
        }
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    private void SpawnEnemy()
    {
        if (!done)
        {
            Instantiate(enemyAI, spawnLocation.transform.position, spawnLocation.rotation);
            done = true;
            if (spawnLocation2 != null)
            {
                {
                    Instantiate(enemyAI, spawnLocation2.transform.position, spawnLocation2.rotation);
                    Debug.Log("spawn 2 present");
                }
            }
            if (spawnLocation3 != null)
            {
                {
                    Instantiate(enemyAI, spawnLocation3.transform.position, spawnLocation3.rotation);
                    Debug.Log("spawn 3 present");
                }
            }
            if (spawnLocation4 != null)
            {
                {
                    Instantiate(enemyAI, spawnLocation4.transform.position, spawnLocation4.rotation);
                    Debug.Log("spawn 4 present");
                }
            }
        }
    }
}
