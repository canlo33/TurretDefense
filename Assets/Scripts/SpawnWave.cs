﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWave : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()

    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
