/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 22
    TypeName: AreaVisualData::MapMarkerView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.AreaVisualData
{
    [Aero]
    public partial class AreaVisualData_MapMarkerView
    {
        [Flags]
        public enum BitfieldMask1: uint
        {
            MapMarkers_0  = 1U << 0,
            MapMarkers_1  = 1U << 1,
            MapMarkers_2  = 1U << 2,
            MapMarkers_3  = 1U << 3,
            MapMarkers_4  = 1U << 4,
            MapMarkers_5  = 1U << 5,
            MapMarkers_6  = 1U << 6,
            MapMarkers_7  = 1U << 7,
            MapMarkers_8  = 1U << 8,
            MapMarkers_9  = 1U << 9,
            MapMarkers_10 = 1U << 10,
            MapMarkers_11 = 1U << 11,
            MapMarkers_12 = 1U << 12,
            MapMarkers_13 = 1U << 13,
            MapMarkers_14 = 1U << 14,
            MapMarkers_15 = 1U << 15,
            MapMarkers_16 = 1U << 16,
            MapMarkers_17 = 1U << 17,
            MapMarkers_18 = 1U << 18,
            MapMarkers_19 = 1U << 19,
            MapMarkers_20 = 1U << 20,
            MapMarkers_21 = 1U << 21,
            MapMarkers_22 = 1U << 22,
            MapMarkers_23 = 1U << 23,
            MapMarkers_24 = 1U << 24,
            MapMarkers_25 = 1U << 25,
            MapMarkers_26 = 1U << 26,
            MapMarkers_27 = 1U << 27,
            MapMarkers_28 = 1U << 28,
            MapMarkers_29 = 1U << 29,
            MapMarkers_30 = 1U << 30,
            MapMarkers_31 = 1U << 31,
        }

        [Flags]
        public enum BitfieldMask2: byte
        {
            MapMarkers_32  = 1 << 0,
            MapMarkers_33  = 1 << 1,
            MapMarkers_34  = 1 << 2,
        }

        public BitfieldMask1 Bitfield1;
        public BitfieldMask2 Bitfield2;
        public Vector3 Position;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_0)]
        public MapMarkerData MapMarkers_0;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_1)]
        public MapMarkerData MapMarkers_1;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_2)]
        public MapMarkerData MapMarkers_2;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_3)]
        public MapMarkerData MapMarkers_3;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_4)]
        public MapMarkerData MapMarkers_4;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_5)]
        public MapMarkerData MapMarkers_5;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_6)]
        public MapMarkerData MapMarkers_6;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_7)]
        public MapMarkerData MapMarkers_7;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_8)]
        public MapMarkerData MapMarkers_8;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_9)]
        public MapMarkerData MapMarkers_9;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_10)]
        public MapMarkerData MapMarkers_10;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_11)]
        public MapMarkerData MapMarkers_11;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_12)]
        public MapMarkerData MapMarkers_12;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_13)]
        public MapMarkerData MapMarkers_13;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_14)]
        public MapMarkerData MapMarkers_14;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_15)]
        public MapMarkerData MapMarkers_15;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_16)]
        public MapMarkerData MapMarkers_16;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_17)]
        public MapMarkerData MapMarkers_17;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_18)]
        public MapMarkerData MapMarkers_18;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_19)]
        public MapMarkerData MapMarkers_19;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_20)]
        public MapMarkerData MapMarkers_20;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_21)]
        public MapMarkerData MapMarkers_21;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_22)]
        public MapMarkerData MapMarkers_22;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_23)]
        public MapMarkerData MapMarkers_23;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_24)]
        public MapMarkerData MapMarkers_24;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_25)]
        public MapMarkerData MapMarkers_25;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_26)]
        public MapMarkerData MapMarkers_26;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_27)]
        public MapMarkerData MapMarkers_27;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_28)]
        public MapMarkerData MapMarkers_28;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_29)]
        public MapMarkerData MapMarkers_29;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_30)]
        public MapMarkerData MapMarkers_30;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.MapMarkers_31)]
        public MapMarkerData MapMarkers_31;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.MapMarkers_32)]
        public MapMarkerData MapMarkers_32;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.MapMarkers_33)]
        public MapMarkerData MapMarkers_33;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.MapMarkers_34)]
        public MapMarkerData MapMarkers_34;
    }

    [AeroBlock]
    public struct MapMarkerData
    {
        //[AeroSDB("dbencounterdata::MapMarkerInfo", "id")]
        public uint MarkerType;

        [AeroArray(6)]
        public byte[] Unk3;

        public EntityId EncounterId;
        public EntityId EncounterMarkerId; // No controller specified.

        public byte HasDuration;
        [AeroIf(nameof(HasDuration), 1)]
        public uint ExpireAtTime; // Gametime ms

        public HalfVector3 Position;
    }
}