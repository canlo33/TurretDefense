using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject turretPanel;

    public void OpenTurretMenu()
    {
        

        if (turretPanel.activeSelf)
        {

            turretPanel.SetActive(false);
        }
        else
        {

            turretPanel.SetActive(true);
        }

    }
}
