using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInteractables : MonoBehaviour
{
    [System.Serializable]
    public class Buttons
    {
        public string title;
        public Color color;
        public Sprite sprite;
        public string buttonTitles;
    }

    public Buttons[] menuOptions;

    private void Awake()
    {
        
    }

    private void OnMouseDown()
    {
        if(gameObject.GetComponent<Node>() && gameObject.GetComponent<Node>().turret == null)
        {
            RadialMenuSpawner.instance.SpawnMenu(this);
        }
        else if (!gameObject.GetComponent<Node>() && gameObject.transform.parent.gameObject.GetComponent<Node>().turret != null)
        {
            RadialMenuSpawner.instance.SpawnMenu(this);
        }

    

    }

}
