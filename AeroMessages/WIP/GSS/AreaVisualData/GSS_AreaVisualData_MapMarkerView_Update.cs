/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 22
    TypeName: AreaVisualData::MapMarkerView
    MsgId: 1
    MsgName: Update
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.AreaVisualData
{
    [AeroBlock]
    public struct AreaVisualData_MapMarkerView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            Position = 0x00,
            MapMarkers_0 = 0x01,
            MapMarkers_1 = 0x02,
            MapMarkers_2 = 0x03,
            MapMarkers_3 = 0x04,
            MapMarkers_4 = 0x05,
            MapMarkers_5 = 0x06,
            MapMarkers_6 = 0x07,
            MapMarkers_7 = 0x08,
            MapMarkers_8 = 0x09,
            MapMarkers_9 = 0x0a,
            MapMarkers_10 = 0x0b,
            MapMarkers_11 = 0x0c,
            MapMarkers_12 = 0x0d,
            MapMarkers_13 = 0x0e,
            MapMarkers_14 = 0x0f,
            MapMarkers_15 = 0x10,
            MapMarkers_16 = 0x11,
            MapMarkers_17 = 0x12,
            MapMarkers_18 = 0x13,
            MapMarkers_19 = 0x14,
            MapMarkers_20 = 0x15,
            MapMarkers_21 = 0x16,
            MapMarkers_22 = 0x17,
            MapMarkers_23 = 0x18,
            MapMarkers_24 = 0x19,
            MapMarkers_25 = 0x1a,
            MapMarkers_26 = 0x1b,
            MapMarkers_27 = 0x1c,
            MapMarkers_28 = 0x1d,
            MapMarkers_29 = 0x1e,
            MapMarkers_30 = 0x1f,
            MapMarkers_31 = 0x20,
            MapMarkers_32 = 0x21,
            MapMarkers_33 = 0x22,
            MapMarkers_34 = 0x23,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Position)]
        public Vector3 Position;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_0)]
        public MapMarkerData MapMarkers_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_1)]
        public MapMarkerData MapMarkers_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_2)]
        public MapMarkerData MapMarkers_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_3)]
        public MapMarkerData MapMarkers_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_4)]
        public MapMarkerData MapMarkers_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_5)]
        public MapMarkerData MapMarkers_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_6)]
        public MapMarkerData MapMarkers_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_7)]
        public MapMarkerData MapMarkers_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_8)]
        public MapMarkerData MapMarkers_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_9)]
        public MapMarkerData MapMarkers_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_10)]
        public MapMarkerData MapMarkers_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_11)]
        public MapMarkerData MapMarkers_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_12)]
        public MapMarkerData MapMarkers_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_13)]
        public MapMarkerData MapMarkers_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_14)]
        public MapMarkerData MapMarkers_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_15)]
        public MapMarkerData MapMarkers_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_16)]
        public MapMarkerData MapMarkers_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_17)]
        public MapMarkerData MapMarkers_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_18)]
        public MapMarkerData MapMarkers_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_19)]
        public MapMarkerData MapMarkers_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_20)]
        public MapMarkerData MapMarkers_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_21)]
        public MapMarkerData MapMarkers_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_22)]
        public MapMarkerData MapMarkers_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_23)]
        public MapMarkerData MapMarkers_23;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_24)]
        public MapMarkerData MapMarkers_24;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_25)]
        public MapMarkerData MapMarkers_25;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_26)]
        public MapMarkerData MapMarkers_26;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_27)]
        public MapMarkerData MapMarkers_27;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_28)]
        public MapMarkerData MapMarkers_28;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_29)]
        public MapMarkerData MapMarkers_29;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_30)]
        public MapMarkerData MapMarkers_30;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_31)]
        public MapMarkerData MapMarkers_31;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_32)]
        public MapMarkerData MapMarkers_32;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_33)]
        public MapMarkerData MapMarkers_33;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MapMarkers_34)]
        public MapMarkerData MapMarkers_34;
    }

    [Aero]
    public partial class AreaVisualData_MapMarkerView_Update
    {
        [AeroArray(-68)]
        public AreaVisualData_MapMarkerView_ShadowFieldUpdate[] Updates;    
    }
}