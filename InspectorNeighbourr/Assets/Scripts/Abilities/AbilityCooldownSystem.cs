
using UnityEngine;

namespace Hel.Abilities
{
    /// <summary>
    /// Used to tick and listen to events for an ability cooldown data holder.
    /// </summary>
    public class AbilityCooldownSystem : MonoBehaviour
    {
        [SerializeField] private AbilityCooldownDataHolder abilityCooldownDataHolder = null;

        private void Update()
        {
            abilityCooldownDataHolder.Tick();
        }
    }
}
