/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 25
    TypeName: AreaVisualData::ForceShieldView
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
    [AeroBlock]
    public struct AreaVisualData_ForceShieldView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            Position = 0x00,
            ForceShields_0  = 0x01,
            ForceShields_1  = 0x02,
            ForceShields_2  = 0x03,
            ForceShields_3  = 0x04,
            ForceShields_4  = 0x05,
            ForceShields_5  = 0x06,
            ForceShields_6  = 0x07,
            ForceShields_7  = 0x08,
            ForceShields_8  = 0x09,
            ForceShields_9  = 0x0a,
            ForceShields_10 = 0x0b,
            ForceShields_11 = 0x0c,
            ForceShields_12 = 0x0d,
            ForceShields_13 = 0x0e,
            ForceShields_14 = 0x0f,
            ForceShields_15 = 0x10,
            ForceShields_16 = 0x11,
            ForceShields_17 = 0x12,
            ForceShields_18 = 0x13,
            ForceShields_19 = 0x14,
            ForceShields_20 = 0x15,
            ForceShields_21 = 0x16,
            ForceShields_22 = 0x17,
            ForceShields_23 = 0x18,
            ForceShields_24 = 0x19,
            ForceShields_25 = 0x1a,
            ForceShields_26 = 0x1b,
            ForceShields_27 = 0x1c,
            ForceShields_28 = 0x1d,
            ForceShields_29 = 0x1e,
            ForceShields_30 = 0x1f,
            ForceShields_31 = 0x20,
            ScopeBubbleInfo = 0x21,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Position)]
        public Vector3 Position;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_0)]
        public ForceShieldData ForceShields_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_1)]
        public ForceShieldData ForceShields_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_2)]
        public ForceShieldData ForceShields_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_3)]
        public ForceShieldData ForceShields_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_4)]
        public ForceShieldData ForceShields_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_5)]
        public ForceShieldData ForceShields_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_6)]
        public ForceShieldData ForceShields_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_7)]
        public ForceShieldData ForceShields_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_8)]
        public ForceShieldData ForceShields_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_9)]
        public ForceShieldData ForceShields_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_10)]
        public ForceShieldData ForceShields_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_11)]
        public ForceShieldData ForceShields_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_12)]
        public ForceShieldData ForceShields_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_13)]
        public ForceShieldData ForceShields_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_14)]
        public ForceShieldData ForceShields_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_15)]
        public ForceShieldData ForceShields_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_16)]
        public ForceShieldData ForceShields_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_17)]
        public ForceShieldData ForceShields_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_18)]
        public ForceShieldData ForceShields_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_19)]
        public ForceShieldData ForceShields_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_20)]
        public ForceShieldData ForceShields_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_21)]
        public ForceShieldData ForceShields_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_22)]
        public ForceShieldData ForceShields_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_23)]
        public ForceShieldData ForceShields_23;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_24)]
        public ForceShieldData ForceShields_24;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_25)]
        public ForceShieldData ForceShields_25;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_26)]
        public ForceShieldData ForceShields_26;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_27)]
        public ForceShieldData ForceShields_27;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_28)]
        public ForceShieldData ForceShields_28;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_29)]
        public ForceShieldData ForceShields_29;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_30)]
        public ForceShieldData ForceShields_30;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ForceShields_31)]
        public ForceShieldData ForceShields_31;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [Aero]
    public partial class AreaVisualData_ForceShieldView_Update
    {
        [AeroArray(-66)]
        public AreaVisualData_ForceShieldView_ShadowFieldUpdate[] Updates;    
    }
}