using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClickToTurret : MonoBehaviour
{
    int uniqueId;

     void Start()
    {
        uniqueId = gameObject.GetInstanceID();
    }

   private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Turret" && hit.collider.gameObject.GetInstanceID() == uniqueId)
                {
                    // If turret is clicked, do followings
                    ShowRangeIndicator(true);

                }
                else
                {
                    // If somewhere else but turret is clicked, do followings
                    ShowRangeIndicator(false);
                }

            }

        }


    }


    void ShowRangeIndicator(bool status)
    {
        transform.Find("TowerRangeIndicator").gameObject.SetActive(status);
    }
    
}




