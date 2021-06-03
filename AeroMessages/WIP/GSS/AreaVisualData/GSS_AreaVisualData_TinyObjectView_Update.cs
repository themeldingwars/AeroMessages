/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 23
    TypeName: AreaVisualData::TinyObjectView
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
    public struct AreaVisualData_TinyObjectView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            TinyObjects_0 = 0x00,
            TinyObjects_1 = 0x01,
            TinyObjects_2 = 0x02,
            TinyObjects_3 = 0x03,
            TinyObjects_4 = 0x04,
            TinyObjects_5 = 0x05,
            TinyObjects_6 = 0x06,
            TinyObjects_7 = 0x07,
            TinyObjects_8 = 0x08,
            TinyObjects_9 = 0x09,
            TinyObjects_10 = 0x0a,
            TinyObjects_11 = 0x0b,
            TinyObjects_12 = 0x0c,
            TinyObjects_13 = 0x0d,
            TinyObjects_14 = 0x0e,
            TinyObjects_15 = 0x0f,
            TinyObjects_16 = 0x10,
            TinyObjects_17 = 0x11,
            TinyObjects_18 = 0x12,
            TinyObjects_19 = 0x13,
            TinyObjects_20 = 0x14,
            TinyObjects_21 = 0x15,
            TinyObjects_22 = 0x16,
            TinyObjects_23 = 0x17,
            TinyObjects_24 = 0x18,
            TinyObjects_25 = 0x19,
            TinyObjects_26 = 0x1a,
            TinyObjects_27 = 0x1b,
            TinyObjects_28 = 0x1c,
            TinyObjects_29 = 0x1d,
            TinyObjects_30 = 0x1e,
            TinyObjects_31 = 0x1f,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_0)]
        public TinyObjectData TinyObjects_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_1)]
        public TinyObjectData TinyObjects_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_2)]
        public TinyObjectData TinyObjects_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_3)]
        public TinyObjectData TinyObjects_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_4)]
        public TinyObjectData TinyObjects_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_5)]
        public TinyObjectData TinyObjects_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_6)]
        public TinyObjectData TinyObjects_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_7)]
        public TinyObjectData TinyObjects_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_8)]
        public TinyObjectData TinyObjects_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_9)]
        public TinyObjectData TinyObjects_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_10)]
        public TinyObjectData TinyObjects_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_11)]
        public TinyObjectData TinyObjects_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_12)]
        public TinyObjectData TinyObjects_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_13)]
        public TinyObjectData TinyObjects_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_14)]
        public TinyObjectData TinyObjects_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_15)]
        public TinyObjectData TinyObjects_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_16)]
        public TinyObjectData TinyObjects_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_17)]
        public TinyObjectData TinyObjects_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_18)]
        public TinyObjectData TinyObjects_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_19)]
        public TinyObjectData TinyObjects_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_20)]
        public TinyObjectData TinyObjects_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_21)]
        public TinyObjectData TinyObjects_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_22)]
        public TinyObjectData TinyObjects_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_23)]
        public TinyObjectData TinyObjects_23;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_24)]
        public TinyObjectData TinyObjects_24;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_25)]
        public TinyObjectData TinyObjects_25;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_26)]
        public TinyObjectData TinyObjects_26;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_27)]
        public TinyObjectData TinyObjects_27;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_28)]
        public TinyObjectData TinyObjects_28;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_29)]
        public TinyObjectData TinyObjects_29;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_30)]
        public TinyObjectData TinyObjects_30;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TinyObjects_31)]
        public TinyObjectData TinyObjects_31;
    }

    [Aero]
    public partial class AreaVisualData_TinyObjectView_Update
    {
        [AeroArray(-64)]
        public AreaVisualData_TinyObjectView_ShadowFieldUpdate[] Updates;    
    }
}