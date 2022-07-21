using Hel.Combat;
using Hel.Extensions;
using Hel.Inputs;
using UnityEngine;

namespace Hel.Player.StateBehaviours
{
    public class PlayerBowIdleStateBehaviour : SceneLinkedSMB<PlayerMovementController>
    {
         [SerializeField] private PlayerInventory inventory;
         [SerializeField] private AmmunitionType ammunitionType;

        private static readonly int hashIsDrawingArrow = Animator.StringToHash("IsDrawingArrow");

        public override void OnSLTransitionToStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (PlayerInputManager.LeftClickHeld)
            {
                CheckForAmmunition(animator);
            }
        }

        public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (PlayerInputManager.LeftClickPressed)
            {
                CheckForAmmunition(animator);
            }
        }

        private void CheckForAmmunition(Animator animator)
        {
            if (!inventory.ItemHolder.HasAmmunition(ammunitionType)) { return; }

            animator.SetBool(hashIsDrawingArrow, true);
        }
    }
}
