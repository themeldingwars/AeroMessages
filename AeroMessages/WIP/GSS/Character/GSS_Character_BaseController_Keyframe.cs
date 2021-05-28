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
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_BaseController_Keyframe
    {
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
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.CinematicCamera)]
        // --

        public CharacterStateData CharacterState; 
        public HostilityInfoData HosilityInfo;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
        
        public uint CurrentHealth;
        public uint CurrentShields;
        public MaxVital MaxHealth;
        public MaxVital MaxShields;
        public byte CurrentDurabilityPct;
        public EnergyParamsData EnergyParams;
        public CharacterStatsData CharacterStats;
        public EmoteData EmoteId;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.AttachedTo)]
        public AttachedToData AttachedTo;

        public byte SnapMount;
        public byte SinFlags;
        public byte SinFlagsPrivate;

        // TODO: Bitfield - SinFactionsAcquiredBy
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        public ulong ArmyGUID;
        public byte ArmyIsOfficer;

        // TODO: Bitfield - EncounterPartyTuple
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.EncounterPartyTuple)]
        // --
        
        [AeroArray(21)]
        public byte[] DockedParams;

        // TODO: Bitfield - LookAtTarget
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.LookAtTarget)]
        // public LookAtTargetData LookAtTarget;
        // --

        [AeroArray(8)]
        public byte[] ZoneUnlocks; // Bitfield

        [AeroArray(8)]
        public byte[] RegionUnlocks; // Bitfield

        public EntityId ChatPartyLeaderId;

        public ScopeBubbleInfoData ScopeBubbleInfo;

        // TODO: Bitfield - CarryableObjects_0
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_0)]
        // -
        // TODO: Bitfield - CarryableObjects_1
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_1)]
        // -
        // TODO: Bitfield - CarryableObjects_2 
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.CarryableObjects_2)]
        // -
        // TODO: Bitfield - CachedAssets
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.CachedAssets)]
        // -
        // TODO: Bitfield - RespawnTimes
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.RespawnTimes)]
        // -
     
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
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.ArcStatus)]
        // --
        // TODO: Bitfield - LeaveZoneTime  = 0x4d,
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.LeaveZoneTime)]
        // public uint LeaveZoneTime; // TOOD: Verify
        // --
        
        public byte ChatMuteStatus; // TODO: Verify
        public ulong TimedDailyReward;

        // TODO: Bitfield -  TimedDailyRewardResult      = 0x50,
        // [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.TimedDailyRewardResult)]
        // --

        // [AeroSDB("dbencounterdata::SinCardTemplate", "Id")]
        // [AeroSDB("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_20)]
        public SinCardFieldData SinCardFields_20;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_21)]
        public SinCardFieldData SinCardFields_21;

        [AeroIf(nameof(Bitfield), AeroIfAttribute.Ops.DoesntHaveFlag, BitfieldMask.SinCardFields_22)]
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
    public struct StaticInfoData
    {
        [AeroString]
        public string DisplayName;

        [AeroString]
        public string UniqueName;

        public byte Gender;
        public byte Race;

        //[AeroSDB("dbcharacter::CharInfo", "id")]
        public uint CharInfoId;

        //[AeroSDB("dbcharacter::Head", "id")]
        public uint HeadMain;

        //[AeroSDB("dbvisualrecords::EyeRecord", "id")]
        public uint Eyes;

        public byte Unk_1;
        public byte IsNPC;
        public byte StaffFlags; // ChatIconFlags might be a better name?

        //[AeroSDB("dbcharacter::Monster", "id")]
        public uint CharacterTypeId;

        //[AeroSDB("dbcharacter::VoiceSet", "id")]
        public uint VoiceSet;

        //[AeroSDB("dbcharacter::MonsterTitle", "id")]
        public ushort TitleId;

        //[AeroSDB("dblocalization::LocalizedText", "id")]
        public uint NameLocalizationId;

        [AeroArray(typeof(byte))]
        //[AeroSDB("dbcharacter::HeadAccesory", "ha_id")] // TODO: Double check
        public uint[] HeadAccessories;

        //[AeroSDB("dbitems::RootItem", "sdb_id")]
        public uint LoadoutVehicle;

        //[AeroSDB("dbitems::RootItem", "sdb_id")]
        public uint LoadoutGlider;

        public VisualsBlock Visuals;

        [AeroString]
        public string ArmyTag;
    }

    [AeroBlock]
    public struct VisualsBlock
    {
        [AeroArray(typeof(byte))]
        public VisualsDecalsBlock[] Decals;

        [AeroArray(typeof(byte))]
        public uint[] Gradients;

        [AeroArray(typeof(byte))]
        public uint[] Colors;

        [AeroArray(typeof(byte))]
        public VisualsPaletteBlock[] Palettes;

        [AeroArray(typeof(byte))]
        public VisualsPatternBlock[] Patterns;

        [AeroArray(typeof(byte))]
        public uint[] OrnamentGroupIds;

        [AeroArray(3)]
        public byte[] Unk; // Presumed to be Morph Weights, Overlays and something else?
    }

    [AeroBlock]
    public struct VisualsDecalsBlock
    {
        //[AeroSDB("dbvisualrecords::TatooDecal", "id")] // TODO: Verify
        public uint DecalId;
        public uint Color;

        [AeroArray(12)]
        public ushort[] Transform; // TODO: FIXME: Type should be Half ?

        public byte Usage;
    }

    [AeroBlock]
    public struct VisualsPaletteBlock
    {
        public byte PaletteType;

        //[AeroSDB("dbvisualrecords::WarpaintPalette", "id")]
        public uint PaletteId;
    }

    [AeroBlock]
    public struct VisualsPatternBlock
    {
        //[AeroSDB("dbvisualrecords::CziPattern", "id")]
        public uint PatternId;

        [AeroArray(4)]
        public ushort[] TransformValues;

        public byte Usage;
    }

    [AeroBlock]
    public struct EquipmentData
    {
        // Chassis
        public SlottedItem Chassis; // Battleframe

        [AeroArray(typeof(byte))]
        public SlottedItem[] ChassisModules; // Armor gear, perks

        public VisualsBlock ChassisVisuals;

        // Backpack
        public SlottedItem Backpack; // Reactor

        [AeroArray(typeof(byte))]
        public SlottedItem[] BackpackModules; // Abilities

        public VisualsBlock BackpackVisuals; // Does not affect in-game visuals?

        // Primary
        public SlottedItem PrimaryWeapon; // SlotIdx 0

        [AeroArray(typeof(byte))]
        public SlottedItem[] PrimaryWeaponOptModules;

        public VisualsBlock PrimaryWeaponVisuals;

        [AeroArray(8)]
        public byte[] PrimaryWeaponUnk;

        // Secondary
        public SlottedItem SecondaryWeapon; // SlotIdx 1
        [AeroArray(typeof(byte))]
        public SlottedItem[] SecondaryWeaponOptModules;

        public VisualsBlock SecondaryWeaponVisuals;

        [AeroArray(8)]
        public byte[] SecondaryWeaponUnk;

        [AeroArray(5)]
        public byte[] EndUnk;
    }

    [AeroBlock]
    public struct SlottedItem
    {
        //[AeroSDB("dbitems::RootItem", "sdb_id")]
        public uint SdbId;
        public uint SlotIndex;

        [AeroArray(2)]
        public byte[] Unk;
    }

    [AeroBlock]
    public struct GibVisuals
    {
        //[AeroSDB("dbcharacter::GibVisuals", "id")]
        public uint GibVisualsId;
        public uint Time;
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
    public struct CharacterStateData
    {
        public enum CharacterStatus : byte
        {
            Spawning = 0,
            Ghost = 1,
            Dead = 2,
            Respawning = 3,
            Incapacitated = 4,
            Traumatized = 5,
            Living = 6
        }

        public CharacterStatus State;
        public uint Time;
    }

    [AeroBlock]
    public struct MaxVital
    {
        public uint Value;
        public uint Time;
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
    public struct EmoteData {
        //[AeroSDB("dbcharacter::EmoteRecord", "id")]
        public ushort Id;
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
        //[AeroSDB("aptfs::StatModifierCommandDef", "id")] // TODO: Verify
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
    public struct AttachedToData
    {
        public enum AttachmentRoleType : byte
        {
            None = 0,
            Driver = 1,
            ActivePassenger = 3,
            PassivePassenger = 4,
            Turret = 5,
        }

        public EntityId Id1;
        public EntityId Id2;
        public AttachmentRoleType Role;

        [AeroArray(2)]
        public byte[] Unk;
    }



    [AeroBlock]
    public struct LookAtTargetData
    {
        // TODO: Verify
        public EntityId Target;

        [AeroArray(16)]
        public byte[] Unk;
    }

    
}