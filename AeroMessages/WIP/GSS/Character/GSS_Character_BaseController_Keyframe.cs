/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 4
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
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 4)]
    public partial class Character_BaseController_Keyframe
    {

        [Flags]
        public enum BitfieldMask1 : uint
        {
            CinematicCamera        = 1U << 0,
            PersonalFactionStance  = 1U << 1,
            AttachedTo             = 1U << 2,
            SinFactionsAcquiredBy  = 1U << 3,
            SinTeamsAqquiredBy     = 1U << 4,
            EncounterPartyTuple    = 1U << 5,
            LookAtTarget           = 1U << 6,
            CarryableObjects_0     = 1U << 7,
            CarryableObjects_1     = 1U << 8,
            CarryableObjects_2     = 1U << 9,
            CachedAssets           = 1U << 10,
            RespawnTimes           = 1U << 11,
            ArcStatus              = 1U << 12,
            LeaveZoneTime          = 1U << 13,
            TimedDailyRewardResult = 1U << 14,
            SinCardFields_0        = 1U << 15,
            SinCardFields_1        = 1U << 16,
            SinCardFields_2        = 1U << 17,
            SinCardFields_3        = 1U << 18,
            SinCardFields_4        = 1U << 19,
            SinCardFields_5        = 1U << 20,
            SinCardFields_6        = 1U << 21,
            SinCardFields_7        = 1U << 22,
            SinCardFields_8        = 1U << 23,
            SinCardFields_9        = 1U << 24,
            SinCardFields_10       = 1U << 25,
            SinCardFields_11       = 1U << 26,
            SinCardFields_12       = 1U << 27,
            SinCardFields_13       = 1U << 28,
            SinCardFields_14       = 1U << 29,
            SinCardFields_15       = 1U << 30,
            SinCardFields_16       = 1U << 31,
        }

        [Flags]
        public enum BitfieldMask2 : byte
        {
            SinCardFields_17       = 1 << 0, // << 32,
            SinCardFields_18       = 1 << 1, // << 33,
            SinCardFields_19       = 1 << 2, // << 34,
            SinCardFields_20       = 1 << 3, // << 35,
            SinCardFields_21       = 1 << 4, // << 36,
            SinCardFields_22       = 1 << 5, // << 37,
        }

        public ulong PlayerId; // Controller / Msg4 Specific

        public BitfieldMask1 Bitfield1;
        public BitfieldMask2 Bitfield2;

        // Begin Character_BaseController fields
        
        public uint TimePlayed;
        public uint CurrentWeight;
        public uint EncumberedWeight;
        public AuthorizedTerminalData AuthorizedTerminal;
        public uint PingTime;
        public StaticInfoData StaticInfo;
        public uint SpawnTime;
        public byte VisualOverrides; // TODO: More data if non 0?
        public EquipmentData CurrentEquipment;
        public uint SelectedLoadout;
        public uint SelectedLoadoutIsPvP;
        public GibVisuals GibVisualsId;
        public CharacterSpawnPose SpawnPose;
        public uint ProcessDelay;
        public byte SpectatorMode;

        // TODO: Bitfield1 - Cinematic Camera
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.CinematicCamera)]
        // --

        public CharacterStateData CharacterState; 
        public HostilityInfoData HostilityInfo;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
        
        public uint CurrentHealth;
        public uint CurrentShields;
        public MaxVital MaxHealth;
        public MaxVital MaxShields;
        public byte CurrentDurabilityPct;
        public EnergyParamsData EnergyParams;
        public CharacterStatsData CharacterStats;
        public EmoteData EmoteID;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.AttachedTo)]
        public AttachedToData AttachedTo;

        public byte SnapMount;
        public byte SinFlags;
        public byte SinFlagsPrivate;

        // TODO: Bitfield1 - SinFactionsAcquiredBy
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield1 - SinTeamsAcquiredBy
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        public ulong ArmyGUID;
        public byte ArmyIsOfficer;

        // TODO: Bitfield1 - EncounterPartyTuple
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.EncounterPartyTuple)]
        // --
        
        [AeroArray(21)]
        public byte[] DockedParams;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LookAtTarget)]
        public LookAtTargetData LookAtTarget;

        [AeroArray(8)]
        public byte[] ZoneUnlocks; // Bitfield1

        [AeroArray(8)]
        public byte[] RegionUnlocks; // Bitfield1

        public EntityId ChatPartyLeaderId;

        public ScopeBubbleInfoData ScopeBubbleInfo;

        // TODO: Bitfield1 - CarryableObjects_0
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.CarryableObjects_0)]
        // -
        // TODO: Bitfield1 - CarryableObjects_1
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.CarryableObjects_1)]
        // -
        // TODO: Bitfield1 - CarryableObjects_2 
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.CarryableObjects_2)]
        // -
        // TODO: Bitfield1 - CachedAssets
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.CachedAssets)]
        // -

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.RespawnTimes)]
        public RespawnTimesData RespawnTimes;
     
        [AeroArray(4)]
        public byte[] ProgressionXp; // TODO: Verify, not sure if a single value or several

        public PermanentStatusEffectsData PermanentStatusEffects;
     
        public StatModifierData XpBoostModifier;
        public StatModifierData XpPermanentModifier;
        public StatModifierData XpZoneModifier;
        public StatModifierData XpVipModifier;
        public StatModifierData XpEventModifier;
        public StatModifierData ResourceBoostModifier;
        public StatModifierData ResourcePermanentModifier;
        public StatModifierData ResourceZoneModifier;
        public StatModifierData ResourceVipModifier;
        public StatModifierData ResourceEventModifier;
        public StatModifierData MoneyBoostModifier;
        public StatModifierData MoneyPermanentModifier;
        public StatModifierData MoneyZoneModifier;
        public StatModifierData MoneyVipModifier;
        public StatModifierData MoneyEventModifier;
        public StatModifierData ReputationBoostModifier;
        public StatModifierData ReputationPermanentModifier;
        public StatModifierData ReputationZoneModifier;
        public StatModifierData ReputationVipModifier;
        public StatModifierData ReputationEventModifier;
        public WalletData Wallet;
        public LoyaltyData Loyalty;
        public byte Level;
        public byte EffectiveLevel;
        public byte LevelResetCount;
        public byte OldestDeployables; // TODO: Verify, probably an array
        public uint PerkRespecs;

        // TODO: Bitfield1 - ArcStatus  = 0x4c,
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ArcStatus)]
        // --
        // TODO: Bitfield1 - LeaveZoneTime  = 0x4d,
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.LeaveZoneTime)]
        // public uint LeaveZoneTime; // TOOD: Verify
        // --
        
        public byte ChatMuteStatus; // TODO: Verify
        public ulong TimedDailyReward;

        // TODO: Bitfield1 -  TimedDailyRewardResult      = 0x50,
        // [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.TimedDailyRewardResult)]
        // --

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_20)]
        public SinCardFieldData SinCardFields_20;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_21)]
        public SinCardFieldData SinCardFields_21;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.SinCardFields_22)]
        public SinCardFieldData SinCardFields_22;

        public byte AssetOverrides; // TODO: Verify, probably an array 

        public ushort FriendCount;

        public CAISStatusData CAISStatus;

        public uint ScalingLevel;
        public uint PvPRank;
        public uint PvPRankPoints;
        public uint PvPTokens;
        public uint BountyPointsLastClaimed;
        public uint EliteLevel;  
    }

    [AeroBlock]
    public struct AuthorizedTerminalData
    {
        public byte TerminalType;
        public uint TerminalId;
        public ulong TerminalEntityId;
    }

    [AeroBlock]
    public struct CharacterSpawnPose
    {
        public uint Time;
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 AimDirection;
        public Vector3 Velocity;
        public ushort MovementState;
        public ushort Unk; // ???
        public ushort JetpackEnergy;
        public short AirGroundTimer;
        public short JumpTimer;
        public byte UnkLast;
    }

    [AeroBlock]
    public struct EnergyParamsData
    {
        public float Max;
        public uint Delay;
        public float Recharge;
        public uint Time;
    }

    [AeroBlock]
    public struct PermanentStatusEffectsData
    {
        // TODO: Verify
        [AeroArray(typeof(byte))]
        public PermanentStatusEffectsInnerData[] Effects;
    }

    [AeroBlock]
    public struct PermanentStatusEffectsInnerData
    {
        // TODO: Verify
        public uint Id;

        [AeroArray(12)]
        public byte[] Unk;
    }


    [AeroBlock]
    public struct StatModifierData
    {
        [AeroSdb("aptfs::StatModifierCommandDef", "id")] // TODO: Verify
        public uint ModifierId;
        public float StatValue;
    }

    [AeroBlock]
    public struct WalletData
    {
        public uint Beans;
        public uint Epoch;
    }

    [AeroBlock]
    public struct LoyaltyData
    {
        public uint Current;
        public uint Lifetime;
        public uint Tier;
    }

    [AeroBlock]
    public struct CAISStatusData
    {
        // TODO: Verify states
        public enum CAISState: byte
        {
            None = 0,
            Healthy = 1,
            Fatigued = 2,
            Unhealthy = 3,
        }

        public CAISState State;
        public uint Elapsed;
    } 
}