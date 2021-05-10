// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""258becff-1d22-45af-95eb-f27d5691fab4"",
            ""actions"": [
                {
                    ""name"": ""MoveLR"",
                    ""type"": ""Value"",
                    ""id"": ""8145190c-72c0-400c-b731-a0c32eb6e595"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GravitySwap"",
                    ""type"": ""Button"",
                    ""id"": ""279a2526-543c-49d3-9b43-6bb6d0856186"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LR"",
                    ""id"": ""1ffb9107-7e75-41ee-a2be-5c7d15c05ee3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9d708004-f11f-4d93-86e5-864ce90841ad"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7c22ace8-3bcc-4dc8-84f5-677549eec3f3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""34daed23-7cbf-4cf2-b898-b3ecdeb9054a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GravitySwap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_MoveLR = m_Main.FindAction("MoveLR", throwIfNotFound: true);
        m_Main_GravitySwap = m_Main.FindAction("GravitySwap", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_MoveLR;
    private readonly InputAction m_Main_GravitySwap;
    public struct MainActions
    {
        private @Controls m_Wrapper;
        public MainActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLR => m_Wrapper.m_Main_MoveLR;
        public InputAction @GravitySwap => m_Wrapper.m_Main_GravitySwap;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @MoveLR.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMoveLR;
                @MoveLR.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMoveLR;
                @MoveLR.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMoveLR;
                @GravitySwap.started -= m_Wrapper.m_MainActionsCallbackInterface.OnGravitySwap;
                @GravitySwap.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnGravitySwap;
                @GravitySwap.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnGravitySwap;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLR.started += instance.OnMoveLR;
                @MoveLR.performed += instance.OnMoveLR;
                @MoveLR.canceled += instance.OnMoveLR;
                @GravitySwap.started += instance.OnGravitySwap;
                @GravitySwap.performed += instance.OnGravitySwap;
                @GravitySwap.canceled += instance.OnGravitySwap;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnMoveLR(InputAction.CallbackContext context);
        void OnGravitySwap(InputAction.CallbackContext context);
    }
}
