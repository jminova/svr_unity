// GENERATED AUTOMATICALLY FROM 'Assets/InputManager/Player.inputactions'

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
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""HeadsetPlayer"",
            ""id"": ""5cb9b48a-676e-4004-aa74-ff683f479618"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""60f3855c-c1ec-41a6-a4bd-f7747125f6c8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""da6b2bf7-c2a0-46b8-a11b-91a3d052f9fe"",
                    ""path"": ""<HID::YiChip BT KB>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DesktopPlayer"",
            ""id"": ""7155e502-41a6-4d57-ba64-898a691b55ef"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5c321956-a733-46d9-91ed-caafc6623454"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""55eb8a39-91cc-447d-af3c-e85350009b44"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""44b8ef61-7a6a-4dfd-bb86-a11fbabb45c6"",
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
                    ""id"": ""91797b19-ce4d-4cbd-82a1-422b6eb78d0a"",
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
                    ""id"": ""b67b246e-d5d0-4bf0-9023-c8df04436c93"",
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
                    ""id"": ""806027f4-1639-4013-9a07-adfd5798d021"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // HeadsetPlayer
        m_HeadsetPlayer = asset.FindActionMap("HeadsetPlayer", throwIfNotFound: true);
        m_HeadsetPlayer_Movement = m_HeadsetPlayer.FindAction("Movement", throwIfNotFound: true);
        // DesktopPlayer
        m_DesktopPlayer = asset.FindActionMap("DesktopPlayer", throwIfNotFound: true);
        m_DesktopPlayer_Movement = m_DesktopPlayer.FindAction("Movement", throwIfNotFound: true);
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

    // HeadsetPlayer
    private readonly InputActionMap m_HeadsetPlayer;
    private IHeadsetPlayerActions m_HeadsetPlayerActionsCallbackInterface;
    private readonly InputAction m_HeadsetPlayer_Movement;
    public struct HeadsetPlayerActions
    {
        private @PlayerControls m_Wrapper;
        public HeadsetPlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_HeadsetPlayer_Movement;
        public InputActionMap Get() { return m_Wrapper.m_HeadsetPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeadsetPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IHeadsetPlayerActions instance)
        {
            if (m_Wrapper.m_HeadsetPlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_HeadsetPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public HeadsetPlayerActions @HeadsetPlayer => new HeadsetPlayerActions(this);

    // DesktopPlayer
    private readonly InputActionMap m_DesktopPlayer;
    private IDesktopPlayerActions m_DesktopPlayerActionsCallbackInterface;
    private readonly InputAction m_DesktopPlayer_Movement;
    public struct DesktopPlayerActions
    {
        private @PlayerControls m_Wrapper;
        public DesktopPlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_DesktopPlayer_Movement;
        public InputActionMap Get() { return m_Wrapper.m_DesktopPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DesktopPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IDesktopPlayerActions instance)
        {
            if (m_Wrapper.m_DesktopPlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DesktopPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DesktopPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DesktopPlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_DesktopPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public DesktopPlayerActions @DesktopPlayer => new DesktopPlayerActions(this);
    public interface IHeadsetPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IDesktopPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
