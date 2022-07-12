using Hel.Events.CustomEvents;
using UnityEngine;

namespace Hel.Cursors
{
    /// <summary>
    /// Used to alert listeners that a cursor blocker has been enabled/disabled.
    /// </summary>
    public class CursorBlocker : MonoBehaviour
    {
        [SerializeField] private VoidEvent onCursorBlockerEnabled = null;
        [SerializeField] private VoidEvent onCursorBlockerDisabled = null;

        private void OnEnable() => onCursorBlockerEnabled.Raise();
        private void OnDisable() => onCursorBlockerDisabled.Raise();
    }
}

