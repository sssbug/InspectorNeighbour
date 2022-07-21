
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Hel.Items.Inventories
{
    /// <summary>
    /// Handles logic involved when dragging from an inventory slot.
    /// </summary>
    public class InventoryItemDragHandler : ItemDragHandler
    {
        private Variables variables;
        
        private void OnEnable()
        {
           variables = GameObject.Find("VariablesController").GetComponent<Variables>();
        }

        private void Update()
        {
            
            if (Input.GetMouseButtonDown(0) && !variables.hover)
            {
                if (variables.pivot.activeSelf)
                {
                    variables.pivot.SetActive(false);
                    variables.hover = false;

                }
            }
        }

        
        [SerializeField] private ItemDestroyer itemDestroyer = null;
        public override void OnPointerUp(PointerEventData eventData)
        {
            //Check whether it was the left mouse button that was released.
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                //Handle the base logic.
                base.OnPointerUp(eventData);

                //Make sure that the cursor is not currently over any UI.
                
                if (eventData.hovered.Count <= 0)
                {
                    //Activate the item destroyer with this item slot's data.
                    
                    InventorySlot thisSlot = itemSlotUI as InventorySlot;
                    itemDestroyer.Activate(thisSlot.ItemSlot.item, thisSlot.SlotIndex);
                }
                
            }
            if (eventData.button == PointerEventData.InputButton.Right)
            {
                //Handle the base logic.
                base.OnPointerUp(eventData);

                //Make sure that the cursor is not currently over any UI.
                if (eventData.hovered.Count == 0)
                {
                    variables.thisSlott = itemSlotUI as InventorySlot;
                    variables.pivot.SetActive(true);
                    variables.pivot.transform.position = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
                }
            }
        }

       
        
    }
}