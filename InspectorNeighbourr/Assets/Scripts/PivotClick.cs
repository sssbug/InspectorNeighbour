using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotClick : MonoBehaviour
{
    private Variables variables;

    private void OnEnable()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }
    public void Del()
    {
        variables.itemDestroyer.Activate(variables.thisSlott.ItemSlot.item, variables.thisSlott.SlotIndex);
        variables.pivot.SetActive(false);
    }
}
