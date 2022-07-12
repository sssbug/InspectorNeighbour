
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Hel.Items.Crafting
{
    public class RecipeButton : MonoBehaviour
    {
        [SerializeField] private Button recipeButton = null;
        [SerializeField] private Image resultImage = null;
        [SerializeField] private TextMeshProUGUI resultNameText = null;

        private Recipe thisRecipe;

        public void Initialise(CraftingSystem craftingSystem, Recipe recipe)
        {
            thisRecipe = recipe;

            recipeButton.onClick.AddListener(() => craftingSystem.SetRecipe(thisRecipe));

            SetButtonUI();
        }

        private void SetButtonUI()
        {
            resultImage.sprite = thisRecipe.Result.item.Icon;
            resultNameText.text = thisRecipe.Result.item.ColouredName;
        }
    }
}
