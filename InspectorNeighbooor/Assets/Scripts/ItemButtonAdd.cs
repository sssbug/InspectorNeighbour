using Hel.Items;
using Hel.Items.Inventories;
using Hel.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonAdd : MonoBehaviour
{
    [SerializeField] private PlayerInventory Inventory = null;
    public List<ConsumableItem> Con = new List<ConsumableItem>();
    private Variables variables;

    
    private void OnEnable()
    {

        variables = GameObject.Find("VariablesController").GetComponent<Variables>();

    }
    public void Add()
    {
        if (variables.onInspected)
        {
            for (int i = 0; i < Con.Count; i++)
            {
                if (Con[i].name == variables.inspected.name)
                {

                    Inventory.testItemSlot.item = Con[i];
                    Inventory.TestAdd();
                    variables.mouseLock = true;
                    variables.mouseVisible = false;
                    variables.screenLock = false;
                    variables.MovementLock = false;
                    gameObject.SetActive(false);
                    variables.ObjectList.Remove(variables.inspected);
                    Destroy(variables.inspected);
                    variables.inspected = null;
                    variables.onInspected = false;
                }

            }
        }
        

    }








}