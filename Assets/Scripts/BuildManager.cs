using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    private GameObject turretToBuild;

    
    private void Awake()
    {
        instance = this;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }


}
