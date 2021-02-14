// GENERATED AUTOMATICALLY FROM 'Assets/NWH/Vehicle Physics 2/Scripts/Vehicle/Control/Input/InputProviders/InputSystem/VehicleInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace NWH.VehiclePhysics2.Input
{
    public class @VehicleInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @VehicleInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""VehicleInputActions"",
    ""maps"": [
        {
            ""name"": ""Vehicle Controls"",
            ""id"": ""200a0048-834b-4c46-8e58-cb0180a3f09b"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""4c14d84a-48f6-429e-9111-d009cff86527"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""067e3728-8c0e-4c68-8b07-765ef5a0b2ff"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brakes"",
                    ""type"": ""Value"",
                    ""id"": ""063dcbbf-0a3c-4282-90a5-ec46c6b1db95"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Clutch"",
                    ""type"": ""Value"",
                    ""id"": ""036104a2-f1da-429a-b3bf-75c4e539a58d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Value"",
                    ""id"": ""6502904b-df3b-4a12-b9ca-b365d43db960"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EngineStartStop"",
                    ""type"": ""Button"",
                    ""id"": ""aa0a9858-ed3f-472c-96f9-4fdf0346726d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftUp"",
                    ""type"": ""Button"",
                    ""id"": ""4fa6a7ca-d894-4cd6-8592-7e34c66a8190"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftDown"",
                    ""type"": ""Button"",
                    ""id"": ""180cb808-2f04-48c7-9551-a2859fff6752"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftBlinker"",
                    ""type"": ""Button"",
                    ""id"": ""8f13ab7c-233f-4736-bbfa-c5f202240ad1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightBlinker"",
                    ""type"": ""Button"",
                    ""id"": ""62880158-789b-43bb-bd49-c3bf25e94c87"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LowBeamLights"",
                    ""type"": ""Button"",
                    ""id"": ""6536d934-38cf-48a6-afa1-16d6ed8f421c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HighBeamLights"",
                    ""type"": ""Button"",
                    ""id"": ""8af605a2-5581-4c32-9e35-2f80d0250a3e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HazardLights"",
                    ""type"": ""Button"",
                    ""id"": ""4e80b995-afae-4eb7-bd57-c2685a0c4388"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExtraLights"",
                    ""type"": ""Button"",
                    ""id"": ""47c64239-6f45-41be-ba39-f8b1966b4170"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrailerAttachDetach"",
                    ""type"": ""Button"",
                    ""id"": ""d1143207-7243-4236-95d0-54b07f8caaf1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horn"",
                    ""type"": ""Button"",
                    ""id"": ""2a4bc293-16f8-47c1-8532-bc82b3905f77"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftIntoR1"",
                    ""type"": ""Button"",
                    ""id"": ""fdf654af-5894-4876-9565-8e64e1f53efa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto0"",
                    ""type"": ""Button"",
                    ""id"": ""2ee85004-4812-4a6a-bb27-7c535a276c1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto1"",
                    ""type"": ""Button"",
                    ""id"": ""b6f6becb-e7c2-4a15-8288-797cf992242c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto2"",
                    ""type"": ""Button"",
                    ""id"": ""4e82356c-b972-494a-9c0b-6031cd291630"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto3"",
                    ""type"": ""Button"",
                    ""id"": ""aae19f07-e299-427a-8033-23a590c791d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto4"",
                    ""type"": ""Button"",
                    ""id"": ""4e5032a3-39df-4dc8-a307-485c7a996b50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto5"",
                    ""type"": ""Button"",
                    ""id"": ""93decc9e-67a4-4d2e-a2aa-02cae173ffbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto6"",
                    ""type"": ""Button"",
                    ""id"": ""8a253467-ad3e-4c6c-b0dd-fc030cf1db5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto7"",
                    ""type"": ""Button"",
                    ""id"": ""cf66f6fe-1e63-45fc-a7dc-732882ca95fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftInto8"",
                    ""type"": ""Button"",
                    ""id"": ""4e7aa765-fdc6-4098-b90d-a2017111fafd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipOver"",
                    ""type"": ""Button"",
                    ""id"": ""238902b2-609f-4842-bd46-b5b15a8bd829"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""6de7528e-5f55-46a1-8fc6-bd19214b263c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CruiseControl"",
                    ""type"": ""Button"",
                    ""id"": ""c2c193e5-0ba5-4cdc-a189-84ccae17d118"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""35b97d96-fd20-4097-8fb3-e4a275703cfd"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EngineStartStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cb1f792-d862-4891-8e4f-156d57a4829e"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc3a7a67-1f90-4e7c-b07c-18f1dc7d6902"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c4a4e7e-d035-447e-aaae-a5fb5f586cce"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3d427b4-5535-4cde-93b8-39952f11604f"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c80687f6-73d6-4d12-a7ec-bfd5f70b9c1f"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftBlinker"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""685cee63-e7f3-4a07-a8e3-bf34b04f0b47"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightBlinker"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2ec8fbe-9683-4987-931d-57ea5713d264"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LowBeamLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c49dc91a-be6d-4a78-ae0c-cfd55da21347"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LowBeamLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba07cb72-8b32-40a6-b7b7-49fda5a5696a"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighBeamLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47963c3f-83fc-444f-be98-2c2ad7dd5898"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HazardLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0f9f750-4f64-4408-9d29-295d1fd9c54e"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExtraLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95f029b5-d826-4702-888f-47f7e793f787"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrailerAttachDetach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbddc214-430c-4d0b-8003-11f10876d005"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrailerAttachDetach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67c9fe69-ff40-4fe2-8412-6d8f476f5d93"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81844531-f08f-4aa7-8e3f-26f755bc62f3"",
                    ""path"": ""<Keyboard>/minus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftIntoR1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2489f77-0bdb-4561-a6b7-45708fd8b7dc"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c57a7e33-e49e-4bd9-b5a1-a33861f506d9"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abcd6d75-1316-4eda-87e5-9644bd935300"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""669d3a9c-c9fe-42f5-9057-8f0cb31e0b96"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4d8b40a-ee7f-495f-be9a-20d75f9e8a04"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2c47890-4ff7-4795-8d55-20fb2e40a543"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aeff3f22-e375-486e-a67e-b88f1bd384e5"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e7e74b3-942e-4649-b2d3-8bb7d139bf5e"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac654d38-d65d-40e4-9796-8c17eede2112"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftInto8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""074547a7-a3ea-4b53-a88f-599e9a8004b0"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipOver"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76b93c66-3dac-4d90-ac1f-aae6a399a31e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68e6d03c-1dd8-4b1b-9a6e-bbe32edef279"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86494961-cebe-49ae-bbfe-950e9a17c5f9"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CruiseControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""1bff6693-e128-4d74-ad2f-ad4e229608a8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""6a4beedd-9d33-48f8-ab0b-2fa4835b56d5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""3ce20f4e-6e04-4810-b8c6-829ced054390"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""acf664f4-dde0-4367-8e3a-7fbdf293bc0c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0332ccc4-b818-41e6-8455-330ec56c13de"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""89725913-86df-4c0b-893e-7dab71609463"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""866afad4-aa6f-444a-8122-260b6292b1d2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1ca21924-c96b-474a-a54b-b585c2e71ec2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""e484e077-2222-4195-b4c0-92d2608ae41c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2d33c1e7-80af-4289-b8fa-c30c539b46bf"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""68c44959-158f-4a90-a301-94ab2339beee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8601f7ae-fd79-42d3-bd51-c0054d12b6f7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""405ba6f9-74dd-4b74-8687-7dda1bc905d3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7d163169-2e04-49bb-8dad-3fa803f4201e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""079d6648-edd9-46d8-ae9b-ab8fced71ba4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brakes"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8d444115-e1a0-4c2a-864c-fbd63db53c90"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""4c6d18cf-e9dc-4ffd-a439-ed257cb0c16a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brakes"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cf160faf-0e28-4998-94ee-ce086b4b76c5"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Vehicle Controls
            m_VehicleControls = asset.FindActionMap("Vehicle Controls", throwIfNotFound: true);
            m_VehicleControls_Steering = m_VehicleControls.FindAction("Steering", throwIfNotFound: true);
            m_VehicleControls_Throttle = m_VehicleControls.FindAction("Throttle", throwIfNotFound: true);
            m_VehicleControls_Brakes = m_VehicleControls.FindAction("Brakes", throwIfNotFound: true);
            m_VehicleControls_Clutch = m_VehicleControls.FindAction("Clutch", throwIfNotFound: true);
            m_VehicleControls_Handbrake = m_VehicleControls.FindAction("Handbrake", throwIfNotFound: true);
            m_VehicleControls_EngineStartStop = m_VehicleControls.FindAction("EngineStartStop", throwIfNotFound: true);
            m_VehicleControls_ShiftUp = m_VehicleControls.FindAction("ShiftUp", throwIfNotFound: true);
            m_VehicleControls_ShiftDown = m_VehicleControls.FindAction("ShiftDown", throwIfNotFound: true);
            m_VehicleControls_LeftBlinker = m_VehicleControls.FindAction("LeftBlinker", throwIfNotFound: true);
            m_VehicleControls_RightBlinker = m_VehicleControls.FindAction("RightBlinker", throwIfNotFound: true);
            m_VehicleControls_LowBeamLights = m_VehicleControls.FindAction("LowBeamLights", throwIfNotFound: true);
            m_VehicleControls_HighBeamLights = m_VehicleControls.FindAction("HighBeamLights", throwIfNotFound: true);
            m_VehicleControls_HazardLights = m_VehicleControls.FindAction("HazardLights", throwIfNotFound: true);
            m_VehicleControls_ExtraLights = m_VehicleControls.FindAction("ExtraLights", throwIfNotFound: true);
            m_VehicleControls_TrailerAttachDetach = m_VehicleControls.FindAction("TrailerAttachDetach", throwIfNotFound: true);
            m_VehicleControls_Horn = m_VehicleControls.FindAction("Horn", throwIfNotFound: true);
            m_VehicleControls_ShiftIntoR1 = m_VehicleControls.FindAction("ShiftIntoR1", throwIfNotFound: true);
            m_VehicleControls_ShiftInto0 = m_VehicleControls.FindAction("ShiftInto0", throwIfNotFound: true);
            m_VehicleControls_ShiftInto1 = m_VehicleControls.FindAction("ShiftInto1", throwIfNotFound: true);
            m_VehicleControls_ShiftInto2 = m_VehicleControls.FindAction("ShiftInto2", throwIfNotFound: true);
            m_VehicleControls_ShiftInto3 = m_VehicleControls.FindAction("ShiftInto3", throwIfNotFound: true);
            m_VehicleControls_ShiftInto4 = m_VehicleControls.FindAction("ShiftInto4", throwIfNotFound: true);
            m_VehicleControls_ShiftInto5 = m_VehicleControls.FindAction("ShiftInto5", throwIfNotFound: true);
            m_VehicleControls_ShiftInto6 = m_VehicleControls.FindAction("ShiftInto6", throwIfNotFound: true);
            m_VehicleControls_ShiftInto7 = m_VehicleControls.FindAction("ShiftInto7", throwIfNotFound: true);
            m_VehicleControls_ShiftInto8 = m_VehicleControls.FindAction("ShiftInto8", throwIfNotFound: true);
            m_VehicleControls_FlipOver = m_VehicleControls.FindAction("FlipOver", throwIfNotFound: true);
            m_VehicleControls_Boost = m_VehicleControls.FindAction("Boost", throwIfNotFound: true);
            m_VehicleControls_CruiseControl = m_VehicleControls.FindAction("CruiseControl", throwIfNotFound: true);
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

        // Vehicle Controls
        private readonly InputActionMap m_VehicleControls;
        private IVehicleControlsActions m_VehicleControlsActionsCallbackInterface;
        private readonly InputAction m_VehicleControls_Steering;
        private readonly InputAction m_VehicleControls_Throttle;
        private readonly InputAction m_VehicleControls_Brakes;
        private readonly InputAction m_VehicleControls_Clutch;
        private readonly InputAction m_VehicleControls_Handbrake;
        private readonly InputAction m_VehicleControls_EngineStartStop;
        private readonly InputAction m_VehicleControls_ShiftUp;
        private readonly InputAction m_VehicleControls_ShiftDown;
        private readonly InputAction m_VehicleControls_LeftBlinker;
        private readonly InputAction m_VehicleControls_RightBlinker;
        private readonly InputAction m_VehicleControls_LowBeamLights;
        private readonly InputAction m_VehicleControls_HighBeamLights;
        private readonly InputAction m_VehicleControls_HazardLights;
        private readonly InputAction m_VehicleControls_ExtraLights;
        private readonly InputAction m_VehicleControls_TrailerAttachDetach;
        private readonly InputAction m_VehicleControls_Horn;
        private readonly InputAction m_VehicleControls_ShiftIntoR1;
        private readonly InputAction m_VehicleControls_ShiftInto0;
        private readonly InputAction m_VehicleControls_ShiftInto1;
        private readonly InputAction m_VehicleControls_ShiftInto2;
        private readonly InputAction m_VehicleControls_ShiftInto3;
        private readonly InputAction m_VehicleControls_ShiftInto4;
        private readonly InputAction m_VehicleControls_ShiftInto5;
        private readonly InputAction m_VehicleControls_ShiftInto6;
        private readonly InputAction m_VehicleControls_ShiftInto7;
        private readonly InputAction m_VehicleControls_ShiftInto8;
        private readonly InputAction m_VehicleControls_FlipOver;
        private readonly InputAction m_VehicleControls_Boost;
        private readonly InputAction m_VehicleControls_CruiseControl;
        public struct VehicleControlsActions
        {
            private @VehicleInputActions m_Wrapper;
            public VehicleControlsActions(@VehicleInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Steering => m_Wrapper.m_VehicleControls_Steering;
            public InputAction @Throttle => m_Wrapper.m_VehicleControls_Throttle;
            public InputAction @Brakes => m_Wrapper.m_VehicleControls_Brakes;
            public InputAction @Clutch => m_Wrapper.m_VehicleControls_Clutch;
            public InputAction @Handbrake => m_Wrapper.m_VehicleControls_Handbrake;
            public InputAction @EngineStartStop => m_Wrapper.m_VehicleControls_EngineStartStop;
            public InputAction @ShiftUp => m_Wrapper.m_VehicleControls_ShiftUp;
            public InputAction @ShiftDown => m_Wrapper.m_VehicleControls_ShiftDown;
            public InputAction @LeftBlinker => m_Wrapper.m_VehicleControls_LeftBlinker;
            public InputAction @RightBlinker => m_Wrapper.m_VehicleControls_RightBlinker;
            public InputAction @LowBeamLights => m_Wrapper.m_VehicleControls_LowBeamLights;
            public InputAction @HighBeamLights => m_Wrapper.m_VehicleControls_HighBeamLights;
            public InputAction @HazardLights => m_Wrapper.m_VehicleControls_HazardLights;
            public InputAction @ExtraLights => m_Wrapper.m_VehicleControls_ExtraLights;
            public InputAction @TrailerAttachDetach => m_Wrapper.m_VehicleControls_TrailerAttachDetach;
            public InputAction @Horn => m_Wrapper.m_VehicleControls_Horn;
            public InputAction @ShiftIntoR1 => m_Wrapper.m_VehicleControls_ShiftIntoR1;
            public InputAction @ShiftInto0 => m_Wrapper.m_VehicleControls_ShiftInto0;
            public InputAction @ShiftInto1 => m_Wrapper.m_VehicleControls_ShiftInto1;
            public InputAction @ShiftInto2 => m_Wrapper.m_VehicleControls_ShiftInto2;
            public InputAction @ShiftInto3 => m_Wrapper.m_VehicleControls_ShiftInto3;
            public InputAction @ShiftInto4 => m_Wrapper.m_VehicleControls_ShiftInto4;
            public InputAction @ShiftInto5 => m_Wrapper.m_VehicleControls_ShiftInto5;
            public InputAction @ShiftInto6 => m_Wrapper.m_VehicleControls_ShiftInto6;
            public InputAction @ShiftInto7 => m_Wrapper.m_VehicleControls_ShiftInto7;
            public InputAction @ShiftInto8 => m_Wrapper.m_VehicleControls_ShiftInto8;
            public InputAction @FlipOver => m_Wrapper.m_VehicleControls_FlipOver;
            public InputAction @Boost => m_Wrapper.m_VehicleControls_Boost;
            public InputAction @CruiseControl => m_Wrapper.m_VehicleControls_CruiseControl;
            public InputActionMap Get() { return m_Wrapper.m_VehicleControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(VehicleControlsActions set) { return set.Get(); }
            public void SetCallbacks(IVehicleControlsActions instance)
            {
                if (m_Wrapper.m_VehicleControlsActionsCallbackInterface != null)
                {
                    @Steering.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnSteering;
                    @Steering.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnSteering;
                    @Steering.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnSteering;
                    @Throttle.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnThrottle;
                    @Throttle.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnThrottle;
                    @Throttle.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnThrottle;
                    @Brakes.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnBrakes;
                    @Brakes.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnBrakes;
                    @Brakes.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnBrakes;
                    @Clutch.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnClutch;
                    @Clutch.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnClutch;
                    @Clutch.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnClutch;
                    @Handbrake.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHandbrake;
                    @Handbrake.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHandbrake;
                    @Handbrake.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHandbrake;
                    @EngineStartStop.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnEngineStartStop;
                    @EngineStartStop.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnEngineStartStop;
                    @EngineStartStop.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnEngineStartStop;
                    @ShiftUp.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftUp;
                    @ShiftUp.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftUp;
                    @ShiftUp.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftUp;
                    @ShiftDown.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftDown;
                    @ShiftDown.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftDown;
                    @ShiftDown.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftDown;
                    @LeftBlinker.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnLeftBlinker;
                    @LeftBlinker.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnLeftBlinker;
                    @LeftBlinker.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnLeftBlinker;
                    @RightBlinker.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnRightBlinker;
                    @RightBlinker.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnRightBlinker;
                    @RightBlinker.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnRightBlinker;
                    @LowBeamLights.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnLowBeamLights;
                    @LowBeamLights.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnLowBeamLights;
                    @LowBeamLights.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnLowBeamLights;
                    @HighBeamLights.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHighBeamLights;
                    @HighBeamLights.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHighBeamLights;
                    @HighBeamLights.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHighBeamLights;
                    @HazardLights.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHazardLights;
                    @HazardLights.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHazardLights;
                    @HazardLights.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHazardLights;
                    @ExtraLights.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnExtraLights;
                    @ExtraLights.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnExtraLights;
                    @ExtraLights.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnExtraLights;
                    @TrailerAttachDetach.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnTrailerAttachDetach;
                    @TrailerAttachDetach.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnTrailerAttachDetach;
                    @TrailerAttachDetach.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnTrailerAttachDetach;
                    @Horn.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHorn;
                    @Horn.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHorn;
                    @Horn.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnHorn;
                    @ShiftIntoR1.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftIntoR1;
                    @ShiftIntoR1.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftIntoR1;
                    @ShiftIntoR1.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftIntoR1;
                    @ShiftInto0.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto0;
                    @ShiftInto0.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto0;
                    @ShiftInto0.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto0;
                    @ShiftInto1.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto1;
                    @ShiftInto1.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto1;
                    @ShiftInto1.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto1;
                    @ShiftInto2.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto2;
                    @ShiftInto2.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto2;
                    @ShiftInto2.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto2;
                    @ShiftInto3.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto3;
                    @ShiftInto3.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto3;
                    @ShiftInto3.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto3;
                    @ShiftInto4.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto4;
                    @ShiftInto4.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto4;
                    @ShiftInto4.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto4;
                    @ShiftInto5.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto5;
                    @ShiftInto5.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto5;
                    @ShiftInto5.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto5;
                    @ShiftInto6.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto6;
                    @ShiftInto6.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto6;
                    @ShiftInto6.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto6;
                    @ShiftInto7.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto7;
                    @ShiftInto7.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto7;
                    @ShiftInto7.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto7;
                    @ShiftInto8.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto8;
                    @ShiftInto8.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto8;
                    @ShiftInto8.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnShiftInto8;
                    @FlipOver.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnFlipOver;
                    @FlipOver.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnFlipOver;
                    @FlipOver.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnFlipOver;
                    @Boost.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnBoost;
                    @Boost.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnBoost;
                    @Boost.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnBoost;
                    @CruiseControl.started -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnCruiseControl;
                    @CruiseControl.performed -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnCruiseControl;
                    @CruiseControl.canceled -= m_Wrapper.m_VehicleControlsActionsCallbackInterface.OnCruiseControl;
                }
                m_Wrapper.m_VehicleControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Steering.started += instance.OnSteering;
                    @Steering.performed += instance.OnSteering;
                    @Steering.canceled += instance.OnSteering;
                    @Throttle.started += instance.OnThrottle;
                    @Throttle.performed += instance.OnThrottle;
                    @Throttle.canceled += instance.OnThrottle;
                    @Brakes.started += instance.OnBrakes;
                    @Brakes.performed += instance.OnBrakes;
                    @Brakes.canceled += instance.OnBrakes;
                    @Clutch.started += instance.OnClutch;
                    @Clutch.performed += instance.OnClutch;
                    @Clutch.canceled += instance.OnClutch;
                    @Handbrake.started += instance.OnHandbrake;
                    @Handbrake.performed += instance.OnHandbrake;
                    @Handbrake.canceled += instance.OnHandbrake;
                    @EngineStartStop.started += instance.OnEngineStartStop;
                    @EngineStartStop.performed += instance.OnEngineStartStop;
                    @EngineStartStop.canceled += instance.OnEngineStartStop;
                    @ShiftUp.started += instance.OnShiftUp;
                    @ShiftUp.performed += instance.OnShiftUp;
                    @ShiftUp.canceled += instance.OnShiftUp;
                    @ShiftDown.started += instance.OnShiftDown;
                    @ShiftDown.performed += instance.OnShiftDown;
                    @ShiftDown.canceled += instance.OnShiftDown;
                    @LeftBlinker.started += instance.OnLeftBlinker;
                    @LeftBlinker.performed += instance.OnLeftBlinker;
                    @LeftBlinker.canceled += instance.OnLeftBlinker;
                    @RightBlinker.started += instance.OnRightBlinker;
                    @RightBlinker.performed += instance.OnRightBlinker;
                    @RightBlinker.canceled += instance.OnRightBlinker;
                    @LowBeamLights.started += instance.OnLowBeamLights;
                    @LowBeamLights.performed += instance.OnLowBeamLights;
                    @LowBeamLights.canceled += instance.OnLowBeamLights;
                    @HighBeamLights.started += instance.OnHighBeamLights;
                    @HighBeamLights.performed += instance.OnHighBeamLights;
                    @HighBeamLights.canceled += instance.OnHighBeamLights;
                    @HazardLights.started += instance.OnHazardLights;
                    @HazardLights.performed += instance.OnHazardLights;
                    @HazardLights.canceled += instance.OnHazardLights;
                    @ExtraLights.started += instance.OnExtraLights;
                    @ExtraLights.performed += instance.OnExtraLights;
                    @ExtraLights.canceled += instance.OnExtraLights;
                    @TrailerAttachDetach.started += instance.OnTrailerAttachDetach;
                    @TrailerAttachDetach.performed += instance.OnTrailerAttachDetach;
                    @TrailerAttachDetach.canceled += instance.OnTrailerAttachDetach;
                    @Horn.started += instance.OnHorn;
                    @Horn.performed += instance.OnHorn;
                    @Horn.canceled += instance.OnHorn;
                    @ShiftIntoR1.started += instance.OnShiftIntoR1;
                    @ShiftIntoR1.performed += instance.OnShiftIntoR1;
                    @ShiftIntoR1.canceled += instance.OnShiftIntoR1;
                    @ShiftInto0.started += instance.OnShiftInto0;
                    @ShiftInto0.performed += instance.OnShiftInto0;
                    @ShiftInto0.canceled += instance.OnShiftInto0;
                    @ShiftInto1.started += instance.OnShiftInto1;
                    @ShiftInto1.performed += instance.OnShiftInto1;
                    @ShiftInto1.canceled += instance.OnShiftInto1;
                    @ShiftInto2.started += instance.OnShiftInto2;
                    @ShiftInto2.performed += instance.OnShiftInto2;
                    @ShiftInto2.canceled += instance.OnShiftInto2;
                    @ShiftInto3.started += instance.OnShiftInto3;
                    @ShiftInto3.performed += instance.OnShiftInto3;
                    @ShiftInto3.canceled += instance.OnShiftInto3;
                    @ShiftInto4.started += instance.OnShiftInto4;
                    @ShiftInto4.performed += instance.OnShiftInto4;
                    @ShiftInto4.canceled += instance.OnShiftInto4;
                    @ShiftInto5.started += instance.OnShiftInto5;
                    @ShiftInto5.performed += instance.OnShiftInto5;
                    @ShiftInto5.canceled += instance.OnShiftInto5;
                    @ShiftInto6.started += instance.OnShiftInto6;
                    @ShiftInto6.performed += instance.OnShiftInto6;
                    @ShiftInto6.canceled += instance.OnShiftInto6;
                    @ShiftInto7.started += instance.OnShiftInto7;
                    @ShiftInto7.performed += instance.OnShiftInto7;
                    @ShiftInto7.canceled += instance.OnShiftInto7;
                    @ShiftInto8.started += instance.OnShiftInto8;
                    @ShiftInto8.performed += instance.OnShiftInto8;
                    @ShiftInto8.canceled += instance.OnShiftInto8;
                    @FlipOver.started += instance.OnFlipOver;
                    @FlipOver.performed += instance.OnFlipOver;
                    @FlipOver.canceled += instance.OnFlipOver;
                    @Boost.started += instance.OnBoost;
                    @Boost.performed += instance.OnBoost;
                    @Boost.canceled += instance.OnBoost;
                    @CruiseControl.started += instance.OnCruiseControl;
                    @CruiseControl.performed += instance.OnCruiseControl;
                    @CruiseControl.canceled += instance.OnCruiseControl;
                }
            }
        }
        public VehicleControlsActions @VehicleControls => new VehicleControlsActions(this);
        public interface IVehicleControlsActions
        {
            void OnSteering(InputAction.CallbackContext context);
            void OnThrottle(InputAction.CallbackContext context);
            void OnBrakes(InputAction.CallbackContext context);
            void OnClutch(InputAction.CallbackContext context);
            void OnHandbrake(InputAction.CallbackContext context);
            void OnEngineStartStop(InputAction.CallbackContext context);
            void OnShiftUp(InputAction.CallbackContext context);
            void OnShiftDown(InputAction.CallbackContext context);
            void OnLeftBlinker(InputAction.CallbackContext context);
            void OnRightBlinker(InputAction.CallbackContext context);
            void OnLowBeamLights(InputAction.CallbackContext context);
            void OnHighBeamLights(InputAction.CallbackContext context);
            void OnHazardLights(InputAction.CallbackContext context);
            void OnExtraLights(InputAction.CallbackContext context);
            void OnTrailerAttachDetach(InputAction.CallbackContext context);
            void OnHorn(InputAction.CallbackContext context);
            void OnShiftIntoR1(InputAction.CallbackContext context);
            void OnShiftInto0(InputAction.CallbackContext context);
            void OnShiftInto1(InputAction.CallbackContext context);
            void OnShiftInto2(InputAction.CallbackContext context);
            void OnShiftInto3(InputAction.CallbackContext context);
            void OnShiftInto4(InputAction.CallbackContext context);
            void OnShiftInto5(InputAction.CallbackContext context);
            void OnShiftInto6(InputAction.CallbackContext context);
            void OnShiftInto7(InputAction.CallbackContext context);
            void OnShiftInto8(InputAction.CallbackContext context);
            void OnFlipOver(InputAction.CallbackContext context);
            void OnBoost(InputAction.CallbackContext context);
            void OnCruiseControl(InputAction.CallbackContext context);
        }
    }
}
