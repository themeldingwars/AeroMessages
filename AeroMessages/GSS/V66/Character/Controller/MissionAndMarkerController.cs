using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Character.Controller
{
    [Aero(AeroGenTypes.Controller)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 4, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 4, 4)]
    public partial class MissionAndMarkerController
    {
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_0;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_1;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_2;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_3;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_4;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_5;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_6;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_7;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_8;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_9;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_10;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_11;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_12;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_13;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_14;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_15;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_16;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_17;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_18;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_19;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_20;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_21;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_22;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_23;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_24;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_25;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_26;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_27;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_28;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_29;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_30;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_31;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_32;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_33;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_34;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_35;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_36;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_37;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_38;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_39;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_40;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_41;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_42;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_43;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_44;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_45;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_46;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_47;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_48;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_49;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_50;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_51;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_52;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_53;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_54;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_55;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_56;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_57;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_58;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_59;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_60;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_61;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_62;
        [AeroNullable] private PersonalMapMarkerData PersonalMapMarkers_63;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_0;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_1;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_2;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_3;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_4;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_5;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_6;
        [AeroNullable] private AreaMapMarkerData AreaMapMarkers_7;
        [AeroNullable] private ContextFlagData ContextFlags_0;
        [AeroNullable] private ContextFlagData ContextFlags_1;
        [AeroNullable] private ContextFlagData ContextFlags_2;
        [AeroNullable] private ContextFlagData ContextFlags_3;
        [AeroNullable] private ContextFlagData ContextFlags_4;
        [AeroNullable] private ContextFlagData ContextFlags_5;
        [AeroNullable] private ContextFlagData ContextFlags_6;
        [AeroNullable] private ContextFlagData ContextFlags_7;
        [AeroNullable] private ContextFlagData ContextFlags_8;
        [AeroNullable] private ContextFlagData ContextFlags_9;
        [AeroNullable] private ContextFlagData ContextFlags_10;
        [AeroNullable] private ContextFlagData ContextFlags_11;
        [AeroNullable] private ContextFlagData ContextFlags_12;
        [AeroNullable] private ContextFlagData ContextFlags_13;
        [AeroNullable] private ContextFlagData ContextFlags_14;
        [AeroNullable] private ContextFlagData ContextFlags_15;
        [AeroNullable] private ContextFlagData ContextFlags_16;
        [AeroNullable] private ContextFlagData ContextFlags_17;
        [AeroNullable] private ContextFlagData ContextFlags_18;
        [AeroNullable] private ContextFlagData ContextFlags_19;
        [AeroNullable] private ContextFlagData ContextFlags_20;
        [AeroNullable] private ContextFlagData ContextFlags_21;
        [AeroNullable] private ContextFlagData ContextFlags_22;
        [AeroNullable] private ContextFlagData ContextFlags_23;
    }

    [AeroBlock]
    public struct PersonalMapMarkerData
    {
        [AeroSdb("dbencounterdata::MapMarkerInfo", "id")]
        public ushort MarkerType;
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint TitleId;
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint DescriptionId;
        public EntityId EncounterId;
        public EntityId EncounterMarkerId; // No controller specified.

        public byte HasDuration;
        [AeroIf(nameof(HasDuration), 1)]
        public uint ExpireAtTime; // Gametime ms

        public Vector3 Position;
    }

    [AeroBlock]
    public struct AreaMapMarkerData
    {
        public uint Unk2;
        public uint Unk3;
        public EntityId EncounterId;
        public EntityId EncounterMarkerId; // No controller specified.

        public byte HasDuration;
        [AeroIf(nameof(HasDuration), 1)]
        public uint ExpireAtTime; // Gametime ms

        public Vector3 Position;

        [AeroArray(typeof(byte))] public AeraMapMarkerInnerData[] Unk4;
    }

    [AeroBlock]
    public struct AeraMapMarkerInnerData
    {
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct ContextFlagData
    {
        public ushort Unk1;
        public byte Unk2;
    }
}