using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialMenu : MonoBehaviour
{
    public RadialButton buttonPrefab;
    public RadialButton selectedButton;
    public GameObject turretX;
    public GameObject turretXLevel2;
    public GameObject selectedNode;





    public void SpawnButtons(MenuInteractables menuOptions)
    {
        for (int i = 0; i < menuOptions.menuOptions.Length; i++)
        {
            
            RadialButton newButton = Instantiate(buttonPrefab) as RadialButton;
            newButton.transform.SetParent(transform, false);
            float theta = (2 * Mathf.PI / menuOptions.menuOptions.Length) * i;
            float xPos = Mathf.Sin(theta);
            float yPos = Mathf.Cos(theta);
            newButton.transform.localPosition = new Vector3(xPos, yPos, 0.2f) *30f;
            newButton.circle.color = menuOptions.menuOptions[i].color;
            newButton.icon.sprite = menuOptions.menuOptions[i].sprite;
            newButton.tittle = menuOptions.menuOptions[i].title;
            newButton.buttonText.text = menuOptions.menuOptions[i].buttonTitles;
            newButton.myMenu = this;
        }

    }

    private void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Destroy(gameObject);
            if(selectedButton != null && selectedButton.tittle == "TurretX")
            {
                // Buying TurretX when selected
                if(GameMaster.instance.player.playerGold >= 50f)
                {
                    selectedNode.GetComponent<Node>().InstatiateTurret(turretX);
                    GameMaster.instance.player.playerGold -= 50f;
                    Debug.Log(GameMaster.instance.player.playerGold);
                }
                                
            }
                
            else if (selectedButton != null && selectedButton.tittle == "SellX")
            {
                // Selling TurretX
                Destroy(selectedNode.gameObject.transform.parent.GetChild(0).gameObject);
            }

            else if (selectedButton != null && selectedButton.tittle == "SellX2")
            {
                // Selling TurretX2
                Destroy(selectedNode.gameObject.transform.parent.GetChild(0).gameObject);
            }

            else if (selectedButton != null && selectedButton.tittle == "UpgradeX")
            {
                // Upgrading TurretX to TurretXLevel2 when selected
                if (GameMaster.instance.player.playerGold >= 100f)
                {                    
                    Destroy(selectedNode.gameObject.transform.parent.GetChild(0).gameObject);
                    selectedNode.gameObject.transform.parent.GetComponent<Node>().InstatiateTurret(turretXLevel2);
                    GameMaster.instance.player.playerGold -= 100f;
                }
                 
            }
        }
    }

}
