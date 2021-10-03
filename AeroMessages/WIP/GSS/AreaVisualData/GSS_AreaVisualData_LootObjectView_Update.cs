/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 24
    TypeName: AreaVisualData::LootObjectView
    MsgId: 1
    MsgName: Update
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.AreaVisualData
{
    [AeroBlock]
    public struct AreaVisualData_LootObjectView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            LootObjects_0 = 0x00,
            LootObjects_1 = 0x01,
            LootObjects_2 = 0x02,
            LootObjects_3 = 0x03,
            LootObjects_4 = 0x04,
            LootObjects_5 = 0x05,
            LootObjects_6 = 0x06,
            LootObjects_7 = 0x07,
            LootObjects_8 = 0x08,
            LootObjects_9 = 0x09,
            LootObjects_10 = 0x0a,
            LootObjects_11 = 0x0b,
            LootObjects_12 = 0x0c,
            LootObjects_13 = 0x0d,
            LootObjects_14 = 0x0e,
            LootObjects_15 = 0x0f,
            LootObjects_16 = 0x10,
            LootObjects_17 = 0x11,
            LootObjects_18 = 0x12,
            LootObjects_19 = 0x13,
            LootObjects_20 = 0x14,
            LootObjects_21 = 0x15,
            LootObjects_22 = 0x16,
            LootObjects_23 = 0x17,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_0)]
        public LootObjectData LootObjects_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_1)]
        public LootObjectData LootObjects_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_2)]
        public LootObjectData LootObjects_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_3)]
        public LootObjectData LootObjects_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_4)]
        public LootObjectData LootObjects_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_5)]
        public LootObjectData LootObjects_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_6)]
        public LootObjectData LootObjects_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_7)]
        public LootObjectData LootObjects_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_8)]
        public LootObjectData LootObjects_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_9)]
        public LootObjectData LootObjects_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_10)]
        public LootObjectData LootObjects_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_11)]
        public LootObjectData LootObjects_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_12)]
        public LootObjectData LootObjects_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_13)]
        public LootObjectData LootObjects_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_14)]
        public LootObjectData LootObjects_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_15)]
        public LootObjectData LootObjects_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_16)]
        public LootObjectData LootObjects_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_17)]
        public LootObjectData LootObjects_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_18)]
        public LootObjectData LootObjects_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_19)]
        public LootObjectData LootObjects_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_20)]
        public LootObjectData LootObjects_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_21)]
        public LootObjectData LootObjects_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_22)]
        public LootObjectData LootObjects_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LootObjects_23)]
        public LootObjectData LootObjects_23;
    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 24, 1)]
    public partial class AreaVisualData_LootObjectView_Update
    {
        [AeroArray(-48)]
        public AreaVisualData_LootObjectView_ShadowFieldUpdate[] Updates;    
    }
}