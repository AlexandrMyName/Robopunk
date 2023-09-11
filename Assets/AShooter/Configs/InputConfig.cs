//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/AShooter/Configs/InputConfig.inputactions
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

public partial class @InputConfig: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputConfig()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputConfig"",
    ""maps"": [
        {
            ""name"": ""Direction"",
            ""id"": ""995d3d3b-353c-4494-9738-ce689d207ff4"",
            ""actions"": [
                {
                    ""name"": ""Vector"",
                    ""type"": ""Value"",
                    ""id"": ""a721c2c0-69db-4784-a324-d63690e4f0b2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""81960913-3cdb-483c-a1b2-33a6caab1ad2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1db306c5-3996-4d23-98ab-6b4ad1c52a04"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5713af12-1d50-48db-8970-858b90af9358"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""64e12b83-dc34-4836-98b6-2a385751d6b0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dda9b831-095f-4477-b787-854a4209938c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1c71b83b-7770-451e-abca-e808563e0e4c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8434371b-e3bf-4112-95bf-333a180bff62"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f35f12d0-181a-4d7c-8707-2f6f583275fa"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cf86fb3d-be11-425f-8873-b86480d4a80f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Move"",
                    ""action"": ""Vector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""59c08737-b665-4522-99f7-8b6a397879ea"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""26385be9-ac3f-4abd-8746-44cec5edcf25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1dae64bf-6594-4092-bfcc-562e29151efc"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapon"",
            ""id"": ""6517b6c8-296d-467f-a262-3ff37301ebb5"",
            ""actions"": [
                {
                    ""name"": ""First"",
                    ""type"": ""Button"",
                    ""id"": ""d6803d3c-227e-4fc8-a4ec-bed054053335"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Second"",
                    ""type"": ""Button"",
                    ""id"": ""f93ccf9b-8d03-42a9-9f97-e643b1be0045"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Third"",
                    ""type"": ""Button"",
                    ""id"": ""0f4f4647-be2c-4a61-8599-47f0a410143c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""37aa9c23-ad8b-44f2-a222-0ded29510d93"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""First"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34c7e6a2-2650-4bb3-b03a-aed4240ab27d"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Second"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cef28d29-775d-482f-8a2b-2f80238882af"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Third"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Move"",
            ""bindingGroup"": ""Move"",
            ""devices"": []
        }
    ]
}");
        // Direction
        m_Direction = asset.FindActionMap("Direction", throwIfNotFound: true);
        m_Direction_Vector = m_Direction.FindAction("Vector", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Newaction = m_Mouse.FindAction("New action", throwIfNotFound: true);
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_First = m_Weapon.FindAction("First", throwIfNotFound: true);
        m_Weapon_Second = m_Weapon.FindAction("Second", throwIfNotFound: true);
        m_Weapon_Third = m_Weapon.FindAction("Third", throwIfNotFound: true);
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

    // Direction
    private readonly InputActionMap m_Direction;
    private List<IDirectionActions> m_DirectionActionsCallbackInterfaces = new List<IDirectionActions>();
    private readonly InputAction m_Direction_Vector;
    public struct DirectionActions
    {
        private @InputConfig m_Wrapper;
        public DirectionActions(@InputConfig wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vector => m_Wrapper.m_Direction_Vector;
        public InputActionMap Get() { return m_Wrapper.m_Direction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DirectionActions set) { return set.Get(); }
        public void AddCallbacks(IDirectionActions instance)
        {
            if (instance == null || m_Wrapper.m_DirectionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DirectionActionsCallbackInterfaces.Add(instance);
            @Vector.started += instance.OnVector;
            @Vector.performed += instance.OnVector;
            @Vector.canceled += instance.OnVector;
        }

        private void UnregisterCallbacks(IDirectionActions instance)
        {
            @Vector.started -= instance.OnVector;
            @Vector.performed -= instance.OnVector;
            @Vector.canceled -= instance.OnVector;
        }

        public void RemoveCallbacks(IDirectionActions instance)
        {
            if (m_Wrapper.m_DirectionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDirectionActions instance)
        {
            foreach (var item in m_Wrapper.m_DirectionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DirectionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DirectionActions @Direction => new DirectionActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private List<IMouseActions> m_MouseActionsCallbackInterfaces = new List<IMouseActions>();
    private readonly InputAction m_Mouse_Newaction;
    public struct MouseActions
    {
        private @InputConfig m_Wrapper;
        public MouseActions(@InputConfig wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Mouse_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void AddCallbacks(IMouseActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IMouseActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // Weapon
    private readonly InputActionMap m_Weapon;
    private List<IWeaponActions> m_WeaponActionsCallbackInterfaces = new List<IWeaponActions>();
    private readonly InputAction m_Weapon_First;
    private readonly InputAction m_Weapon_Second;
    private readonly InputAction m_Weapon_Third;
    public struct WeaponActions
    {
        private @InputConfig m_Wrapper;
        public WeaponActions(@InputConfig wrapper) { m_Wrapper = wrapper; }
        public InputAction @First => m_Wrapper.m_Weapon_First;
        public InputAction @Second => m_Wrapper.m_Weapon_Second;
        public InputAction @Third => m_Wrapper.m_Weapon_Third;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void AddCallbacks(IWeaponActions instance)
        {
            if (instance == null || m_Wrapper.m_WeaponActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Add(instance);
            @First.started += instance.OnFirst;
            @First.performed += instance.OnFirst;
            @First.canceled += instance.OnFirst;
            @Second.started += instance.OnSecond;
            @Second.performed += instance.OnSecond;
            @Second.canceled += instance.OnSecond;
            @Third.started += instance.OnThird;
            @Third.performed += instance.OnThird;
            @Third.canceled += instance.OnThird;
        }

        private void UnregisterCallbacks(IWeaponActions instance)
        {
            @First.started -= instance.OnFirst;
            @First.performed -= instance.OnFirst;
            @First.canceled -= instance.OnFirst;
            @Second.started -= instance.OnSecond;
            @Second.performed -= instance.OnSecond;
            @Second.canceled -= instance.OnSecond;
            @Third.started -= instance.OnThird;
            @Third.performed -= instance.OnThird;
            @Third.canceled -= instance.OnThird;
        }

        public void RemoveCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWeaponActions instance)
        {
            foreach (var item in m_Wrapper.m_WeaponActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);
    private int m_MoveSchemeIndex = -1;
    public InputControlScheme MoveScheme
    {
        get
        {
            if (m_MoveSchemeIndex == -1) m_MoveSchemeIndex = asset.FindControlSchemeIndex("Move");
            return asset.controlSchemes[m_MoveSchemeIndex];
        }
    }
    public interface IDirectionActions
    {
        void OnVector(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IWeaponActions
    {
        void OnFirst(InputAction.CallbackContext context);
        void OnSecond(InputAction.CallbackContext context);
        void OnThird(InputAction.CallbackContext context);
    }
}
