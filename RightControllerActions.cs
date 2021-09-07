using _Project.Scripts;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Actions
{
    public class RightControllerActions : MonoBehaviour, XRIDefaultInputActions.IXRIRightHandActions
    {
        private XRIDefaultInputActions controls;
        [SerializeField] private Player player;
        [SerializeField] private PrimaryWeaponController primaryWeaponController;
        
        private void OnEnable()
        {
            if (controls == null)
            {
                controls = new XRIDefaultInputActions();
                controls.XRIRightHand.SetCallbacks(this);
            }
            controls.XRIRightHand.Enable();
        }
        public void OnPosition(InputAction.CallbackContext context)
        {
        }

        public void OnRotation(InputAction.CallbackContext context)
        {
        }

        public void OnSelect(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                var hits = Physics.OverlapSphere(transform.position, 0.5f, 1 << LayerMask.NameToLayer("Item"));
                foreach (var hit in hits)
                {
                    var item = hit.GetComponent<Item>();
                    player.Inventory.Add(item);
                }
            }
        }

        public void OnActivate(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                var go = primaryWeaponController.GetCurrent();
                if (go != null)
                    go.GetComponent<IActivatable>()?.Activate();
            }
        }

        public void OnUIPress(InputAction.CallbackContext context)
        {
        }

        public void OnHapticDevice(InputAction.CallbackContext context)
        {
        }

        public void OnTeleportSelect(InputAction.CallbackContext context)
        {
        }

        public void OnTeleportModeActivate(InputAction.CallbackContext context)
        {
        }

        public void OnTeleportModeCancel(InputAction.CallbackContext context)
        {
        }

        public void OnTurn(InputAction.CallbackContext context)
        {
        }

        public void OnMove(InputAction.CallbackContext context)
        {
        }

        public void OnRotateAnchor(InputAction.CallbackContext context)
        {
        }

        public void OnTranslateAnchor(InputAction.CallbackContext context)
        {
        }

        public void OnPrimaryButtonPress(InputAction.CallbackContext context)
        {
        }

        public void OnSecondaryButtonPress(InputAction.CallbackContext context)
        {
        }
    }
}