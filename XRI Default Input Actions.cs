// GENERATED AUTOMATICALLY FROM 'Assets/Samples/XR Interaction Toolkit/0.10.0-preview.7/Default Input Actions/XRI Default Input Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Actions
{
    public class @XRIDefaultInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @XRIDefaultInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""XRI Default Input Actions"",
    ""maps"": [
        {
            ""name"": ""XRI HMD"",
            ""id"": ""09ff3ccc-21b4-4346-a3a2-7c978b5af892"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""1a9029f8-7a46-46b9-9eff-e9ae8365f611"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""aed87fe6-2b01-4dd2-a8fa-195578fd8158"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cff1f981-6e1f-4e2c-a90c-715a0ea2e80e"",
                    ""path"": ""<XRHMD>/centerEyePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2017383-a3f6-4c46-acb1-012b8eece9cc"",
                    ""path"": ""<XRHMD>/centerEyeRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""XRI LeftHand"",
            ""id"": ""5fe596f9-1b7b-49b7-80a7-3b5195caf74d"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""83a7af0b-87e3-42c3-a909-95fbf8091e4f"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""cb6b7130-2bac-4ef7-abe4-6991ae7d419d"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""33754c03-48ec-46ef-9bc6-22ed6bfdd8e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""0c0991c5-d329-4afc-8892-1076b440477c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI Press"",
                    ""type"": ""Button"",
                    ""id"": ""7e1eced7-c774-4fe5-be8f-d8711f646d9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptic Device"",
                    ""type"": ""PassThrough"",
                    ""id"": ""664a62b0-e178-421d-b3f8-014eec01591d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Select"",
                    ""type"": ""Button"",
                    ""id"": ""cbeaf823-3b69-4004-8ec8-13ea2ca3fc31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Activate"",
                    ""type"": ""Button"",
                    ""id"": ""a21db72c-4843-4839-b4d0-3ce8d287cb86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""89ce8348-6001-41a3-85b9-f8f2e2dcad7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""9164e093-ebd4-4923-af32-1b52f31c2d66"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9693e25f-8a4f-4aed-842f-3961243c69a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""21b75b25-12ad-410f-b4f8-a7745b7aca27"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Translate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""bfa204c7-3c92-4193-bad1-39eb71920042"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Button Press"",
                    ""type"": ""Button"",
                    ""id"": ""a5b6b260-157a-42f9-907b-53bbb423dbb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Button Press"",
                    ""type"": ""Button"",
                    ""id"": ""4e619a54-12c8-4baa-91b6-0297a4d026a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b34c79c1-ab5e-4851-87ac-abc43705eae0"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""UI Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79634234-07c9-488b-98bd-7d83eb6895c5"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8da6ed3a-f621-49fe-8c76-1f6b7d7754d6"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=1)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8edee81-6779-4aa8-89cd-29b149a8f55e"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8aebee7-fa03-43d4-bfb7-77a3f87452cc"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95fa1419-ca7b-4c8a-8d15-7d46e58d82e3"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=-1,sweepBehavior=3)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14a27f53-867e-4d15-92d9-3e36deb55b1b"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bf4fccb-bf42-4ec5-b215-c967f1d71642"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71a4d23f-3e9a-4513-923b-ba388c5e84bf"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""487f4f2e-9e9b-49aa-b0f2-4037a24624f5"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39aa1724-a43c-4afc-aba4-cb859e3202b7"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99cb7ad1-51ec-4611-af68-92a85f2c17d6"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=12,sweepBehavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""034c3ced-8f2c-44ce-892e-678ca433265b"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=2,sweepBehavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Noncontinuous Move"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e383b1a-270f-4c20-819b-89a59cffb498"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Continuous Move"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""830c14df-3b19-4470-b5d6-7e4cad86b44b"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acdf9550-5529-4ff7-8558-73ecdf0d75bd"",
                    ""path"": ""<XRController>{LeftHand}/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Haptic Device"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b73565ab-faa5-493f-a5f8-880103475ba2"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Button Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5333cff8-4341-450a-a2ba-ae5cd6d9b778"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Button Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""XRI RightHand"",
            ""id"": ""7960f8ef-2bf3-4281-aecc-4c03809d6c8c"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""c4990d70-7b8a-4ce1-b03c-da86716b8352"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""ee6bf5bf-bb0a-4a50-8327-cb654b19e298"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""ac96c10b-c955-4a46-8e67-bf16bc069b53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""41976d89-60de-4deb-bff9-16b4af96b290"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI Press"",
                    ""type"": ""Button"",
                    ""id"": ""65174b45-c2ee-4f90-93bb-fb4084eaaab3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptic Device"",
                    ""type"": ""PassThrough"",
                    ""id"": ""57b2a1b4-3290-46d6-ac07-4854ee8f91b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Select"",
                    ""type"": ""Button"",
                    ""id"": ""02e43582-8973-4940-af06-dff6158e3df2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Activate"",
                    ""type"": ""Button"",
                    ""id"": ""a6c7231d-c55d-4dd4-9e87-877bb5522ef5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Mode Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""d587b60c-39a0-4365-8075-477ce484ba0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""9fb2eb2b-2fb6-4328-8167-10a1bf11b424"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""00a4dc9f-1ee6-4349-b0e9-72d5dccaadd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""9b5d8312-f609-4895-b70f-81a722b2ae11"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Translate Anchor"",
                    ""type"": ""Value"",
                    ""id"": ""6f7cf253-7062-443b-b10f-2be48a33f027"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Button Press"",
                    ""type"": ""Button"",
                    ""id"": ""34640554-780f-4cb0-84b3-af7643934cc2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Button Press"",
                    ""type"": ""Button"",
                    ""id"": ""a9350c5d-47a9-4741-ad58-cfbb65df7d83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa59aed1-ae0b-4074-a58c-294b85f46228"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d2a5710-51f9-4e4b-a592-021821e5caa7"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62690862-4688-4010-975b-b3d9c6062157"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90efd65e-3290-4798-af15-21ab4d7848b5"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de466e6e-12bf-46a1-b0fd-ffbc343f3399"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Mode Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""919c4a6c-22ed-4083-8e14-f30e91ff59fe"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=-1,sweepBehavior=3)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7e6d19f-8306-47c9-8ca9-d3b6137565dc"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""274078b0-62e5-4730-bcc2-6896b9ad9f0c"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ce80054-410d-4112-a332-50faa7fb4f23"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92bb5b8f-bf48-4dab-af05-50a865773895"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""UI Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f029d63b-61df-46ba-b778-4c69688fdadb"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Translate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6c08c3d-3d41-4695-994d-1ac9016a5a9e"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=12,sweepBehavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70f78baa-0f00-4d32-a2b6-ea9e2090ecc2"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": ""Sector(directions=2,sweepBehavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3de72d27-6d0f-4d5f-935c-1569f7b65825"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Anchor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6011e1e6-b2dd-4cb1-8da5-29b03868f2c5"",
                    ""path"": ""<XRController>{RightHand}/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Haptic Device"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e56141ff-a0e2-4c01-8323-e724a4fcd42b"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Button Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20b20933-96ff-4d18-bf36-19ed21327b7c"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Button Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Generic XR Controller"",
            ""bindingGroup"": ""Generic XR Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<WMRHMD>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Continuous Move"",
            ""bindingGroup"": ""Continuous Move"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Noncontinuous Move"",
            ""bindingGroup"": ""Noncontinuous Move"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // XRI HMD
            m_XRIHMD = asset.FindActionMap("XRI HMD", throwIfNotFound: true);
            m_XRIHMD_Position = m_XRIHMD.FindAction("Position", throwIfNotFound: true);
            m_XRIHMD_Rotation = m_XRIHMD.FindAction("Rotation", throwIfNotFound: true);
            // XRI LeftHand
            m_XRILeftHand = asset.FindActionMap("XRI LeftHand", throwIfNotFound: true);
            m_XRILeftHand_Position = m_XRILeftHand.FindAction("Position", throwIfNotFound: true);
            m_XRILeftHand_Rotation = m_XRILeftHand.FindAction("Rotation", throwIfNotFound: true);
            m_XRILeftHand_Select = m_XRILeftHand.FindAction("Select", throwIfNotFound: true);
            m_XRILeftHand_Activate = m_XRILeftHand.FindAction("Activate", throwIfNotFound: true);
            m_XRILeftHand_UIPress = m_XRILeftHand.FindAction("UI Press", throwIfNotFound: true);
            m_XRILeftHand_HapticDevice = m_XRILeftHand.FindAction("Haptic Device", throwIfNotFound: true);
            m_XRILeftHand_TeleportSelect = m_XRILeftHand.FindAction("Teleport Select", throwIfNotFound: true);
            m_XRILeftHand_TeleportModeActivate = m_XRILeftHand.FindAction("Teleport Mode Activate", throwIfNotFound: true);
            m_XRILeftHand_TeleportModeCancel = m_XRILeftHand.FindAction("Teleport Mode Cancel", throwIfNotFound: true);
            m_XRILeftHand_Turn = m_XRILeftHand.FindAction("Turn", throwIfNotFound: true);
            m_XRILeftHand_Move = m_XRILeftHand.FindAction("Move", throwIfNotFound: true);
            m_XRILeftHand_RotateAnchor = m_XRILeftHand.FindAction("Rotate Anchor", throwIfNotFound: true);
            m_XRILeftHand_TranslateAnchor = m_XRILeftHand.FindAction("Translate Anchor", throwIfNotFound: true);
            m_XRILeftHand_PrimaryButtonPress = m_XRILeftHand.FindAction("Primary Button Press", throwIfNotFound: true);
            m_XRILeftHand_SecondaryButtonPress = m_XRILeftHand.FindAction("Secondary Button Press", throwIfNotFound: true);
            // XRI RightHand
            m_XRIRightHand = asset.FindActionMap("XRI RightHand", throwIfNotFound: true);
            m_XRIRightHand_Position = m_XRIRightHand.FindAction("Position", throwIfNotFound: true);
            m_XRIRightHand_Rotation = m_XRIRightHand.FindAction("Rotation", throwIfNotFound: true);
            m_XRIRightHand_Select = m_XRIRightHand.FindAction("Select", throwIfNotFound: true);
            m_XRIRightHand_Activate = m_XRIRightHand.FindAction("Activate", throwIfNotFound: true);
            m_XRIRightHand_UIPress = m_XRIRightHand.FindAction("UI Press", throwIfNotFound: true);
            m_XRIRightHand_HapticDevice = m_XRIRightHand.FindAction("Haptic Device", throwIfNotFound: true);
            m_XRIRightHand_TeleportSelect = m_XRIRightHand.FindAction("Teleport Select", throwIfNotFound: true);
            m_XRIRightHand_TeleportModeActivate = m_XRIRightHand.FindAction("Teleport Mode Activate", throwIfNotFound: true);
            m_XRIRightHand_TeleportModeCancel = m_XRIRightHand.FindAction("Teleport Mode Cancel", throwIfNotFound: true);
            m_XRIRightHand_Turn = m_XRIRightHand.FindAction("Turn", throwIfNotFound: true);
            m_XRIRightHand_Move = m_XRIRightHand.FindAction("Move", throwIfNotFound: true);
            m_XRIRightHand_RotateAnchor = m_XRIRightHand.FindAction("Rotate Anchor", throwIfNotFound: true);
            m_XRIRightHand_TranslateAnchor = m_XRIRightHand.FindAction("Translate Anchor", throwIfNotFound: true);
            m_XRIRightHand_PrimaryButtonPress = m_XRIRightHand.FindAction("Primary Button Press", throwIfNotFound: true);
            m_XRIRightHand_SecondaryButtonPress = m_XRIRightHand.FindAction("Secondary Button Press", throwIfNotFound: true);
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

        // XRI HMD
        private readonly InputActionMap m_XRIHMD;
        private IXRIHMDActions m_XRIHMDActionsCallbackInterface;
        private readonly InputAction m_XRIHMD_Position;
        private readonly InputAction m_XRIHMD_Rotation;
        public struct XRIHMDActions
        {
            private @XRIDefaultInputActions m_Wrapper;
            public XRIHMDActions(@XRIDefaultInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Position => m_Wrapper.m_XRIHMD_Position;
            public InputAction @Rotation => m_Wrapper.m_XRIHMD_Rotation;
            public InputActionMap Get() { return m_Wrapper.m_XRIHMD; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(XRIHMDActions set) { return set.Get(); }
            public void SetCallbacks(IXRIHMDActions instance)
            {
                if (m_Wrapper.m_XRIHMDActionsCallbackInterface != null)
                {
                    @Position.started -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnPosition;
                    @Rotation.started -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnRotation;
                    @Rotation.performed -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnRotation;
                    @Rotation.canceled -= m_Wrapper.m_XRIHMDActionsCallbackInterface.OnRotation;
                }
                m_Wrapper.m_XRIHMDActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                    @Rotation.started += instance.OnRotation;
                    @Rotation.performed += instance.OnRotation;
                    @Rotation.canceled += instance.OnRotation;
                }
            }
        }
        public XRIHMDActions @XRIHMD => new XRIHMDActions(this);

        // XRI LeftHand
        private readonly InputActionMap m_XRILeftHand;
        private IXRILeftHandActions m_XRILeftHandActionsCallbackInterface;
        private readonly InputAction m_XRILeftHand_Position;
        private readonly InputAction m_XRILeftHand_Rotation;
        private readonly InputAction m_XRILeftHand_Select;
        private readonly InputAction m_XRILeftHand_Activate;
        private readonly InputAction m_XRILeftHand_UIPress;
        private readonly InputAction m_XRILeftHand_HapticDevice;
        private readonly InputAction m_XRILeftHand_TeleportSelect;
        private readonly InputAction m_XRILeftHand_TeleportModeActivate;
        private readonly InputAction m_XRILeftHand_TeleportModeCancel;
        private readonly InputAction m_XRILeftHand_Turn;
        private readonly InputAction m_XRILeftHand_Move;
        private readonly InputAction m_XRILeftHand_RotateAnchor;
        private readonly InputAction m_XRILeftHand_TranslateAnchor;
        private readonly InputAction m_XRILeftHand_PrimaryButtonPress;
        private readonly InputAction m_XRILeftHand_SecondaryButtonPress;
        public struct XRILeftHandActions
        {
            private @XRIDefaultInputActions m_Wrapper;
            public XRILeftHandActions(@XRIDefaultInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Position => m_Wrapper.m_XRILeftHand_Position;
            public InputAction @Rotation => m_Wrapper.m_XRILeftHand_Rotation;
            public InputAction @Select => m_Wrapper.m_XRILeftHand_Select;
            public InputAction @Activate => m_Wrapper.m_XRILeftHand_Activate;
            public InputAction @UIPress => m_Wrapper.m_XRILeftHand_UIPress;
            public InputAction @HapticDevice => m_Wrapper.m_XRILeftHand_HapticDevice;
            public InputAction @TeleportSelect => m_Wrapper.m_XRILeftHand_TeleportSelect;
            public InputAction @TeleportModeActivate => m_Wrapper.m_XRILeftHand_TeleportModeActivate;
            public InputAction @TeleportModeCancel => m_Wrapper.m_XRILeftHand_TeleportModeCancel;
            public InputAction @Turn => m_Wrapper.m_XRILeftHand_Turn;
            public InputAction @Move => m_Wrapper.m_XRILeftHand_Move;
            public InputAction @RotateAnchor => m_Wrapper.m_XRILeftHand_RotateAnchor;
            public InputAction @TranslateAnchor => m_Wrapper.m_XRILeftHand_TranslateAnchor;
            public InputAction @PrimaryButtonPress => m_Wrapper.m_XRILeftHand_PrimaryButtonPress;
            public InputAction @SecondaryButtonPress => m_Wrapper.m_XRILeftHand_SecondaryButtonPress;
            public InputActionMap Get() { return m_Wrapper.m_XRILeftHand; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(XRILeftHandActions set) { return set.Get(); }
            public void SetCallbacks(IXRILeftHandActions instance)
            {
                if (m_Wrapper.m_XRILeftHandActionsCallbackInterface != null)
                {
                    @Position.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPosition;
                    @Rotation.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotation;
                    @Rotation.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotation;
                    @Rotation.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotation;
                    @Select.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSelect;
                    @Select.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSelect;
                    @Select.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSelect;
                    @Activate.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnActivate;
                    @Activate.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnActivate;
                    @Activate.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnActivate;
                    @UIPress.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnUIPress;
                    @UIPress.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnUIPress;
                    @UIPress.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnUIPress;
                    @HapticDevice.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnHapticDevice;
                    @HapticDevice.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnHapticDevice;
                    @HapticDevice.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnHapticDevice;
                    @TeleportSelect.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportSelect;
                    @TeleportSelect.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportSelect;
                    @TeleportSelect.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportSelect;
                    @TeleportModeActivate.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeActivate;
                    @TeleportModeActivate.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeActivate;
                    @TeleportModeActivate.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeActivate;
                    @TeleportModeCancel.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeCancel;
                    @TeleportModeCancel.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeCancel;
                    @TeleportModeCancel.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTeleportModeCancel;
                    @Turn.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTurn;
                    @Turn.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTurn;
                    @Turn.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTurn;
                    @Move.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnMove;
                    @RotateAnchor.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotateAnchor;
                    @RotateAnchor.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotateAnchor;
                    @RotateAnchor.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnRotateAnchor;
                    @TranslateAnchor.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTranslateAnchor;
                    @TranslateAnchor.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTranslateAnchor;
                    @TranslateAnchor.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnTranslateAnchor;
                    @PrimaryButtonPress.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPrimaryButtonPress;
                    @PrimaryButtonPress.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPrimaryButtonPress;
                    @PrimaryButtonPress.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnPrimaryButtonPress;
                    @SecondaryButtonPress.started -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSecondaryButtonPress;
                    @SecondaryButtonPress.performed -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSecondaryButtonPress;
                    @SecondaryButtonPress.canceled -= m_Wrapper.m_XRILeftHandActionsCallbackInterface.OnSecondaryButtonPress;
                }
                m_Wrapper.m_XRILeftHandActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                    @Rotation.started += instance.OnRotation;
                    @Rotation.performed += instance.OnRotation;
                    @Rotation.canceled += instance.OnRotation;
                    @Select.started += instance.OnSelect;
                    @Select.performed += instance.OnSelect;
                    @Select.canceled += instance.OnSelect;
                    @Activate.started += instance.OnActivate;
                    @Activate.performed += instance.OnActivate;
                    @Activate.canceled += instance.OnActivate;
                    @UIPress.started += instance.OnUIPress;
                    @UIPress.performed += instance.OnUIPress;
                    @UIPress.canceled += instance.OnUIPress;
                    @HapticDevice.started += instance.OnHapticDevice;
                    @HapticDevice.performed += instance.OnHapticDevice;
                    @HapticDevice.canceled += instance.OnHapticDevice;
                    @TeleportSelect.started += instance.OnTeleportSelect;
                    @TeleportSelect.performed += instance.OnTeleportSelect;
                    @TeleportSelect.canceled += instance.OnTeleportSelect;
                    @TeleportModeActivate.started += instance.OnTeleportModeActivate;
                    @TeleportModeActivate.performed += instance.OnTeleportModeActivate;
                    @TeleportModeActivate.canceled += instance.OnTeleportModeActivate;
                    @TeleportModeCancel.started += instance.OnTeleportModeCancel;
                    @TeleportModeCancel.performed += instance.OnTeleportModeCancel;
                    @TeleportModeCancel.canceled += instance.OnTeleportModeCancel;
                    @Turn.started += instance.OnTurn;
                    @Turn.performed += instance.OnTurn;
                    @Turn.canceled += instance.OnTurn;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @RotateAnchor.started += instance.OnRotateAnchor;
                    @RotateAnchor.performed += instance.OnRotateAnchor;
                    @RotateAnchor.canceled += instance.OnRotateAnchor;
                    @TranslateAnchor.started += instance.OnTranslateAnchor;
                    @TranslateAnchor.performed += instance.OnTranslateAnchor;
                    @TranslateAnchor.canceled += instance.OnTranslateAnchor;
                    @PrimaryButtonPress.started += instance.OnPrimaryButtonPress;
                    @PrimaryButtonPress.performed += instance.OnPrimaryButtonPress;
                    @PrimaryButtonPress.canceled += instance.OnPrimaryButtonPress;
                    @SecondaryButtonPress.started += instance.OnSecondaryButtonPress;
                    @SecondaryButtonPress.performed += instance.OnSecondaryButtonPress;
                    @SecondaryButtonPress.canceled += instance.OnSecondaryButtonPress;
                }
            }
        }
        public XRILeftHandActions @XRILeftHand => new XRILeftHandActions(this);

        // XRI RightHand
        private readonly InputActionMap m_XRIRightHand;
        private IXRIRightHandActions m_XRIRightHandActionsCallbackInterface;
        private readonly InputAction m_XRIRightHand_Position;
        private readonly InputAction m_XRIRightHand_Rotation;
        private readonly InputAction m_XRIRightHand_Select;
        private readonly InputAction m_XRIRightHand_Activate;
        private readonly InputAction m_XRIRightHand_UIPress;
        private readonly InputAction m_XRIRightHand_HapticDevice;
        private readonly InputAction m_XRIRightHand_TeleportSelect;
        private readonly InputAction m_XRIRightHand_TeleportModeActivate;
        private readonly InputAction m_XRIRightHand_TeleportModeCancel;
        private readonly InputAction m_XRIRightHand_Turn;
        private readonly InputAction m_XRIRightHand_Move;
        private readonly InputAction m_XRIRightHand_RotateAnchor;
        private readonly InputAction m_XRIRightHand_TranslateAnchor;
        private readonly InputAction m_XRIRightHand_PrimaryButtonPress;
        private readonly InputAction m_XRIRightHand_SecondaryButtonPress;
        public struct XRIRightHandActions
        {
            private @XRIDefaultInputActions m_Wrapper;
            public XRIRightHandActions(@XRIDefaultInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Position => m_Wrapper.m_XRIRightHand_Position;
            public InputAction @Rotation => m_Wrapper.m_XRIRightHand_Rotation;
            public InputAction @Select => m_Wrapper.m_XRIRightHand_Select;
            public InputAction @Activate => m_Wrapper.m_XRIRightHand_Activate;
            public InputAction @UIPress => m_Wrapper.m_XRIRightHand_UIPress;
            public InputAction @HapticDevice => m_Wrapper.m_XRIRightHand_HapticDevice;
            public InputAction @TeleportSelect => m_Wrapper.m_XRIRightHand_TeleportSelect;
            public InputAction @TeleportModeActivate => m_Wrapper.m_XRIRightHand_TeleportModeActivate;
            public InputAction @TeleportModeCancel => m_Wrapper.m_XRIRightHand_TeleportModeCancel;
            public InputAction @Turn => m_Wrapper.m_XRIRightHand_Turn;
            public InputAction @Move => m_Wrapper.m_XRIRightHand_Move;
            public InputAction @RotateAnchor => m_Wrapper.m_XRIRightHand_RotateAnchor;
            public InputAction @TranslateAnchor => m_Wrapper.m_XRIRightHand_TranslateAnchor;
            public InputAction @PrimaryButtonPress => m_Wrapper.m_XRIRightHand_PrimaryButtonPress;
            public InputAction @SecondaryButtonPress => m_Wrapper.m_XRIRightHand_SecondaryButtonPress;
            public InputActionMap Get() { return m_Wrapper.m_XRIRightHand; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(XRIRightHandActions set) { return set.Get(); }
            public void SetCallbacks(IXRIRightHandActions instance)
            {
                if (m_Wrapper.m_XRIRightHandActionsCallbackInterface != null)
                {
                    @Position.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPosition;
                    @Rotation.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotation;
                    @Rotation.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotation;
                    @Rotation.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotation;
                    @Select.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSelect;
                    @Select.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSelect;
                    @Select.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSelect;
                    @Activate.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnActivate;
                    @Activate.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnActivate;
                    @Activate.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnActivate;
                    @UIPress.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnUIPress;
                    @UIPress.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnUIPress;
                    @UIPress.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnUIPress;
                    @HapticDevice.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnHapticDevice;
                    @HapticDevice.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnHapticDevice;
                    @HapticDevice.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnHapticDevice;
                    @TeleportSelect.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportSelect;
                    @TeleportSelect.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportSelect;
                    @TeleportSelect.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportSelect;
                    @TeleportModeActivate.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeActivate;
                    @TeleportModeActivate.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeActivate;
                    @TeleportModeActivate.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeActivate;
                    @TeleportModeCancel.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeCancel;
                    @TeleportModeCancel.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeCancel;
                    @TeleportModeCancel.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTeleportModeCancel;
                    @Turn.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTurn;
                    @Turn.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTurn;
                    @Turn.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTurn;
                    @Move.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnMove;
                    @RotateAnchor.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotateAnchor;
                    @RotateAnchor.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotateAnchor;
                    @RotateAnchor.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnRotateAnchor;
                    @TranslateAnchor.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTranslateAnchor;
                    @TranslateAnchor.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTranslateAnchor;
                    @TranslateAnchor.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnTranslateAnchor;
                    @PrimaryButtonPress.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPrimaryButtonPress;
                    @PrimaryButtonPress.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPrimaryButtonPress;
                    @PrimaryButtonPress.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnPrimaryButtonPress;
                    @SecondaryButtonPress.started -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSecondaryButtonPress;
                    @SecondaryButtonPress.performed -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSecondaryButtonPress;
                    @SecondaryButtonPress.canceled -= m_Wrapper.m_XRIRightHandActionsCallbackInterface.OnSecondaryButtonPress;
                }
                m_Wrapper.m_XRIRightHandActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                    @Rotation.started += instance.OnRotation;
                    @Rotation.performed += instance.OnRotation;
                    @Rotation.canceled += instance.OnRotation;
                    @Select.started += instance.OnSelect;
                    @Select.performed += instance.OnSelect;
                    @Select.canceled += instance.OnSelect;
                    @Activate.started += instance.OnActivate;
                    @Activate.performed += instance.OnActivate;
                    @Activate.canceled += instance.OnActivate;
                    @UIPress.started += instance.OnUIPress;
                    @UIPress.performed += instance.OnUIPress;
                    @UIPress.canceled += instance.OnUIPress;
                    @HapticDevice.started += instance.OnHapticDevice;
                    @HapticDevice.performed += instance.OnHapticDevice;
                    @HapticDevice.canceled += instance.OnHapticDevice;
                    @TeleportSelect.started += instance.OnTeleportSelect;
                    @TeleportSelect.performed += instance.OnTeleportSelect;
                    @TeleportSelect.canceled += instance.OnTeleportSelect;
                    @TeleportModeActivate.started += instance.OnTeleportModeActivate;
                    @TeleportModeActivate.performed += instance.OnTeleportModeActivate;
                    @TeleportModeActivate.canceled += instance.OnTeleportModeActivate;
                    @TeleportModeCancel.started += instance.OnTeleportModeCancel;
                    @TeleportModeCancel.performed += instance.OnTeleportModeCancel;
                    @TeleportModeCancel.canceled += instance.OnTeleportModeCancel;
                    @Turn.started += instance.OnTurn;
                    @Turn.performed += instance.OnTurn;
                    @Turn.canceled += instance.OnTurn;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @RotateAnchor.started += instance.OnRotateAnchor;
                    @RotateAnchor.performed += instance.OnRotateAnchor;
                    @RotateAnchor.canceled += instance.OnRotateAnchor;
                    @TranslateAnchor.started += instance.OnTranslateAnchor;
                    @TranslateAnchor.performed += instance.OnTranslateAnchor;
                    @TranslateAnchor.canceled += instance.OnTranslateAnchor;
                    @PrimaryButtonPress.started += instance.OnPrimaryButtonPress;
                    @PrimaryButtonPress.performed += instance.OnPrimaryButtonPress;
                    @PrimaryButtonPress.canceled += instance.OnPrimaryButtonPress;
                    @SecondaryButtonPress.started += instance.OnSecondaryButtonPress;
                    @SecondaryButtonPress.performed += instance.OnSecondaryButtonPress;
                    @SecondaryButtonPress.canceled += instance.OnSecondaryButtonPress;
                }
            }
        }
        public XRIRightHandActions @XRIRightHand => new XRIRightHandActions(this);
        private int m_GenericXRControllerSchemeIndex = -1;
        public InputControlScheme GenericXRControllerScheme
        {
            get
            {
                if (m_GenericXRControllerSchemeIndex == -1) m_GenericXRControllerSchemeIndex = asset.FindControlSchemeIndex("Generic XR Controller");
                return asset.controlSchemes[m_GenericXRControllerSchemeIndex];
            }
        }
        private int m_ContinuousMoveSchemeIndex = -1;
        public InputControlScheme ContinuousMoveScheme
        {
            get
            {
                if (m_ContinuousMoveSchemeIndex == -1) m_ContinuousMoveSchemeIndex = asset.FindControlSchemeIndex("Continuous Move");
                return asset.controlSchemes[m_ContinuousMoveSchemeIndex];
            }
        }
        private int m_NoncontinuousMoveSchemeIndex = -1;
        public InputControlScheme NoncontinuousMoveScheme
        {
            get
            {
                if (m_NoncontinuousMoveSchemeIndex == -1) m_NoncontinuousMoveSchemeIndex = asset.FindControlSchemeIndex("Noncontinuous Move");
                return asset.controlSchemes[m_NoncontinuousMoveSchemeIndex];
            }
        }
        public interface IXRIHMDActions
        {
            void OnPosition(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
        }
        public interface IXRILeftHandActions
        {
            void OnPosition(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
            void OnSelect(InputAction.CallbackContext context);
            void OnActivate(InputAction.CallbackContext context);
            void OnUIPress(InputAction.CallbackContext context);
            void OnHapticDevice(InputAction.CallbackContext context);
            void OnTeleportSelect(InputAction.CallbackContext context);
            void OnTeleportModeActivate(InputAction.CallbackContext context);
            void OnTeleportModeCancel(InputAction.CallbackContext context);
            void OnTurn(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnRotateAnchor(InputAction.CallbackContext context);
            void OnTranslateAnchor(InputAction.CallbackContext context);
            void OnPrimaryButtonPress(InputAction.CallbackContext context);
            void OnSecondaryButtonPress(InputAction.CallbackContext context);
        }
        public interface IXRIRightHandActions
        {
            void OnPosition(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
            void OnSelect(InputAction.CallbackContext context);
            void OnActivate(InputAction.CallbackContext context);
            void OnUIPress(InputAction.CallbackContext context);
            void OnHapticDevice(InputAction.CallbackContext context);
            void OnTeleportSelect(InputAction.CallbackContext context);
            void OnTeleportModeActivate(InputAction.CallbackContext context);
            void OnTeleportModeCancel(InputAction.CallbackContext context);
            void OnTurn(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnRotateAnchor(InputAction.CallbackContext context);
            void OnTranslateAnchor(InputAction.CallbackContext context);
            void OnPrimaryButtonPress(InputAction.CallbackContext context);
            void OnSecondaryButtonPress(InputAction.CallbackContext context);
        }
    }
}
