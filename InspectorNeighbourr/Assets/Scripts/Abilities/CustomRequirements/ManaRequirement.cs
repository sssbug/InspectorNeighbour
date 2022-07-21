using Hel.Player;
using System;
using UnityEngine;

namespace Hel.Abilities.CustomRequirements
{
    /// <summary>
    /// Used to check whether the player has enough mana to use the item or not.
    /// </summary>
    [Serializable]
    public class ManaRequirement : AbilityRequirement
    {
        [SerializeField] private PlayerStatsDataHolder playerStatsDataHolder;
        [SerializeField] private int requiredMana;

        public override bool IsMet() => playerStatsDataHolder.Mana >= requiredMana;

        public override string GetDisplayText() => $"Mana Cost: {requiredMana}";
    }
}

