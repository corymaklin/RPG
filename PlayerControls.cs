// GENERATED AUTOMATICALLY FROM 'Assets/_Project/Actions/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""bf839e33-85d8-4eeb-be69-128761966bca"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""f0dfe79f-5d41-4242-b79a-6404a707150e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1d4468f6-36c6-42be-bac3-8d0cb2f6bd7d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Open Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""5523c647-2ea3-4319-a852-a7d06d113bca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Open Equipment"",
                    ""type"": ""Button"",
                    ""id"": ""e62e5369-f231-4580-ad85-4d1e225e0225"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pick Up"",
                    ""type"": ""Button"",
                    ""id"": ""d7c9a4b9-c93c-4094-9981-28648b59d1cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""2b752633-46fa-446a-b0de-0daf47134061"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Open Stats"",
                    ""type"": ""Button"",
                    ""id"": ""71489d86-1e33-4fc0-8d84-85c43b9d30cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""608f2188-3308-437b-8dac-1eea146c8e3b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63e14fd4-761e-408c-a875-7f8a39f3d6cf"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c4abf46-afb9-4f78-8c9c-437b88845ddf"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f88e35a3-3180-42b6-8a5b-8f49d11cd63b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Equipment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fc6a8a3-be68-4353-93d3-2c2b1bcce59b"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pick Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""205e4ef8-d5e4-4732-94d1-782746a66e93"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb8e223e-e510-4410-bf3b-b899b824fe0f"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Stats"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""475467fd-a06b-424c-b133-b73c53013b52"",
            ""actions"": [
                {
                    ""name"": ""Close Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""0ebccae7-3bd4-40ec-a045-2063285c8947"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Close Equipment"",
                    ""type"": ""Button"",
                    ""id"": ""38ad6187-7d26-4899-9d60-19f35f4915c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Close Stats"",
                    ""type"": ""Button"",
                    ""id"": ""2d3e7e99-5c86-401f-93b6-9fec2f048a2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cdd196c2-2a51-4e37-ad4c-823ed80a1027"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ae405a8-e9ad-4cb9-971e-83aa17a25dc0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close Equipment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7075b4b5-59a1-401d-8d08-1dabb19a544e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close Stats"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Fire = m_Gameplay.FindAction("Fire", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_OpenInventory = m_Gameplay.FindAction("Open Inventory", throwIfNotFound: true);
        m_Gameplay_OpenEquipment = m_Gameplay.FindAction("Open Equipment", throwIfNotFound: true);
        m_Gameplay_PickUp = m_Gameplay.FindAction("Pick Up", throwIfNotFound: true);
        m_Gameplay_Save = m_Gameplay.FindAction("Save", throwIfNotFound: true);
        m_Gameplay_OpenStats = m_Gameplay.FindAction("Open Stats", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_CloseInventory = m_UI.FindAction("Close Inventory", throwIfNotFound: true);
        m_UI_CloseEquipment = m_UI.FindAction("Close Equipment", throwIfNotFound: true);
        m_UI_CloseStats = m_UI.FindAction("Close Stats", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Fire;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_OpenInventory;
    private readonly InputAction m_Gameplay_OpenEquipment;
    private readonly InputAction m_Gameplay_PickUp;
    private readonly InputAction m_Gameplay_Save;
    private readonly InputAction m_Gameplay_OpenStats;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Gameplay_Fire;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @OpenInventory => m_Wrapper.m_Gameplay_OpenInventory;
        public InputAction @OpenEquipment => m_Wrapper.m_Gameplay_OpenEquipment;
        public InputAction @PickUp => m_Wrapper.m_Gameplay_PickUp;
        public InputAction @Save => m_Wrapper.m_Gameplay_Save;
        public InputAction @OpenStats => m_Wrapper.m_Gameplay_OpenStats;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @OpenInventory.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenInventory;
                @OpenEquipment.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenEquipment;
                @OpenEquipment.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenEquipment;
                @OpenEquipment.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenEquipment;
                @PickUp.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickUp;
                @Save.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSave;
                @OpenStats.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenStats;
                @OpenStats.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenStats;
                @OpenStats.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenStats;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @OpenInventory.started += instance.OnOpenInventory;
                @OpenInventory.performed += instance.OnOpenInventory;
                @OpenInventory.canceled += instance.OnOpenInventory;
                @OpenEquipment.started += instance.OnOpenEquipment;
                @OpenEquipment.performed += instance.OnOpenEquipment;
                @OpenEquipment.canceled += instance.OnOpenEquipment;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
                @OpenStats.started += instance.OnOpenStats;
                @OpenStats.performed += instance.OnOpenStats;
                @OpenStats.canceled += instance.OnOpenStats;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_CloseInventory;
    private readonly InputAction m_UI_CloseEquipment;
    private readonly InputAction m_UI_CloseStats;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseInventory => m_Wrapper.m_UI_CloseInventory;
        public InputAction @CloseEquipment => m_Wrapper.m_UI_CloseEquipment;
        public InputAction @CloseStats => m_Wrapper.m_UI_CloseStats;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @CloseInventory.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseInventory;
                @CloseInventory.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseInventory;
                @CloseInventory.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseInventory;
                @CloseEquipment.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseEquipment;
                @CloseEquipment.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseEquipment;
                @CloseEquipment.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseEquipment;
                @CloseStats.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseStats;
                @CloseStats.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseStats;
                @CloseStats.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCloseStats;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CloseInventory.started += instance.OnCloseInventory;
                @CloseInventory.performed += instance.OnCloseInventory;
                @CloseInventory.canceled += instance.OnCloseInventory;
                @CloseEquipment.started += instance.OnCloseEquipment;
                @CloseEquipment.performed += instance.OnCloseEquipment;
                @CloseEquipment.canceled += instance.OnCloseEquipment;
                @CloseStats.started += instance.OnCloseStats;
                @CloseStats.performed += instance.OnCloseStats;
                @CloseStats.canceled += instance.OnCloseStats;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IGameplayActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnOpenInventory(InputAction.CallbackContext context);
        void OnOpenEquipment(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
        void OnOpenStats(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnCloseInventory(InputAction.CallbackContext context);
        void OnCloseEquipment(InputAction.CallbackContext context);
        void OnCloseStats(InputAction.CallbackContext context);
    }
}
