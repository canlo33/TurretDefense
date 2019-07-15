using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer rend;
    private GameObject turret;
    private Color startColor;
    public Color hoverColor;
        

     void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

     void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    void OnMouseDown()
    {
        if(turret == null)
        {
            Debug.Log("Open the Builder Menu");
        }
        else
        {
            Debug.Log("Open Upgrade/Sell Menu");
        }
        
    }
}
