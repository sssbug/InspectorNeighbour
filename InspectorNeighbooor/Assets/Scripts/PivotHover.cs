using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PivotHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private Variables variables;

    private void OnEnable()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        variables.hover = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        variables.hover = false;
    }

}
