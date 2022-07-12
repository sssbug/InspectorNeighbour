
using UnityEngine;

namespace Hel.Abilities
{
    /// <summary>
    /// Used to tick and listen to events for an ability channel data holder.
    /// </summary>
    public class AbilityChannelSystem : MonoBehaviour
    {
        [SerializeField] private AbilityChannelDataHolder abilityChannelDataHolder = null;

        private void Update()
        {
            abilityChannelDataHolder.Tick();
        }
    }
}
