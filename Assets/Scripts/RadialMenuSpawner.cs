using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenuSpawner : MonoBehaviour
{
    public static RadialMenuSpawner instance;
    public RadialMenu menuPrefab;

    private void Awake()
    {
        instance = this;
    }

    public void SpawnMenu(MenuInteractables menuOptions)
    {
        RadialMenu newMenu = Instantiate(menuPrefab) as RadialMenu;
        newMenu.transform.SetParent(transform, false);
        newMenu.transform.position = Input.mousePosition;
        newMenu.SpawnButtons(menuOptions);
        newMenu.selectedNode = menuOptions.gameObject;
    }

}
