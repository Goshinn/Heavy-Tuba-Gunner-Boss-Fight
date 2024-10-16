//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/ControlSet.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ControlSet : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlSet()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlSet"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""8643e742-fc8a-4423-a099-98aab7ccadd2"",
            ""actions"": [
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""8f65d4a4-a059-4c89-acd2-3b74e35865d6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MovementInput"",
                    ""type"": ""Value"",
                    ""id"": ""522cea0b-888f-47c3-a9fe-dc68ee60afb0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraLookJoystick"",
                    ""type"": ""Value"",
                    ""id"": ""5f101402-004f-42b0-9982-2cbac627356d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""503fc756-43d5-4e75-a8a4-0adc40b547cc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8fd87e56-38f7-470b-bd1e-1a28328d9905"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f644f926-373a-45a7-9c0a-b14fb5bcfc0e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a919a991-6312-4e94-988e-3922abea8d5f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1157862-eec8-4823-9018-13f1f6e6a596"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""74d86aa8-1c32-427b-b4a3-b8b1787aab8f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e48e989b-dec3-4e6f-90cc-f453307bf10f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9de53c0-c73c-4bfe-9909-c89afbf6767e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraLookJoystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Combat"",
            ""id"": ""dc53a3c9-1451-4c58-9a5e-c85bcd117414"",
            ""actions"": [
                {
                    ""name"": ""LightAttack"",
                    ""type"": ""Button"",
                    ""id"": ""073ce498-44df-4ed9-b911-aa04092c58eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""079545ce-a894-4463-aa1e-396ecf9b7b21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DodgeRoll"",
                    ""type"": ""Button"",
                    ""id"": ""1463e9f3-411a-49f2-8bc1-7216ba7d02a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6fcdfbdf-b30d-45a3-9b5f-de1b5eec6d41"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""LightAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db6d5275-ff27-4ff1-aaa4-70fd9ab6f6be"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""LightAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""846de470-753c-4d40-b23a-1863d5f2d14b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9f58ab8-a735-4c1f-9734-b0533f7bfa56"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38b2c17b-1080-4cd1-9bf4-94b0cdf1ae53"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4568f6c8-5616-4fb6-a178-3c0259a60b16"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""DodgeRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd817ce3-eda7-481f-8f90-8b49ddcc2166"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""DodgeRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Testing"",
            ""id"": ""9f995db1-6a46-49cc-a29b-6ed40a12d15f"",
            ""actions"": [
                {
                    ""name"": ""FlinchingAttack"",
                    ""type"": ""Button"",
                    ""id"": ""862814ad-fb07-4681-90ea-53af8134a05e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8b43f174-8d73-458e-a910-b7dcd3e0954d"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""FlinchingAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""2519b63a-7628-46cf-bfa0-3088b6593534"",
            ""actions"": [
                {
                    ""name"": ""KeyboardToggleMenu"",
                    ""type"": ""Button"",
                    ""id"": ""877a949f-a3d6-44df-a0d9-677a7c21a4b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ControllerBack"",
                    ""type"": ""Button"",
                    ""id"": ""3680e480-eaad-4f5f-9e2a-79f9388bedfd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ControllerToggleMenu"",
                    ""type"": ""Button"",
                    ""id"": ""4cb20e1f-22f7-4f76-98ac-edb5aad4e4fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49eddd57-efab-4f12-83fe-011f2e42dc6b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""KeyboardToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af1426ab-f374-4be5-8546-2d36349afcc2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ControllerBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6645342b-7e12-4167-a073-ccf714634a44"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ControllerToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Miscellaneous"",
            ""id"": ""7c8c3ed1-1f7f-4fe3-9a45-59545c64f37b"",
            ""actions"": [
                {
                    ""name"": ""ToggleLockOnTarget"",
                    ""type"": ""Button"",
                    ""id"": ""ba4e9f33-085a-49c9-bd43-ab43d96e1c15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""96bc0d5f-5692-4d6c-a01b-37dc3b254bcc"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ToggleLockOnTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse&Keyboard"",
            ""bindingGroup"": ""Mouse&Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_CameraLook = m_Movement.FindAction("CameraLook", throwIfNotFound: true);
        m_Movement_MovementInput = m_Movement.FindAction("MovementInput", throwIfNotFound: true);
        m_Movement_CameraLookJoystick = m_Movement.FindAction("CameraLookJoystick", throwIfNotFound: true);
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_LightAttack = m_Combat.FindAction("LightAttack", throwIfNotFound: true);
        m_Combat_Block = m_Combat.FindAction("Block", throwIfNotFound: true);
        m_Combat_DodgeRoll = m_Combat.FindAction("DodgeRoll", throwIfNotFound: true);
        // Testing
        m_Testing = asset.FindActionMap("Testing", throwIfNotFound: true);
        m_Testing_FlinchingAttack = m_Testing.FindAction("FlinchingAttack", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_KeyboardToggleMenu = m_UI.FindAction("KeyboardToggleMenu", throwIfNotFound: true);
        m_UI_ControllerBack = m_UI.FindAction("ControllerBack", throwIfNotFound: true);
        m_UI_ControllerToggleMenu = m_UI.FindAction("ControllerToggleMenu", throwIfNotFound: true);
        // Miscellaneous
        m_Miscellaneous = asset.FindActionMap("Miscellaneous", throwIfNotFound: true);
        m_Miscellaneous_ToggleLockOnTarget = m_Miscellaneous.FindAction("ToggleLockOnTarget", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_CameraLook;
    private readonly InputAction m_Movement_MovementInput;
    private readonly InputAction m_Movement_CameraLookJoystick;
    public struct MovementActions
    {
        private @ControlSet m_Wrapper;
        public MovementActions(@ControlSet wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraLook => m_Wrapper.m_Movement_CameraLook;
        public InputAction @MovementInput => m_Wrapper.m_Movement_MovementInput;
        public InputAction @CameraLookJoystick => m_Wrapper.m_Movement_CameraLookJoystick;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @CameraLook.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCameraLook;
                @CameraLook.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCameraLook;
                @CameraLook.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCameraLook;
                @MovementInput.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovementInput;
                @MovementInput.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovementInput;
                @MovementInput.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovementInput;
                @CameraLookJoystick.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCameraLookJoystick;
                @CameraLookJoystick.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCameraLookJoystick;
                @CameraLookJoystick.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCameraLookJoystick;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraLook.started += instance.OnCameraLook;
                @CameraLook.performed += instance.OnCameraLook;
                @CameraLook.canceled += instance.OnCameraLook;
                @MovementInput.started += instance.OnMovementInput;
                @MovementInput.performed += instance.OnMovementInput;
                @MovementInput.canceled += instance.OnMovementInput;
                @CameraLookJoystick.started += instance.OnCameraLookJoystick;
                @CameraLookJoystick.performed += instance.OnCameraLookJoystick;
                @CameraLookJoystick.canceled += instance.OnCameraLookJoystick;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_LightAttack;
    private readonly InputAction m_Combat_Block;
    private readonly InputAction m_Combat_DodgeRoll;
    public struct CombatActions
    {
        private @ControlSet m_Wrapper;
        public CombatActions(@ControlSet wrapper) { m_Wrapper = wrapper; }
        public InputAction @LightAttack => m_Wrapper.m_Combat_LightAttack;
        public InputAction @Block => m_Wrapper.m_Combat_Block;
        public InputAction @DodgeRoll => m_Wrapper.m_Combat_DodgeRoll;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @LightAttack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnLightAttack;
                @LightAttack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnLightAttack;
                @LightAttack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnLightAttack;
                @Block.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlock;
                @DodgeRoll.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnDodgeRoll;
                @DodgeRoll.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnDodgeRoll;
                @DodgeRoll.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnDodgeRoll;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LightAttack.started += instance.OnLightAttack;
                @LightAttack.performed += instance.OnLightAttack;
                @LightAttack.canceled += instance.OnLightAttack;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @DodgeRoll.started += instance.OnDodgeRoll;
                @DodgeRoll.performed += instance.OnDodgeRoll;
                @DodgeRoll.canceled += instance.OnDodgeRoll;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);

    // Testing
    private readonly InputActionMap m_Testing;
    private ITestingActions m_TestingActionsCallbackInterface;
    private readonly InputAction m_Testing_FlinchingAttack;
    public struct TestingActions
    {
        private @ControlSet m_Wrapper;
        public TestingActions(@ControlSet wrapper) { m_Wrapper = wrapper; }
        public InputAction @FlinchingAttack => m_Wrapper.m_Testing_FlinchingAttack;
        public InputActionMap Get() { return m_Wrapper.m_Testing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestingActions set) { return set.Get(); }
        public void SetCallbacks(ITestingActions instance)
        {
            if (m_Wrapper.m_TestingActionsCallbackInterface != null)
            {
                @FlinchingAttack.started -= m_Wrapper.m_TestingActionsCallbackInterface.OnFlinchingAttack;
                @FlinchingAttack.performed -= m_Wrapper.m_TestingActionsCallbackInterface.OnFlinchingAttack;
                @FlinchingAttack.canceled -= m_Wrapper.m_TestingActionsCallbackInterface.OnFlinchingAttack;
            }
            m_Wrapper.m_TestingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FlinchingAttack.started += instance.OnFlinchingAttack;
                @FlinchingAttack.performed += instance.OnFlinchingAttack;
                @FlinchingAttack.canceled += instance.OnFlinchingAttack;
            }
        }
    }
    public TestingActions @Testing => new TestingActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_KeyboardToggleMenu;
    private readonly InputAction m_UI_ControllerBack;
    private readonly InputAction m_UI_ControllerToggleMenu;
    public struct UIActions
    {
        private @ControlSet m_Wrapper;
        public UIActions(@ControlSet wrapper) { m_Wrapper = wrapper; }
        public InputAction @KeyboardToggleMenu => m_Wrapper.m_UI_KeyboardToggleMenu;
        public InputAction @ControllerBack => m_Wrapper.m_UI_ControllerBack;
        public InputAction @ControllerToggleMenu => m_Wrapper.m_UI_ControllerToggleMenu;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @KeyboardToggleMenu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnKeyboardToggleMenu;
                @KeyboardToggleMenu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnKeyboardToggleMenu;
                @KeyboardToggleMenu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnKeyboardToggleMenu;
                @ControllerBack.started -= m_Wrapper.m_UIActionsCallbackInterface.OnControllerBack;
                @ControllerBack.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnControllerBack;
                @ControllerBack.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnControllerBack;
                @ControllerToggleMenu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnControllerToggleMenu;
                @ControllerToggleMenu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnControllerToggleMenu;
                @ControllerToggleMenu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnControllerToggleMenu;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @KeyboardToggleMenu.started += instance.OnKeyboardToggleMenu;
                @KeyboardToggleMenu.performed += instance.OnKeyboardToggleMenu;
                @KeyboardToggleMenu.canceled += instance.OnKeyboardToggleMenu;
                @ControllerBack.started += instance.OnControllerBack;
                @ControllerBack.performed += instance.OnControllerBack;
                @ControllerBack.canceled += instance.OnControllerBack;
                @ControllerToggleMenu.started += instance.OnControllerToggleMenu;
                @ControllerToggleMenu.performed += instance.OnControllerToggleMenu;
                @ControllerToggleMenu.canceled += instance.OnControllerToggleMenu;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Miscellaneous
    private readonly InputActionMap m_Miscellaneous;
    private IMiscellaneousActions m_MiscellaneousActionsCallbackInterface;
    private readonly InputAction m_Miscellaneous_ToggleLockOnTarget;
    public struct MiscellaneousActions
    {
        private @ControlSet m_Wrapper;
        public MiscellaneousActions(@ControlSet wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleLockOnTarget => m_Wrapper.m_Miscellaneous_ToggleLockOnTarget;
        public InputActionMap Get() { return m_Wrapper.m_Miscellaneous; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MiscellaneousActions set) { return set.Get(); }
        public void SetCallbacks(IMiscellaneousActions instance)
        {
            if (m_Wrapper.m_MiscellaneousActionsCallbackInterface != null)
            {
                @ToggleLockOnTarget.started -= m_Wrapper.m_MiscellaneousActionsCallbackInterface.OnToggleLockOnTarget;
                @ToggleLockOnTarget.performed -= m_Wrapper.m_MiscellaneousActionsCallbackInterface.OnToggleLockOnTarget;
                @ToggleLockOnTarget.canceled -= m_Wrapper.m_MiscellaneousActionsCallbackInterface.OnToggleLockOnTarget;
            }
            m_Wrapper.m_MiscellaneousActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleLockOnTarget.started += instance.OnToggleLockOnTarget;
                @ToggleLockOnTarget.performed += instance.OnToggleLockOnTarget;
                @ToggleLockOnTarget.canceled += instance.OnToggleLockOnTarget;
            }
        }
    }
    public MiscellaneousActions @Miscellaneous => new MiscellaneousActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse&Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnCameraLook(InputAction.CallbackContext context);
        void OnMovementInput(InputAction.CallbackContext context);
        void OnCameraLookJoystick(InputAction.CallbackContext context);
    }
    public interface ICombatActions
    {
        void OnLightAttack(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnDodgeRoll(InputAction.CallbackContext context);
    }
    public interface ITestingActions
    {
        void OnFlinchingAttack(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnKeyboardToggleMenu(InputAction.CallbackContext context);
        void OnControllerBack(InputAction.CallbackContext context);
        void OnControllerToggleMenu(InputAction.CallbackContext context);
    }
    public interface IMiscellaneousActions
    {
        void OnToggleLockOnTarget(InputAction.CallbackContext context);
    }
}
