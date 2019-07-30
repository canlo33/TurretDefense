using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer rend;
    public GameObject turret;
    private Color startColor;
    public Color hoverColor;
    private bool isClicked = false;

    public void InstatiateTurret(GameObject turretToSpawn)
    {
        turret = Instantiate(turretToSpawn, transform.position, transform.rotation);
        turret.transform.SetParent(gameObject.transform);
    }

    void Start()
        {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        }

     void Update()
        {
        if (Input.GetMouseButtonDown(0) && turret == null)
        {
            isClicked = true;
        }
        if (Input.GetMouseButtonUp(0) && turret == null)
        {
            isClicked = false;
            rend.material.color = startColor;
        }
        }

     void OnMouseOver()
        {
        if (turret == null && !isClicked)
        {
            // If I dont already have a turret. Whenever my mouse is on the node, it changes to its color to hoverColor.
            rend.material.color = hoverColor;
            
        }
        }

     void OnMouseExit()
        {
        // Resets the node's color back to default.
        if (!isClicked)
        {
            rend.material.color = startColor;
        }
     

      

        }


   


}
