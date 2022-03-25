using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System;
using System.Numerics;
namespace AeroMessages.GSS.AreaVisualData
{
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 25, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 25, 3)]
    public partial class AreaVisualData_ForceShieldView
    {
        private Vector3 Position;

        [AeroNullable] private ForceShieldData ForceShields_0;
        [AeroNullable] private ForceShieldData ForceShields_1;
        [AeroNullable] private ForceShieldData ForceShields_2;
        [AeroNullable] private ForceShieldData ForceShields_3;
        [AeroNullable] private ForceShieldData ForceShields_4;
        [AeroNullable] private ForceShieldData ForceShields_5;
        [AeroNullable] private ForceShieldData ForceShields_6;
        [AeroNullable] private ForceShieldData ForceShields_7;
        [AeroNullable] private ForceShieldData ForceShields_8;
        [AeroNullable] private ForceShieldData ForceShields_9;
        [AeroNullable] private ForceShieldData ForceShields_10;
        [AeroNullable] private ForceShieldData ForceShields_11;
        [AeroNullable] private ForceShieldData ForceShields_12;
        [AeroNullable] private ForceShieldData ForceShields_13;
        [AeroNullable] private ForceShieldData ForceShields_14;
        [AeroNullable] private ForceShieldData ForceShields_15;
        [AeroNullable] private ForceShieldData ForceShields_16;
        [AeroNullable] private ForceShieldData ForceShields_17;
        [AeroNullable] private ForceShieldData ForceShields_18;
        [AeroNullable] private ForceShieldData ForceShields_19;
        [AeroNullable] private ForceShieldData ForceShields_20;
        [AeroNullable] private ForceShieldData ForceShields_21;
        [AeroNullable] private ForceShieldData ForceShields_22;
        [AeroNullable] private ForceShieldData ForceShields_23;
        [AeroNullable] private ForceShieldData ForceShields_24;
        [AeroNullable] private ForceShieldData ForceShields_25;
        [AeroNullable] private ForceShieldData ForceShields_26;
        [AeroNullable] private ForceShieldData ForceShields_27;
        [AeroNullable] private ForceShieldData ForceShields_28;
        [AeroNullable] private ForceShieldData ForceShields_29;
        [AeroNullable] private ForceShieldData ForceShields_30;
        [AeroNullable] private ForceShieldData ForceShields_31;

        private ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct ForceShieldData
    {
        // TODO: Need to verify
        [AeroSdb("dbzonemetadata::ForceShieldType", "id")]
        public uint MaybeType;
        
        public HalfVector3 Position;
        
        public HalfVector4 Orientation;
        
        public HalfVector3 Direction;

        public byte Unk2;
        public HostilityInfoData HostilityInfo;
    }
}