using Hel.Items.Inventories;
using Hel.Player;
using System;
using System.Collections;
using UnityEngine;

namespace Hel.Abilities.CustomActions
{
    /// <summary>
    /// Used to remove an item from the player's inventory.
    /// </summary>
    [Serializable]
    public class RemoveItemAction : AbilityAction
    {
        [SerializeField] private PlayerInventory playerInventory = null;
        [SerializeField] private InventoryItem itemToRemove = null;
        [SerializeField] private int quantityToRemove = 1;

        public override IEnumerator Trigger(AbilityCastData abilityCastData)
        {
            //Remove the desired quantity of the desired item from the player's inventory.
            playerInventory.ItemHolder.RemoveItem(itemToRemove, quantityToRemove);

            yield return null;
        }
    }
}