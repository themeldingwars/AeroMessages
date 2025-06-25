using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Character.Controller
{
    [Aero(AeroGenTypes.Controller)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 4)]
    public partial class BaseController
    {   
        private int TimePlayed;
        private int CurrentWeight;
        private int EncumberedWeight;
        private AuthorizedTerminalData AuthorizedTerminal;
        private uint PingTime;
        private StaticInfoData StaticInfo;
        private uint SpawnTime;
        private VisualOverridesField VisualOverrides;
        private EquipmentData CurrentEquipment;
        private int SelectedLoadout;
        private uint SelectedLoadoutIsPvP;
        private GibVisuals GibVisualsId;
        private CharacterSpawnPose SpawnPose;
        private ProcessDelayData ProcessDelay;
        private byte SpectatorMode;

        [AeroNullable] private CinematicCameraData CinematicCamera;

        private CharacterStateData CharacterState; 
        private HostilityInfoData HostilityInfo;

        [AeroNullable] private PersonalFactionStanceData PersonalFactionStance;

        private int CurrentHealth;
        private int CurrentShields;
        private MaxVital MaxShields;
        private MaxVital MaxHealth;
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
        private sbyte ArmyIsOfficer;

        [AeroNullable] private EncounterPartyTupleData EncounterPartyTuple;

        private DockedParamsData DockedParams;

        [AeroNullable] private LookAtTargetData LookAtTarget;

        private ulong ZoneUnlocks; // Bitfield
        private ulong RegionUnlocks; // Bitfield based of SDB dbzonemetadata::UnlockRegionSubZoneBits
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
        private OldestDeployablesField OldestDeployables;
        private uint PerkRespecs;

        [AeroNullable] private ArcStatusData ArcStatus;
        [AeroNullable] private uint LeaveZoneTime;

        private byte ChatMuteStatus;
        private TimedDailyRewardData TimedDailyReward;

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
        
        private AssetOverridesField AssetOverrides;
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
        public byte Unk1; // ???
        public byte Unk2; // ???
        public ushort JetpackEnergy;
        public short AirGroundTimer;
        public short JumpTimer;
        public byte HaveDebugData;
        [AeroIf(nameof(HaveDebugData), 1)] // != 0
        public MovementPoseDebugData DebugData;
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
        [AeroArray(typeof(byte))]
        public PermanentStatusEffectsInnerData[] Effects;
    }

    [AeroBlock]
    public struct PermanentStatusEffectsInnerData
    {
        public uint Id; // TODO: Verify
        public uint Unk2;
        public ulong Unk3;
    }

    [AeroBlock]
    public struct TimedDailyRewardData
    {
        public enum TimedDailyRewardState: byte
        {
            IDLE = 0,
            STARTED = 1,
            ROLLED = 2,
            ERROR = 3,
        }
        public byte Stage;
        public TimedDailyRewardState State;
        public byte RollNumber;
        public byte MaxRolls;
        public uint CountdownToTime; // countdown_secs, time ms in the future when this reward should be given
    }

    [AeroBlock]
    public struct StatModifierData
    {
        [AeroSdb("aptfs::StatModifierCommandDef", "id")] // TODO: Verify
        public uint ModifierId;
        public float StatValue;
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
        public ulong Unk1;
        public byte Unk2;
    }

    [AeroBlock]
    public struct CachedAssetsData
    {
        [AeroArray(typeof(byte))]
        public CachedAssetsInnerData[] Data;
    }

    [AeroBlock]
    public struct CachedAssetsInnerData
    {
        public ulong Unk1;
        public byte Unk2;
        [AeroArray(typeof(byte))] public CachedAssetsDeepData[] Unk3;
    }

    [AeroBlock]
    public struct CachedAssetsDeepData
    {
        public byte Unk1;
        [AeroArray(typeof(byte))] public uint[] Unk2;
    }

    [AeroBlock]
    public struct ArcStatusData
    {
        public ulong Unk1;
        public uint Unk2;
        public byte Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct TimedDailyRewardResultData
    {
        [AeroArray(3)] public uint[] Unk1;
        [AeroArray(3)] public uint[] Unk2;
        public byte Unk3;  
    }

    [AeroBlock]
    public struct OldestDeployablesField
    {
        [AeroArray(typeof(byte))]
        public OldestDeployablesData[] Data;
        
    }

    [AeroBlock]
    public struct OldestDeployablesData
    {
        public EntityId Deployable;
        public uint Unk2;
        public byte Unk3;
    }
}