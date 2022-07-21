using Hel.Items.Currencies;
using Hel.Player;

using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Hel.Magic.Spellbooks
{
    /// <summary>
    /// TODO Split into smaller components.
    /// </summary>
    public class Spellbook : MonoBehaviour
    {
        [SerializeField] private PlayerStatsDataHolder playerStatsDataHolder = null;
        [SerializeField] private TextMeshProUGUI spellPointsText = null;
        [SerializeField] private List<ElementTree> elementTrees = new List<ElementTree>();
        [SerializeField] private SpellSlot[,] spellSlots = new SpellSlot[7, 3];
         
        private void Start()
        {
            if (elementTrees[0] != null)
            {
                DisplayTree(elementTrees[0]);
            }

            SetSpellPointsText();
        }

        public void SetSpellPointsText()
        {
            spellPointsText.text = $"Spell Points: {playerStatsDataHolder.CurrencyHolder.GetCurrencyAmount(CurrencyTypes.SpellPoints)}";
        }

        public void DisplayTree(ElementTree elementTree)
        {
            if (!elementTrees.Contains(elementTree)) { return; }

            for (int i = 0; i < spellSlots.GetLength(0); i++)
            {
                for (int j = 0; j < spellSlots.GetLength(1); j++)
                {
                    spellSlots[i, j].Initialise(elementTree.TreeSpells[i, j]);
                }
            }
        }
    }
}
