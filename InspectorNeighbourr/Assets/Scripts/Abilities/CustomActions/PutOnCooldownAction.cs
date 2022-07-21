
using System;
using System.Collections;
using UnityEngine;

namespace Hel.Abilities.CustomActions
{
    /// <summary>
    /// Used to put item on cooldown.
    /// </summary>
    [Serializable]
    public class PutOnCooldownAction : AbilityAction
    {
        [SerializeField] private AbilityCooldownDataHolder abilityCooldownDataHolder = null;
        [SerializeField] private ICooldownable cooldown = null;

        public override IEnumerator Trigger(AbilityCastData abilityCastData)
        {
            //Put the item on cooldown.
            abilityCooldownDataHolder.PutOnCooldown(cooldown);

            yield return null;
        }
    }
}