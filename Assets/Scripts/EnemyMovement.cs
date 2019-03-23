﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    private Transform target;
    private int waypointIndex = 0;

     void Start()
    {
        target = Waypoints.waypoints[0];
    }
    void Update()
    {
        Debug.Log(Waypoints.waypoints.Length);
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(target.position, transform.position) < 0.1f)
        {
            FindNextWaypoint();
        }
    }
    void FindNextWaypoint()
    {
        if (waypointIndex >= Waypoints.waypoints.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        waypointIndex++;
            target = Waypoints.waypoints[waypointIndex];
               
    }

}