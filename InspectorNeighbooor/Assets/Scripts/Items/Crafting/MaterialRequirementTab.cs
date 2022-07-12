
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Hel.Items.Crafting
{
    public class MaterialRequirementTab : MonoBehaviour
    {
        [SerializeField] private Image materialImage;
        [SerializeField] private TextMeshProUGUI materialQuantityText;

        public void SetData(ItemHolder itemHolder, ItemSlot itemSlot)
        {
            materialImage.sprite = itemSlot.item.Icon;

            int materialTotalCound = itemHolder.GetTotalQuantity(itemSlot.item);

            materialQuantityText.text = materialTotalCound >= itemSlot.quantity
                ? $"<color=green>{materialTotalCound}/{itemSlot.quantity}</color>"
                : $"<color=red>{materialTotalCound}/{itemSlot.quantity}</color>";

            gameObject.SetActive(true);
        }

        public void Clear()
        {
            gameObject.SetActive(false);
        }
    }
}
