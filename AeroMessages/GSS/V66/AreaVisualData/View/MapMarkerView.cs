using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.AreaVisualData.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 22, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 22, 3)]
    public partial class MapMarkerView
    {
        private Vector3 Position;

        [AeroNullable] private MapMarkerData MapMarkers_0;
        [AeroNullable] private MapMarkerData MapMarkers_1;
        [AeroNullable] private MapMarkerData MapMarkers_2;
        [AeroNullable] private MapMarkerData MapMarkers_3;
        [AeroNullable] private MapMarkerData MapMarkers_4;
        [AeroNullable] private MapMarkerData MapMarkers_5;
        [AeroNullable] private MapMarkerData MapMarkers_6;
        [AeroNullable] private MapMarkerData MapMarkers_7;
        [AeroNullable] private MapMarkerData MapMarkers_8;
        [AeroNullable] private MapMarkerData MapMarkers_9;
        [AeroNullable] private MapMarkerData MapMarkers_10;
        [AeroNullable] private MapMarkerData MapMarkers_11;
        [AeroNullable] private MapMarkerData MapMarkers_12;
        [AeroNullable] private MapMarkerData MapMarkers_13;
        [AeroNullable] private MapMarkerData MapMarkers_14;
        [AeroNullable] private MapMarkerData MapMarkers_15;
        [AeroNullable] private MapMarkerData MapMarkers_16;
        [AeroNullable] private MapMarkerData MapMarkers_17;
        [AeroNullable] private MapMarkerData MapMarkers_18;
        [AeroNullable] private MapMarkerData MapMarkers_19;
        [AeroNullable] private MapMarkerData MapMarkers_20;
        [AeroNullable] private MapMarkerData MapMarkers_21;
        [AeroNullable] private MapMarkerData MapMarkers_22;
        [AeroNullable] private MapMarkerData MapMarkers_23;
        [AeroNullable] private MapMarkerData MapMarkers_24;
        [AeroNullable] private MapMarkerData MapMarkers_25;
        [AeroNullable] private MapMarkerData MapMarkers_26;
        [AeroNullable] private MapMarkerData MapMarkers_27;
        [AeroNullable] private MapMarkerData MapMarkers_28;
        [AeroNullable] private MapMarkerData MapMarkers_29;
        [AeroNullable] private MapMarkerData MapMarkers_30;
        [AeroNullable] private MapMarkerData MapMarkers_31;
        [AeroNullable] private MapMarkerData MapMarkers_32;
        [AeroNullable] private MapMarkerData MapMarkers_33;
        [AeroNullable] private MapMarkerData MapMarkers_34;
    }

    [AeroBlock]
    public struct MapMarkerData
    {
        [AeroSdb("dbencounterdata::MapMarkerInfo", "id")]
        public ushort MarkerType; // Weird
        public uint Unk2;
        public uint Unk3;

        public EntityId EncounterId;
        public EntityId EncounterMarkerId; // No controller specified.

        public byte HasDuration;
        [AeroIf(nameof(HasDuration), 1)]
        public uint ExpireAtTime; // Gametime ms

        public HalfVector3 Position;
    }
}