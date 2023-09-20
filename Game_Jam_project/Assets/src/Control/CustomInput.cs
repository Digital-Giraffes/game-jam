//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/sys/InputMap.inputactions
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

namespace control
{
  public partial class @CustomInput : IInputActionCollection2, IDisposable
  {
    public InputActionAsset asset { get; }
    public @CustomInput()
    {
      asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1eeaf2d2-8222-41db-a342-421d80078d47"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""73664672-ca94-4b2b-a9c0-8b3d15847804"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Eyes"",
                    ""type"": ""Button"",
                    ""id"": ""18db5b13-0ea9-44d7-97a1-391bfc6d1f98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""96d19453-573c-4d0f-931c-bc8d01724831"",
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
                    ""id"": ""880bba85-247f-45bc-b6b3-64ce7617d94a"",
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
                    ""id"": ""438a81ae-b3b7-4290-b82f-666629f75b3d"",
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
                    ""id"": ""0df8ddca-1007-42dc-b520-b482aa745cc3"",
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
                    ""id"": ""5d1ec22e-f99d-44a3-a222-a95d0b7aebc7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""46f23a2c-f25c-4a26-ab3a-ddff72b28570"",
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
                    ""id"": ""c5f0368c-45f7-4f8f-89fd-a7e62878c5c4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f43c6ecd-d5df-4aea-8a3c-23de5ec30dd1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""de7d4280-aa4e-4c7a-be43-a6831edabe5b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""410be33c-d44b-437f-ad08-d0a627fa0476"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b2238a0c-2387-45ff-80c6-236ffc665d59"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold(duration=0.2,pressPoint=0.2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Eyes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
      // Player
      m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
      m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
      m_Player_Eyes = m_Player.FindAction("Eyes", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Eyes;
    public struct PlayerActions
    {
      private @CustomInput m_Wrapper;
      public PlayerActions(@CustomInput wrapper) { m_Wrapper = wrapper; }
      public InputAction @Movement => m_Wrapper.m_Player_Movement;
      public InputAction @Eyes => m_Wrapper.m_Player_Eyes;
      public InputActionMap Get() { return m_Wrapper.m_Player; }
      public void Enable() { Get().Enable(); }
      public void Disable() { Get().Disable(); }
      public bool enabled => Get().enabled;
      public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
      public void AddCallbacks(IPlayerActions instance)
      {
        if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
        m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
        @Movement.started += instance.OnMovement;
        @Movement.performed += instance.OnMovement;
        @Movement.canceled += instance.OnMovement;
        @Eyes.started += instance.OnEyes;
        @Eyes.performed += instance.OnEyes;
        @Eyes.canceled += instance.OnEyes;
      }

      private void UnregisterCallbacks(IPlayerActions instance)
      {
        @Movement.started -= instance.OnMovement;
        @Movement.performed -= instance.OnMovement;
        @Movement.canceled -= instance.OnMovement;
        @Eyes.started -= instance.OnEyes;
        @Eyes.performed -= instance.OnEyes;
        @Eyes.canceled -= instance.OnEyes;
      }

      public void RemoveCallbacks(IPlayerActions instance)
      {
        if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
          UnregisterCallbacks(instance);
      }

      public void SetCallbacks(IPlayerActions instance)
      {
        foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
          UnregisterCallbacks(item);
        m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
        AddCallbacks(instance);
      }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
      void OnMovement(InputAction.CallbackContext context);
      void OnEyes(InputAction.CallbackContext context);
    }
  }
}
