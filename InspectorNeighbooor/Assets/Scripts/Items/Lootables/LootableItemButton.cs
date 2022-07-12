using Hel.Events.CustomEvents;
using Hel.Player;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Hel.Items.Lootables
{
    /// <summary>
    /// Handles interactions with lootable item buttons.
    /// </summary>
    public class LootableItemButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
    {
         [SerializeField] private TextMeshProUGUI itemNameText = null;
         [SerializeField] private Image itemIconImage = null;
         [SerializeField] private TextMeshProUGUI itemQuantityText = null;
         [SerializeField] private PlayerInventory playerInventory = null;
         [SerializeField] private HotbarItemEvent onMouseStartHoverItem = null;
         [SerializeField] private VoidEvent onMouseEndHoverItem = null;

        private LootableItemsDisplayer lootableItemsDisplayer = null;
        private ItemSlot itemSlot = new ItemSlot();

        private void OnDisable() => onMouseEndHoverItem.Raise();

        public void Initialise(LootableItemsDisplayer lootableItemsDisplayer, ItemSlot itemSlot)
        {
            this.lootableItemsDisplayer = lootableItemsDisplayer;
            this.itemSlot = itemSlot;

            UpdateUI();
        }

        public void OnPointerEnter(PointerEventData eventData) => onMouseStartHoverItem.Raise(itemSlot.item);

        public void OnPointerClick(PointerEventData eventData) => Loot();

        public void OnPointerExit(PointerEventData eventData) => onMouseEndHoverItem.Raise();

        public void Loot()
        {
            //Add the item to the player's inventory.
            itemSlot = playerInventory.ItemHolder.AddItem(itemSlot);

            //Check to see if all of the item was added to the inventory.
            if (itemSlot.quantity <= 0)
            {
                Destroy(gameObject);
            }

            //Update the panel's UI
            lootableItemsDisplayer.UpdateItemSlot(itemSlot);

            //Update our UI
            UpdateUI();
        }

        private void UpdateUI()
        {
            itemNameText.text = itemSlot.item.ColouredName;
            itemIconImage.sprite = itemSlot.item.Icon;
            itemQuantityText.text = itemSlot.quantity.ToString();
        }
    }
}
