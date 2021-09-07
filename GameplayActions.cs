using _Project.Scripts.Managers;
using _Project.Scripts.UI;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace _Project.Scripts
{
    public class GameplayActions : MonoBehaviour, PlayerControls.IGameplayActions
    {
        private PlayerControls controls;
        private Animator animator;
        private NavMeshAgent agent;
        private Camera mainCamera;
        private Inventory inventory;
        private static readonly int MovementSpeed = Animator.StringToHash("movementSpeed");

        private void Awake()
        {
            inventory = GetComponent<Inventory>();
            agent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
            mainCamera = Camera.main;
        }

        private void Update()
        {
            animator.SetFloat(MovementSpeed, agent.velocity.magnitude);
        }

        private void OnEnable()
        {
            if (controls == null)
            {
                controls = new PlayerControls();
                controls.Gameplay.SetCallbacks(this);
            }
            controls.Gameplay.Enable();
            
            UIManager.Instance.OnShowUI += controls.Gameplay.Disable;
            UIManager.Instance.OnHideUI += controls.Gameplay.Enable;
        }

        private void OnDisable()
        {
            controls.Gameplay.Disable();
            
            UIManager.Instance.OnShowUI += controls.Gameplay.Disable;
            UIManager.Instance.OnHideUI += controls.Gameplay.Enable;
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Vector2 mousePosition = controls.Gameplay.Move.ReadValue<Vector2>();
                Ray ray = mainCamera.ScreenPointToRay(mousePosition);
                RaycastHit hit;
                bool hasHit = Physics.Raycast(ray, out hit);
                if (hasHit)
                {
                    agent.SetDestination(hit.point);
                }
            }
        }

        public void OnMove(InputAction.CallbackContext context)
        {
        }

        public void OnOpenInventory(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                UIManager.Instance.Show(Constants.UI.INVENTORY);
            }
        }

        public void OnOpenEquipment(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                UIManager.Instance.Show(Constants.UI.EQUIPMENT);
            }
        }
        
        public void OnOpenStats(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                // UIManager.Instance.Show(Constants.UI.STATS);
                UIManager.Instance.Show(Constants.UI.RADIAL_MENU);
            }
        }

        public void OnPickUp(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                var hits = Physics.OverlapSphere(transform.position, 0.5f, 1 << LayerMask.NameToLayer("Item"));
                foreach (var hit in hits)
                {
                    var item = hit.GetComponent<Item>();
                    inventory.Add(item);
                }
            }
        }

        public void OnSave(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                SaveManager.Instance.Save();
            }
        }
    }
}