﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOnEnemy : MonoBehaviour
{

    private Transform target;
    public float turretRange = 30f;
    public Transform rotateTheGun;
    public float rotationSpeed = 15f;
    


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FindEnemy", 0f, 0.5f);
    }

   

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        RotateGunAtEnemy();
    }

     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, turretRange);
    }

    void FindEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        
        foreach (GameObject enemy in enemies)
        {
            float distanceOfEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceOfEnemy < shortestDistance)
            {
                shortestDistance = distanceOfEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= turretRange)
        {
            target = nearestEnemy.transform;
        }
        else
            target = null;

    }

    void RotateGunAtEnemy()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(rotateTheGun.rotation, lookRotation, Time.deltaTime * rotationSpeed).eulerAngles;
        rotateTheGun.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }
}