using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuyTurret : MonoBehaviour, IDragHandler , IEndDragHandler , IPointerDownHandler, IPointerUpHandler
{
    public GameObject TurretToInstantiate;
    public Camera yourCam;
    public GameObject turretIcon;
    private GameObject clone;


    public void OnPointerDown(PointerEventData pointerEventData)
    {
               
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        clone = Instantiate(TurretToInstantiate);

    }

    public void OnDrag(PointerEventData eventData)
    {
        Ray ray = yourCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (!hit.collider.gameObject.name.Contains("ground"))
            {                
               clone.transform.position = hit.point;

            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Ray ray = yourCam.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{
        //    if(!hit.collider.gameObject.name.Contains("Cube"))
        //   {
        //       GameObject currentTurret = Instantiate(TurretToInstantiate);
        //        currentTurret.transform.position = hit.point;
                
        //    } else
        //    {
        //       Debug.Log("You can't place the turret here");
        //    }


        //}
    }




}
