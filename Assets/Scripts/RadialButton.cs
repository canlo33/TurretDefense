using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RadialButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image circle;
    public Image icon;
    public string tittle;
    public RadialMenu myMenu;
    public Text buttonText;
    Color defaultColor;


    public void OnPointerEnter(PointerEventData eventData)
    {
        myMenu.selectedButton = this;
        defaultColor = circle.color;
        circle.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        myMenu.selectedButton = null;
        circle.color = defaultColor;
    }
}
