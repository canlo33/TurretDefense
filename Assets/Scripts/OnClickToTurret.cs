using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClickToTurret : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Turret" && hit.collider.gameObject.name == this.name)
                {
                    ShowRangeIndicator(true);

                }
                else
                {
                    ShowRangeIndicator(false);
                }

            }

        }



        void ShowRangeIndicator(bool status)
        {
            transform.Find("TowerRangeIndicator").gameObject.SetActive(status);

        }

    }
}


 

