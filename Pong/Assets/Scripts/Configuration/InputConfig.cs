//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Configuration/InputConfig.inputactions
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

public partial class @InputConfig : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputConfig()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputConfig"",
    ""maps"": [
        {
            ""name"": ""KeyInput"",
            ""id"": ""6736d286-cdba-43ed-964e-ef42053d1124"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""024cc822-b1cd-4ae6-b380-3b05dbb3b226"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""9e1d2de3-d13d-4595-a43f-ec3f8f3455c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a842132f-a54e-4c66-8d0b-976f16458511"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5801bc3-6b3d-4548-9574-951cedb7d8ae"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a69e75c6-a361-4d05-9c92-4dc24814d329"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6a3ed4b-2d9f-407d-abde-7c6127a38bd9"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyInput
        m_KeyInput = asset.FindActionMap("KeyInput", throwIfNotFound: true);
        m_KeyInput_MoveLeft = m_KeyInput.FindAction("MoveLeft", throwIfNotFound: true);
        m_KeyInput_MoveRight = m_KeyInput.FindAction("MoveRight", throwIfNotFound: true);
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

    // KeyInput
    private readonly InputActionMap m_KeyInput;
    private IKeyInputActions m_KeyInputActionsCallbackInterface;
    private readonly InputAction m_KeyInput_MoveLeft;
    private readonly InputAction m_KeyInput_MoveRight;
    public struct KeyInputActions
    {
        private @InputConfig m_Wrapper;
        public KeyInputActions(@InputConfig wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_KeyInput_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_KeyInput_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_KeyInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyInputActions set) { return set.Get(); }
        public void SetCallbacks(IKeyInputActions instance)
        {
            if (m_Wrapper.m_KeyInputActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_KeyInputActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_KeyInputActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_KeyInputActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_KeyInputActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_KeyInputActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_KeyInputActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_KeyInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
            }
        }
    }
    public KeyInputActions @KeyInput => new KeyInputActions(this);
    public interface IKeyInputActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
}
