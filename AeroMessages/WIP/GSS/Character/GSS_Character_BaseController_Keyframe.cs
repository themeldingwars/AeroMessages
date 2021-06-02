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
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_BaseController_Keyframe
    {
        [Flags]
        public enum BitfieldMask : ulong
        {
            CinematicCamera        = 1UL << 0,
            PersonalFactionStance  = 1UL << 1,
            AttachedTo             = 1UL << 2,
            SinFactionsAcquiredBy  = 1UL << 3,
            SinTeamsAqquiredBy     = 1UL << 4,
            EncounterPartyTuple    = 1UL << 5,
            LookAtTarget           = 1UL << 6,
            CarryableObjects_0     = 1UL << 7,
            CarryableObjects_1     = 1UL << 8,
            CarryableObjects_2     = 1UL << 9,
            CachedAssets           = 1UL << 10,
            RespawnTimes           = 1UL << 11,
            ArcStatus              = 1UL << 12,
            LeaveZoneTime          = 1UL << 13,
            TimedDailyRewardResult = 1UL << 14,
            SinCardFields_0        = 1UL << 15,
            SinCardFields_1        = 1UL << 16,
            SinCardFields_2        = 1UL << 17,
            SinCardFields_3        = 1UL << 18,
            SinCardFields_4        = 1UL << 19,
            SinCardFields_5        = 1UL << 20,
            SinCardFields_6        = 1UL << 21,
            SinCardFields_7        = 1UL << 22,
            SinCardFields_8        = 1UL << 23,
            SinCardFields_9        = 1UL << 24,
            SinCardFields_10       = 1UL << 25,
            SinCardFields_11       = 1UL << 26,
            SinCardFields_12       = 1UL << 27,
            SinCardFields_13       = 1UL << 28,
            SinCardFields_14       = 1UL << 29,
            SinCardFields_15       = 1UL << 30,
            SinCardFields_16       = 1UL << 31,
            SinCardFields_17       = 1UL << 32,
            SinCardFields_18       = 1UL << 33,
            SinCardFields_19       = 1UL << 34,
            SinCardFields_20       = 1UL << 35,
            SinCardFields_21       = 1UL << 36,
            SinCardFields_22       = 1UL << 37,
        }

        public ulong PlayerId; // Controller / Msg4 Specific

        //[AeroArray(5)]
        public Ulong5ByteBitmask<BitfieldMask> Bitfield; // Keyframe bitfield

        // Begin Character_BaseController fields
        
        public uint TimePlayed;
        public byte CurrentWeight;
        public byte EncumberedWeight;
        public AuthorizedTerminalData AuthorizedTerminal;
        public uint PingTime;
        public StaticInfoData StaticInfo;
        public uint SpawnTime;
        public byte VisualOverrides; // TODO: More data if non 0?
        public EquipmentData CurrentEquipment;
        public uint SelectedLoadout;
        public uint SelectedLoadoutIsPvP;
        public GibVisuals GibVusalsId;
        public CharacterSpawnPose SpawnPose;
        public uint ProcessDelay;
        public byte SpectatorMode;

        // TODO: Bitfield - Cinematic Camera
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CinematicCamera)]
        // --

        public CharacterStateData CharacterState; 
        public HostilityInfoData HosilityInfo;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
        
        public uint CurrentHealth;
        public uint CurrentShields;
        public MaxVital MaxHealth;
        public MaxVital MaxShields;
        public byte CurrentDurabilityPct;
        public EnergyParamsData EnergyParams;
        public CharacterStatsData CharacterStats;
        public EmoteData EmoteId;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.AttachedTo)]
        public AttachedToData AttachedTo;

        public byte SnapMount;
        public byte SinFlags;
        public byte SinFlagsPrivate;

        // TODO: Bitfield - SinFactionsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        public ulong ArmyGUID;
        public byte ArmyIsOfficer;

        // TODO: Bitfield - EncounterPartyTuple
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.EncounterPartyTuple)]
        // --
        
        [AeroArray(21)]
        public byte[] DockedParams;

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.LookAtTarget)]
        public LookAtTargetData LookAtTarget;

        [AeroArray(8)]
        public byte[] ZoneUnlocks; // Bitfield

        [AeroArray(8)]
        public byte[] RegionUnlocks; // Bitfield

        public EntityId ChatPartyLeaderId;

        public ScopeBubbleInfoData ScopeBubbleInfo;

        // TODO: Bitfield - CarryableObjects_0
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_0)]
        // -
        // TODO: Bitfield - CarryableObjects_1
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_1)]
        // -
        // TODO: Bitfield - CarryableObjects_2 
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_2)]
        // -
        // TODO: Bitfield - CachedAssets
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.CachedAssets)]
        // -

        [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.RespawnTimes)]
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

        // TODO: Bitfield - ArcStatus  = 0x4c,
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.ArcStatus)]
        // --
        // TODO: Bitfield - LeaveZoneTime  = 0x4d,
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.LeaveZoneTime)]
        // public uint LeaveZoneTime; // TOOD: Verify
        // --
        
        public byte ChatMuteStatus; // TODO: Verify
        public ulong TimedDailyReward;

        // TODO: Bitfield -  TimedDailyRewardResult      = 0x50,
        // [AeroIf(nameof(Bitfield), Ops.DoesntHaveFlag, BitfieldMask.TimedDailyRewardResult)]
        // --

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

        public byte AssetOverrides; // TODO: Verify, probably an array 

        public byte FriendCount;

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