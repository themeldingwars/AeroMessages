using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Deployable
{
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 35, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 35, 3)]
    public partial class Deployable_ObserverView
    {
        [AeroSdb("dbcharacter::Deployable", "id")]
        private uint Type;
        private EntityId OwningEntity;
        [AeroSdb("apt::AbilityData", "id")]
        private uint AbilitySrcId; // example in msgidx 123396
        private Vector3 Position;
        private Quaternion Orientation; // Rotation
        private Vector3 AimPosition;
        private Vector3 AimDirection;
        private uint ConstructedTime;
        private byte CurrentHealthPct;
        private int MaxHealth;
        private byte Level;

        private ushort StatusEffectsChangeTime_0;
        private ushort StatusEffectsChangeTime_1;
        private ushort StatusEffectsChangeTime_2;
        private ushort StatusEffectsChangeTime_3;
        private ushort StatusEffectsChangeTime_4;
        private ushort StatusEffectsChangeTime_5;
        private ushort StatusEffectsChangeTime_6;
        private ushort StatusEffectsChangeTime_7;
        private ushort StatusEffectsChangeTime_8;
        private ushort StatusEffectsChangeTime_9;
        private ushort StatusEffectsChangeTime_10;
        private ushort StatusEffectsChangeTime_11;
        private ushort StatusEffectsChangeTime_12;
        private ushort StatusEffectsChangeTime_13;
        private ushort StatusEffectsChangeTime_14;
        private ushort StatusEffectsChangeTime_15;
        private ushort StatusEffectsChangeTime_16;
        private ushort StatusEffectsChangeTime_17;
        private ushort StatusEffectsChangeTime_18;
        private ushort StatusEffectsChangeTime_19;
        private ushort StatusEffectsChangeTime_20;
        private ushort StatusEffectsChangeTime_21;
        private ushort StatusEffectsChangeTime_22;
        private ushort StatusEffectsChangeTime_23;
        private ushort StatusEffectsChangeTime_24;
        private ushort StatusEffectsChangeTime_25;
        private ushort StatusEffectsChangeTime_26;
        private ushort StatusEffectsChangeTime_27;
        private ushort StatusEffectsChangeTime_28;
        private ushort StatusEffectsChangeTime_29;
        private ushort StatusEffectsChangeTime_30;
        private ushort StatusEffectsChangeTime_31;

        [AeroNullable] private StatusEffectData StatusEffects_0;
        [AeroNullable] private StatusEffectData StatusEffects_1;
        [AeroNullable] private StatusEffectData StatusEffects_2;
        [AeroNullable] private StatusEffectData StatusEffects_3;
        [AeroNullable] private StatusEffectData StatusEffects_4;
        [AeroNullable] private StatusEffectData StatusEffects_5;
        [AeroNullable] private StatusEffectData StatusEffects_6;
        [AeroNullable] private StatusEffectData StatusEffects_7;
        [AeroNullable] private StatusEffectData StatusEffects_8;
        [AeroNullable] private StatusEffectData StatusEffects_9;
        [AeroNullable] private StatusEffectData StatusEffects_10;
        [AeroNullable] private StatusEffectData StatusEffects_11;
        [AeroNullable] private StatusEffectData StatusEffects_12;
        [AeroNullable] private StatusEffectData StatusEffects_13;
        [AeroNullable] private StatusEffectData StatusEffects_14;
        [AeroNullable] private StatusEffectData StatusEffects_15;
        [AeroNullable] private StatusEffectData StatusEffects_16;
        [AeroNullable] private StatusEffectData StatusEffects_17;
        [AeroNullable] private StatusEffectData StatusEffects_18;
        [AeroNullable] private StatusEffectData StatusEffects_19;
        [AeroNullable] private StatusEffectData StatusEffects_20;
        [AeroNullable] private StatusEffectData StatusEffects_21;
        [AeroNullable] private StatusEffectData StatusEffects_22;
        [AeroNullable] private StatusEffectData StatusEffects_23;
        [AeroNullable] private StatusEffectData StatusEffects_24;
        [AeroNullable] private StatusEffectData StatusEffects_25;
        [AeroNullable] private StatusEffectData StatusEffects_26;
        [AeroNullable] private StatusEffectData StatusEffects_27;
        [AeroNullable] private StatusEffectData StatusEffects_28;
        [AeroNullable] private StatusEffectData StatusEffects_29;
        [AeroNullable] private StatusEffectData StatusEffects_30;
        [AeroNullable] private StatusEffectData StatusEffects_31;

        private HostilityInfoData HostilityInfo;

        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;

        private uint GibVisualsID;

        [AeroNullable] private ForcedMovementData ForcedMovementData;

        private byte SinFlags;

        [AeroNullable] private SinFactionsAcquiredByData SinFactionsAcquiredBy;
        [AeroNullable] private SinTeamsAcquiredByData SinTeamsAcquiredBy;


        private EntityId AttachedTo;

        [AeroArray(typeof(byte))]
        private ushort[] WarpaintColors;

        private byte VisualInfoGroupIndex; // TODO: Verify 

        private CharacterStatsData CharacterStats;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        private uint SinCardType;

        [AeroNullable] private SinCardFieldData SinCardFields_0;

        [AeroNullable] private SinCardFieldData SinCardFields_1;

        [AeroNullable] private SinCardFieldData SinCardFields_2;

        [AeroNullable] private SinCardFieldData SinCardFields_3;

        [AeroNullable] private SinCardFieldData SinCardFields_4;

        [AeroNullable] private SinCardFieldData SinCardFields_5;

        [AeroNullable] private SinCardFieldData SinCardFields_6;

        [AeroNullable] private SinCardFieldData SinCardFields_7;

        [AeroNullable] private SinCardFieldData SinCardFields_8;

        [AeroNullable] private SinCardFieldData SinCardFields_9;

        [AeroNullable] private SinCardFieldData SinCardFields_10;

        [AeroNullable] private SinCardFieldData SinCardFields_11;

        [AeroNullable] private SinCardFieldData SinCardFields_12;

        [AeroNullable] private SinCardFieldData SinCardFields_13;

        [AeroNullable] private SinCardFieldData SinCardFields_14;

        [AeroNullable] private SinCardFieldData SinCardFields_15;

        [AeroNullable] private SinCardFieldData SinCardFields_16;

        [AeroNullable] private SinCardFieldData SinCardFields_17;

        [AeroNullable] private SinCardFieldData SinCardFields_18;

        [AeroNullable] private SinCardFieldData SinCardFields_19;

        private uint ScalingLevel;

        // TODO: Bitfield - AppendageHealthPools
        [AeroNullable] private byte AppendageHealthPools_0;
        [AeroNullable] private byte AppendageHealthPools_1;
        [AeroNullable] private byte AppendageHealthPools_2;
        [AeroNullable] private byte AppendageHealthPools_3;
        [AeroNullable] private byte AppendageHealthPools_4;
        [AeroNullable] private byte AppendageHealthPools_5;
        [AeroNullable] private byte AppendageHealthPools_6;
        [AeroNullable] private byte AppendageHealthPools_7;     
        
        private byte AppendageHealthPct_0;
        private byte AppendageHealthPct_1;
        private byte AppendageHealthPct_2;
        private byte AppendageHealthPct_3;
        private byte AppendageHealthPct_4;
        private byte AppendageHealthPct_5;
        private byte AppendageHealthPct_6;
        private byte AppendageHealthPct_7;
    }


    [AeroBlock]
    public struct ForcedMovementData
    {
        public byte Flags;

        [AeroArray(5)]
        public byte[] Unk2;

        [AeroIf(nameof(Flags), 0x01)]
        [AeroArray(30)]
        public byte[] Data1;

        [AeroIf(nameof(Flags), 0x03)]
        [AeroArray(74)]
        public byte[] Data3;

        [AeroIf(nameof(Flags), 0x05)]
        [AeroArray(5)]
        public byte[] Data5;

        [AeroIf(nameof(Flags), 0x09)]
        [AeroArray(24)]
        public byte[] Data9; // 2x uint (time), 4x float

        [AeroIf(nameof(Flags), Ops.NotEqual, 0x01)]
        [AeroIf(nameof(Flags), Ops.NotEqual, 0x03)]
        [AeroIf(nameof(Flags), Ops.NotEqual, 0x05)]
        [AeroIf(nameof(Flags), Ops.NotEqual, 0x09)]
        public byte FIXME_UNKNOWN_FLAGS;
    }
}