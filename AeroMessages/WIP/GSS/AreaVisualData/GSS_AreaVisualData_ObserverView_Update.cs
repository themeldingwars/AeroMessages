/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 20
    TypeName: AreaVisualData::ObserverView
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
    public struct AreaVisualData_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            Position        = 0x00,
            ScopeBubbleInfo = 0x01,
            ContextFlags_0  = 0x02,
            ContextFlags_1  = 0x03,
            ContextFlags_2  = 0x04,
            ContextFlags_3  = 0x05,
            ContextFlags_4  = 0x06,
            ContextFlags_5  = 0x07,
            ContextFlags_6  = 0x08,
            ContextFlags_7  = 0x09,
            ContextFlags_8  = 0x0a,
            ContextFlags_9  = 0x0b,
            ContextFlags_10 = 0x0c,
            ContextFlags_11 = 0x0d,
            ContextFlags_12 = 0x0e,
            ContextFlags_13 = 0x0f,
            ContextFlags_14 = 0x10,
            ContextFlags_15 = 0x11,
            ContextFlags_16 = 0x12,
            ContextFlags_17 = 0x13,
            ContextFlags_18 = 0x14,
            ContextFlags_19 = 0x15,
            ContextFlags_20 = 0x16,
            ContextFlags_21 = 0x17,
            ContextFlags_22 = 0x18,
            ContextFlags_23 = 0x19,
            ContextTeams_0  = 0x1a,
            ContextTeams_1  = 0x1b,
            ContextTeams_2  = 0x1c,
            ContextTeams_3  = 0x1d,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Position)]
        public Vector3 Position;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_0)]
        public ContextFlag ContextFlags_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_1)]
        public ContextFlag ContextFlags_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_2)]
        public ContextFlag ContextFlags_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_3)]
        public ContextFlag ContextFlags_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_4)]
        public ContextFlag ContextFlags_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_5)]
        public ContextFlag ContextFlags_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_6)]
        public ContextFlag ContextFlags_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_7)]
        public ContextFlag ContextFlags_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_8)]
        public ContextFlag ContextFlags_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_9)]
        public ContextFlag ContextFlags_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_10)]
        public ContextFlag ContextFlags_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_11)]
        public ContextFlag ContextFlags_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_12)]
        public ContextFlag ContextFlags_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_13)]
        public ContextFlag ContextFlags_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_14)]
        public ContextFlag ContextFlags_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_15)]
        public ContextFlag ContextFlags_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_16)]
        public ContextFlag ContextFlags_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_17)]
        public ContextFlag ContextFlags_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_18)]
        public ContextFlag ContextFlags_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_19)]
        public ContextFlag ContextFlags_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_20)]
        public ContextFlag ContextFlags_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_21)]
        public ContextFlag ContextFlags_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_22)]
        public ContextFlag ContextFlags_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextFlags_23)]
        public ContextFlag ContextFlags_23;
        // TODO: ContextTeams
        /*
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextTeams_0)]
        public ContextTeam ContextTeams_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextTeams_1)]
        public ContextTeam ContextTeams_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextTeams_2)]
        public ContextTeam ContextTeams_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ContextTeams_3)]
        public ContextTeam ContextTeams_3;
        */
    }

    //[Aero]
    //[AeroMessageId(MsgType.GSS, MsgSrc.Message, 20, 1)]
    public partial class AreaVisualData_ObserverView_Update
    {
        [AeroArray(-60)]
        public AreaVisualData_ObserverView_ShadowFieldUpdate[] Updates;    
    }
}