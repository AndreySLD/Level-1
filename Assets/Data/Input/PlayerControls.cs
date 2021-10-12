// GENERATED AUTOMATICALLY FROM 'Assets/Data/Input/PlayerControls.inputactions'

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
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player Movement"",
            ""id"": ""52062f42-704f-48c9-965d-30acece2e590"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e04f1051-da0c-40f5-9047-e9597fcb9a92"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""14d8cdd7-b168-4071-9282-ca8b867a1159"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LockOnRight"",
                    ""type"": ""Button"",
                    ""id"": ""17952f28-149b-45d2-82aa-f480f4985469"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LockOnLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e1d45dd8-b8e9-486c-a81f-4e873954cfac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3663d32c-2826-4c1f-a70e-aed411767438"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1f92fad7-50d9-4d02-98ae-feeda50966f4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7ec1512a-b1a9-4109-97fb-735f2dde3f89"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""05bd776a-b384-4773-86cf-78342ea83f73"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""18353111-5b80-4320-b57f-89f04730ec0c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1116b82c-68ee-4dd2-a38e-a8e1ed1364b3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e78598b-3a0f-4adc-8b88-5964c617bfce"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""181ef88d-f80f-4bd5-a010-0807c503dd25"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e2fa459-3c8e-4f4f-ae6c-e30f06a0fd77"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""fce791ae-bca9-4a21-afb4-758c76969873"",
            ""actions"": [
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""d79a50d5-1332-45c2-b4ea-b82b8a6bc89d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightAttack"",
                    ""type"": ""Button"",
                    ""id"": ""15158e90-2461-452e-9cc5-7b04fc412b39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeavyAttack"",
                    ""type"": ""Button"",
                    ""id"": ""476c38e1-169f-41ef-a0b3-ca3229139fdd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LockOn"",
                    ""type"": ""Button"",
                    ""id"": ""49625071-0c76-4833-8448-153fa0f63b4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e7880e28-0a18-48fc-bea7-953b09627382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""042cfd3c-c7aa-41ac-8b24-5688c7cf0135"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Flask"",
                    ""type"": ""Button"",
                    ""id"": ""f2951e49-ee14-4e55-b85d-3229f719b558"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fdf3915a-bea9-411e-b21c-152b38227c63"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96934160-bd5f-44d0-95c6-e2b49831e05e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f387e8cd-5f50-4e17-8f5f-954b8042bf6e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1152309-54cc-4aea-b779-5366f5048973"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40d3be5e-2b35-4504-bf23-8dcff367a075"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e851b7e-7765-471b-80bf-6ad48ce058c1"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b008edb-8009-49ab-a57d-1798e3d3662d"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9acaafb1-78c7-4cf0-b5c7-c727aae536cc"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flask"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Quick Slots"",
            ""id"": ""5ed09716-c570-4a1e-a312-cbca3e41d8d5"",
            ""actions"": [
                {
                    ""name"": ""MagicSlot"",
                    ""type"": ""Button"",
                    ""id"": ""987a7317-6695-4a3e-b726-24199a2a07aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftHandSlot"",
                    ""type"": ""Button"",
                    ""id"": ""e5c14388-e723-4807-98b3-31e097de14c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightHandSlot"",
                    ""type"": ""Button"",
                    ""id"": ""6cfec2f2-e690-4d3f-8077-946812f3628d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ConsumableSlot"",
                    ""type"": ""Button"",
                    ""id"": ""f1791b33-b662-4052-b709-4956601fd1ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bc327a80-0778-4c40-80d8-f06992139abc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MagicSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adfd8ba5-b479-434a-a4c3-28a4695836eb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHandSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5e9fc0f-2e3e-429f-bf03-90f42e9fd724"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHandSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79d26089-dc8b-4a64-9fd3-c785fcaf97bc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ConsumableSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Camera = m_PlayerMovement.FindAction("Camera", throwIfNotFound: true);
        m_PlayerMovement_LockOnRight = m_PlayerMovement.FindAction("LockOnRight", throwIfNotFound: true);
        m_PlayerMovement_LockOnLeft = m_PlayerMovement.FindAction("LockOnLeft", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_Roll = m_PlayerActions.FindAction("Roll", throwIfNotFound: true);
        m_PlayerActions_LightAttack = m_PlayerActions.FindAction("LightAttack", throwIfNotFound: true);
        m_PlayerActions_HeavyAttack = m_PlayerActions.FindAction("HeavyAttack", throwIfNotFound: true);
        m_PlayerActions_LockOn = m_PlayerActions.FindAction("LockOn", throwIfNotFound: true);
        m_PlayerActions_Jump = m_PlayerActions.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActions_Kick = m_PlayerActions.FindAction("Kick", throwIfNotFound: true);
        m_PlayerActions_Flask = m_PlayerActions.FindAction("Flask", throwIfNotFound: true);
        // Player Quick Slots
        m_PlayerQuickSlots = asset.FindActionMap("Player Quick Slots", throwIfNotFound: true);
        m_PlayerQuickSlots_MagicSlot = m_PlayerQuickSlots.FindAction("MagicSlot", throwIfNotFound: true);
        m_PlayerQuickSlots_LeftHandSlot = m_PlayerQuickSlots.FindAction("LeftHandSlot", throwIfNotFound: true);
        m_PlayerQuickSlots_RightHandSlot = m_PlayerQuickSlots.FindAction("RightHandSlot", throwIfNotFound: true);
        m_PlayerQuickSlots_ConsumableSlot = m_PlayerQuickSlots.FindAction("ConsumableSlot", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Camera;
    private readonly InputAction m_PlayerMovement_LockOnRight;
    private readonly InputAction m_PlayerMovement_LockOnLeft;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovement_Camera;
        public InputAction @LockOnRight => m_Wrapper.m_PlayerMovement_LockOnRight;
        public InputAction @LockOnLeft => m_Wrapper.m_PlayerMovement_LockOnLeft;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @LockOnRight.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnRight;
                @LockOnRight.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnRight;
                @LockOnRight.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnRight;
                @LockOnLeft.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnLeft;
                @LockOnLeft.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnLeft;
                @LockOnLeft.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnLeft;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @LockOnRight.started += instance.OnLockOnRight;
                @LockOnRight.performed += instance.OnLockOnRight;
                @LockOnRight.canceled += instance.OnLockOnRight;
                @LockOnLeft.started += instance.OnLockOnLeft;
                @LockOnLeft.performed += instance.OnLockOnLeft;
                @LockOnLeft.canceled += instance.OnLockOnLeft;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Roll;
    private readonly InputAction m_PlayerActions_LightAttack;
    private readonly InputAction m_PlayerActions_HeavyAttack;
    private readonly InputAction m_PlayerActions_LockOn;
    private readonly InputAction m_PlayerActions_Jump;
    private readonly InputAction m_PlayerActions_Kick;
    private readonly InputAction m_PlayerActions_Flask;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Roll => m_Wrapper.m_PlayerActions_Roll;
        public InputAction @LightAttack => m_Wrapper.m_PlayerActions_LightAttack;
        public InputAction @HeavyAttack => m_Wrapper.m_PlayerActions_HeavyAttack;
        public InputAction @LockOn => m_Wrapper.m_PlayerActions_LockOn;
        public InputAction @Jump => m_Wrapper.m_PlayerActions_Jump;
        public InputAction @Kick => m_Wrapper.m_PlayerActions_Kick;
        public InputAction @Flask => m_Wrapper.m_PlayerActions_Flask;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Roll.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @LightAttack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttack;
                @LightAttack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttack;
                @LightAttack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLightAttack;
                @HeavyAttack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnHeavyAttack;
                @LockOn.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLockOn;
                @LockOn.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLockOn;
                @LockOn.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLockOn;
                @Jump.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Kick.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnKick;
                @Flask.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnFlask;
                @Flask.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnFlask;
                @Flask.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnFlask;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @LightAttack.started += instance.OnLightAttack;
                @LightAttack.performed += instance.OnLightAttack;
                @LightAttack.canceled += instance.OnLightAttack;
                @HeavyAttack.started += instance.OnHeavyAttack;
                @HeavyAttack.performed += instance.OnHeavyAttack;
                @HeavyAttack.canceled += instance.OnHeavyAttack;
                @LockOn.started += instance.OnLockOn;
                @LockOn.performed += instance.OnLockOn;
                @LockOn.canceled += instance.OnLockOn;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @Flask.started += instance.OnFlask;
                @Flask.performed += instance.OnFlask;
                @Flask.canceled += instance.OnFlask;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // Player Quick Slots
    private readonly InputActionMap m_PlayerQuickSlots;
    private IPlayerQuickSlotsActions m_PlayerQuickSlotsActionsCallbackInterface;
    private readonly InputAction m_PlayerQuickSlots_MagicSlot;
    private readonly InputAction m_PlayerQuickSlots_LeftHandSlot;
    private readonly InputAction m_PlayerQuickSlots_RightHandSlot;
    private readonly InputAction m_PlayerQuickSlots_ConsumableSlot;
    public struct PlayerQuickSlotsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerQuickSlotsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MagicSlot => m_Wrapper.m_PlayerQuickSlots_MagicSlot;
        public InputAction @LeftHandSlot => m_Wrapper.m_PlayerQuickSlots_LeftHandSlot;
        public InputAction @RightHandSlot => m_Wrapper.m_PlayerQuickSlots_RightHandSlot;
        public InputAction @ConsumableSlot => m_Wrapper.m_PlayerQuickSlots_ConsumableSlot;
        public InputActionMap Get() { return m_Wrapper.m_PlayerQuickSlots; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerQuickSlotsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerQuickSlotsActions instance)
        {
            if (m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface != null)
            {
                @MagicSlot.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnMagicSlot;
                @MagicSlot.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnMagicSlot;
                @MagicSlot.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnMagicSlot;
                @LeftHandSlot.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnLeftHandSlot;
                @LeftHandSlot.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnLeftHandSlot;
                @LeftHandSlot.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnLeftHandSlot;
                @RightHandSlot.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnRightHandSlot;
                @RightHandSlot.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnRightHandSlot;
                @RightHandSlot.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnRightHandSlot;
                @ConsumableSlot.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnConsumableSlot;
                @ConsumableSlot.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnConsumableSlot;
                @ConsumableSlot.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnConsumableSlot;
            }
            m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MagicSlot.started += instance.OnMagicSlot;
                @MagicSlot.performed += instance.OnMagicSlot;
                @MagicSlot.canceled += instance.OnMagicSlot;
                @LeftHandSlot.started += instance.OnLeftHandSlot;
                @LeftHandSlot.performed += instance.OnLeftHandSlot;
                @LeftHandSlot.canceled += instance.OnLeftHandSlot;
                @RightHandSlot.started += instance.OnRightHandSlot;
                @RightHandSlot.performed += instance.OnRightHandSlot;
                @RightHandSlot.canceled += instance.OnRightHandSlot;
                @ConsumableSlot.started += instance.OnConsumableSlot;
                @ConsumableSlot.performed += instance.OnConsumableSlot;
                @ConsumableSlot.canceled += instance.OnConsumableSlot;
            }
        }
    }
    public PlayerQuickSlotsActions @PlayerQuickSlots => new PlayerQuickSlotsActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnLockOnRight(InputAction.CallbackContext context);
        void OnLockOnLeft(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnRoll(InputAction.CallbackContext context);
        void OnLightAttack(InputAction.CallbackContext context);
        void OnHeavyAttack(InputAction.CallbackContext context);
        void OnLockOn(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnKick(InputAction.CallbackContext context);
        void OnFlask(InputAction.CallbackContext context);
    }
    public interface IPlayerQuickSlotsActions
    {
        void OnMagicSlot(InputAction.CallbackContext context);
        void OnLeftHandSlot(InputAction.CallbackContext context);
        void OnRightHandSlot(InputAction.CallbackContext context);
        void OnConsumableSlot(InputAction.CallbackContext context);
    }
}
