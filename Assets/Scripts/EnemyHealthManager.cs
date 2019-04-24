using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public float health = 100f;

    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

   public void damageEnemy(float damage)
    {
        health -= damage;
    }
}
