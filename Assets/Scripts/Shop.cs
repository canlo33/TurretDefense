using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject turretPanel;

    public void OpenTurretMenu()
    {
        Debug.Log("Clicked on Shop Button..");

        if (turretPanel.activeSelf)
        {
            Debug.Log("Panel is active, close it..");
            turretPanel.SetActive(false);
        }
        else
        {
            Debug.Log("Panel is inactive, open it..");
            turretPanel.SetActive(true);
        }

    }
}
