
using System.Text;
using TMPro;
using UnityEngine;

namespace Hel.Targeting
{
    /// <summary>
    /// Placeholder class to display what is currently being targeted.
    /// </summary>
    public class TargetingUI : MonoBehaviour
    {
        [SerializeField] private GameObject targetingUI = null;
        [SerializeField] private TextMeshProUGUI currentTargetsText = null;

        private TargetGetter currentTargetGetter = null;

        public void DisplayTargets(TargetGetter targetGetter)
        {
            currentTargetGetter = targetGetter;
            targetingUI.SetActive(true);
        }

        public void HideTargets()
        {
            currentTargetsText.text = "";
            currentTargetGetter = null;
            targetingUI.SetActive(false);
        }

        private void Update()
        {
            if (currentTargetGetter == null) { return; }

            StringBuilder builder = new StringBuilder();

            builder.Append("Targeting: ");
            foreach (ITargetable target in currentTargetGetter.CurrentTargets)
            {
                builder.Append(target.name).Append(", ");
            }
            builder.Length -= 2;

            currentTargetsText.text = builder.ToString();
        }
    }
}
