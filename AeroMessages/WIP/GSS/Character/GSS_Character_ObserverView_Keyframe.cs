/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 8
    TypeName: Character::ObserverView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 3)]
    public partial class Character_ObserverView_Keyframe
    {
        [Flags]
        public enum BitfieldMask : uint
        {
            PersonalFactionStance  = 1U << 0,
            AttachedTo             = 1U << 1,
            SinFactionsAcquiredBy  = 1U << 2,
            SinTeamsAcquiredBy     = 1U << 3,
            LookAtTarget           = 1U << 4,
            CarryableObjects_0     = 1U << 5,
            CarryableObjects_1     = 1U << 6,
            CarryableObjects_2     = 1U << 7,
            RespawnTimes           = 1U << 8,
            SinCardFields_0        = 1U << 9,
            SinCardFields_1        = 1U << 10,
            SinCardFields_2        = 1U << 11,
            SinCardFields_3        = 1U << 12,
            SinCardFields_4        = 1U << 13,
            SinCardFields_5        = 1U << 14,
            SinCardFields_6        = 1U << 15,
            SinCardFields_7        = 1U << 16,
            SinCardFields_8        = 1U << 17,
            SinCardFields_9        = 1U << 18,
            SinCardFields_10       = 1U << 19,
            SinCardFields_11       = 1U << 20,
            SinCardFields_12       = 1U << 21,
            SinCardFields_13       = 1U << 22,
            SinCardFields_14       = 1U << 23,
            SinCardFields_15       = 1U << 24,
            SinCardFields_16       = 1U << 25,
            SinCardFields_17       = 1U << 26,
            SinCardFields_18       = 1U << 27,
            SinCardFields_19       = 1U << 28,
            SinCardFields_20       = 1U << 29,
            SinCardFields_21       = 1U << 30,
            SinCardFields_22       = 1U << 31,
        }

        public BitfieldMask Bitfield;

        public StaticInfoData StaticInfo;

        public uint SpawnTime;
        public byte EffectsFlags;
        public GibVisuals GibVisualsId;
        public uint ProcessDelay;
        public CharacterStateData CharacterState; 
        public HostilityInfoData HostilityInfo;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;

        public byte CurrentHealthPct;
        public MaxVital MaxHealth;
        public EmoteData EmoteId;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AttachedTo)]
        public AttachedToData AttachedTo;

        public byte SnapMount;
        public byte SinFlags;

        // TODO: Bitfield - SinFactionsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        public ulong ArmyGUID;
        public ulong OwnerId;
        public uint NPCType;

        [AeroArray(21)]
        public byte[] DockedParams;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.LookAtTarget)]
        public LookAtTargetData LookAtTarget;


        public byte WaterLevelAndDesc;

        // TODO: Bitfield - CarryableObjects_0
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_0)]
        // -
        // TODO: Bitfield - CarryableObjects_1
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_1)]
        // -
        // TODO: Bitfield - CarryableObjects_2 
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_2)]

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.RespawnTimes)]
        public RespawnTimesData RespawnTimes;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_20)]
        public SinCardFieldData SinCardFields_20;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_21)]
        public SinCardFieldData SinCardFields_21;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_22)]
        public SinCardFieldData SinCardFields_22;

        public byte AssetOverrides;
    }
}