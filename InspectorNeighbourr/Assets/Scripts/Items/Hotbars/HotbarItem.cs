
using UnityEngine;

namespace Hel.Items.Hotbars
{
    /// <summary>
    /// The base class for anything that is able to go on the hotbar.
    /// </summary>
    public abstract class HotbarItem : ScriptableObject
    {
        [Header("Basic Info")]
        [SerializeField] private new string name = "New Hotbar Item Name";
        [SerializeField] private Sprite icon = null;

        public string Name { get { return name; } }
        public abstract string ColouredName { get; }
        public Sprite Icon { get { return icon; } }

        public abstract string GetInfoDisplayText();
    }
}