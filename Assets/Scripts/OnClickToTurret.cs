using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickToTurret : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                 if (hit.transform.gameObject.GetInstanceID() == gameObject.GetInstanceID())
                 {
                      ShowRangeIndicator(true);
                  }
                 else
                  {
                    ShowRangeIndicator(false);
                    return;
                  }
            }
        }

    }

    void ShowRangeIndicator(bool status)
    {
        this.transform.Find("TowerRangeIndicator").gameObject.SetActive(status);
        Debug.Log(gameObject);
        
    }
}
