using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWave : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
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
