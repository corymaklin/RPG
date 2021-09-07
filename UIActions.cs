using _Project.Scripts.Managers;
using _Project.Scripts.UI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Project.Scripts
{
    public class UIActions : MonoBehaviour, PlayerControls.IUIActions
    {
        private PlayerControls controls;
        private void OnEnable()
        {
            if (controls == null)
            {
                controls = new PlayerControls();
                controls.UI.SetCallbacks(this);
            }
            
            UIManager.Instance.OnShowUI += controls.UI.Enable;
            UIManager.Instance.OnHideUI += controls.UI.Disable;
        }

        private void OnDisable()
        {
            UIManager.Instance.OnShowUI -= controls.UI.Enable;
            UIManager.Instance.OnHideUI -= controls.UI.Disable;
        }
        
        public void OnCloseInventory(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                UIManager.Instance.Hide();    
            }
        }

        public void OnCloseEquipment(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                UIManager.Instance.Hide();
            }
        }

        public void OnCloseStats(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                UIManager.Instance.Hide();
            }
        }
    }
}