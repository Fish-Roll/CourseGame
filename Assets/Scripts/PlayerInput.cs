//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Scripts/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""MovementActionMap"",
            ""id"": ""6e30af7d-9f46-49c7-8d4c-6c39f7102e88"",
            ""actions"": [
                {
                    ""name"": ""MovementAction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a325621b-f049-489d-ab0b-a50252e72bc5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""cfd37527-a17c-48fb-becc-82422e6d5cca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9dadb9b7-0fa9-4929-a81a-721ae488b772"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""96d1f21a-319f-45a7-b6a9-67be90a89905"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af6afcfb-e4ac-4ee1-b648-e281ace2fbd7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""507b7c65-bc13-4dd6-b213-8f88daaa4910"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""17a8807f-af2c-4330-8fdd-61812635d73a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cc23501b-3984-455b-b983-7e6def2901f4"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MovementActionMap
        m_MovementActionMap = asset.FindActionMap("MovementActionMap", throwIfNotFound: true);
        m_MovementActionMap_MovementAction = m_MovementActionMap.FindAction("MovementAction", throwIfNotFound: true);
        m_MovementActionMap_Dodge = m_MovementActionMap.FindAction("Dodge", throwIfNotFound: true);
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

    // MovementActionMap
    private readonly InputActionMap m_MovementActionMap;
    private IMovementActionMapActions m_MovementActionMapActionsCallbackInterface;
    private readonly InputAction m_MovementActionMap_MovementAction;
    private readonly InputAction m_MovementActionMap_Dodge;
    public struct MovementActionMapActions
    {
        private @PlayerInput m_Wrapper;
        public MovementActionMapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementAction => m_Wrapper.m_MovementActionMap_MovementAction;
        public InputAction @Dodge => m_Wrapper.m_MovementActionMap_Dodge;
        public InputActionMap Get() { return m_Wrapper.m_MovementActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActionMapActions instance)
        {
            if (m_Wrapper.m_MovementActionMapActionsCallbackInterface != null)
            {
                @MovementAction.started -= m_Wrapper.m_MovementActionMapActionsCallbackInterface.OnMovementAction;
                @MovementAction.performed -= m_Wrapper.m_MovementActionMapActionsCallbackInterface.OnMovementAction;
                @MovementAction.canceled -= m_Wrapper.m_MovementActionMapActionsCallbackInterface.OnMovementAction;
                @Dodge.started -= m_Wrapper.m_MovementActionMapActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_MovementActionMapActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_MovementActionMapActionsCallbackInterface.OnDodge;
            }
            m_Wrapper.m_MovementActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementAction.started += instance.OnMovementAction;
                @MovementAction.performed += instance.OnMovementAction;
                @MovementAction.canceled += instance.OnMovementAction;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
            }
        }
    }
    public MovementActionMapActions @MovementActionMap => new MovementActionMapActions(this);
    public interface IMovementActionMapActions
    {
        void OnMovementAction(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
    }
}