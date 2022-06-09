using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.Character
{
    [Aero(AeroGenTypes.Controller)]
    //[AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 1)]
    //[AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 4)]
    public partial class Character_BaseController
    {   
        private uint TimePlayed;
        private uint CurrentWeight;
        private uint EncumberedWeight;
        private AuthorizedTerminalData AuthorizedTerminal;
        private uint PingTime;
        private StaticInfoData StaticInfo;
        private uint SpawnTime;
        private byte VisualOverrides; // TODO: More data if non 0?
        private EquipmentData CurrentEquipment;
        private uint SelectedLoadout;
        private uint SelectedLoadoutIsPvP;
        private GibVisuals GibVisualsId;
        private CharacterSpawnPose SpawnPose;
        private uint ProcessDelay;
        private byte SpectatorMode;

        [AeroNullable] private CinematicCameraData CinematicCamera;

        private CharacterStateData CharacterState; 
        private HostilityInfoData HostilityInfo;

        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;

        private uint CurrentHealth;
        private uint CurrentShields;
        private MaxVital MaxHealth;
        private MaxVital MaxShields;
        private byte CurrentDurabilityPct;
        private EnergyParamsData EnergyParams;
        private CharacterStatsData CharacterStats;
        private EmoteData EmoteID;

        [AeroNullable] private AttachedToData AttachedTo;

        private byte SnapMount;
        private byte SinFlags;
        private byte SinFlagsPrivate;

        [AeroNullable] private SinFactionsAcquiredByData SinFactionsAcquiredBy;
        [AeroNullable] private SinTeamsAcquiredByData SinTeamsAcquiredBy;

        private ulong ArmyGUID;
        private byte ArmyIsOfficer;

        [AeroNullable] private EncounterPartyTupleData EncounterPartyTuple;

        private DockedParamsData DockedParams;

        [AeroNullable] private LookAtTargetData LookAtTarget;

        private ulong ZoneUnlocks; // Presumably a bitfield
        private ulong RegionUnlocks; // Presumably a bitfield based of SDB dbzonemetadata::UnlockRegionSubZoneBits
        private EntityId ChatPartyLeaderId;
        private ScopeBubbleInfoData ScopeBubbleInfo;

        [AeroNullable] private CarryableObject CarryableObjects_0;
        [AeroNullable] private CarryableObject CarryableObjects_1;
        [AeroNullable] private CarryableObject CarryableObjects_2;
        [AeroNullable] private CachedAssetsData CachedAssets;
        [AeroNullable] private RespawnTimesData RespawnTimes;

        private uint ProgressionXp;
        private PermanentStatusEffectsData PermanentStatusEffects;
        private StatModifierData XpBoostModifier;
        private StatModifierData XpPermanentModifier;
        private StatModifierData XpZoneModifier;
        private StatModifierData XpVipModifier;
        private StatModifierData XpEventModifier;
        private StatModifierData ResourceBoostModifier;
        private StatModifierData ResourcePermanentModifier;
        private StatModifierData ResourceZoneModifier;
        private StatModifierData ResourceVipModifier;
        private StatModifierData ResourceEventModifier;
        private StatModifierData MoneyBoostModifier;
        private StatModifierData MoneyPermanentModifier;
        private StatModifierData MoneyZoneModifier;
        private StatModifierData MoneyVipModifier;
        private StatModifierData MoneyEventModifier;
        private StatModifierData ReputationBoostModifier;
        private StatModifierData ReputationPermanentModifier;
        private StatModifierData ReputationZoneModifier;
        private StatModifierData ReputationVipModifier;
        private StatModifierData ReputationEventModifier;
        private WalletData Wallet;
        private LoyaltyData Loyalty;
        private byte Level;
        private byte EffectiveLevel;
        private byte LevelResetCount;
        private byte OldestDeployables; // TODO: Verify, probably an array
        private uint PerkRespecs;

        [AeroNullable] private ArcStatusData ArcStatus;
        [AeroNullable] private LeaveZoneTimeData LeaveZoneTime;

        private byte ChatMuteStatus; // TODO: Verify
        private ulong TimedDailyReward;

        [AeroNullable] private TimedDailyRewardResultData TimedDailyRewardResult;

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
        [AeroNullable] private SinCardFieldData SinCardFields_20;
        [AeroNullable] private SinCardFieldData SinCardFields_21;
        [AeroNullable] private SinCardFieldData SinCardFields_22;
        
        private byte AssetOverrides; // TODO: Verify, probably an array 
        private ushort FriendCount;
        private CAISStatusData CAISStatus;
        private uint ScalingLevel;
        private uint PvPRank;
        private uint PvPRankPoints;
        private uint PvPTokens;
        private uint BountyPointsLastClaimed;
        private uint EliteLevel; 
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

    [AeroBlock]
    public struct EncounterPartyTupleData
    {
        public byte TODO; // TODO
    }

    [AeroBlock]
    public struct CachedAssetsData
    {
        public byte TODO; // TODO
    }

    [AeroBlock]
    public struct ArcStatusData
    {
        public byte TODO; // TODO
    }

    [AeroBlock]
    public struct LeaveZoneTimeData
    {
        public uint TODO; // TODO
    }

    [AeroBlock]
    public struct TimedDailyRewardResultData
    {
        public byte TODO; // TODO
    }
}