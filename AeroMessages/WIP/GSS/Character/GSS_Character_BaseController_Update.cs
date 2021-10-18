using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [AeroBlock]
    public struct Character_BaseController_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            TimePlayed                  = 0x00,
            CurrentWeight               = 0x01,
            EncumberedWeight            = 0x02,
            AuthorizedTerminal          = 0x03,
            PingTime                    = 0x04,
            StaticInfo                  = 0x05,
            SpawnTime                   = 0x06,
            VisualOverrides             = 0x07,
            CurrentEquipment            = 0x08,
            SelectedLoadout             = 0x09,
            SelectedLoadoutIsPvP        = 0x0a,
            GibVisualsID                = 0x0b,
            SpawnPose                   = 0x0c,
            ProcessDelay                = 0x0d,
            SpectatorMode               = 0x0e,
            CinematicCamera             = 0x0f,
            CharacterState              = 0x10,
            HostilityInfo               = 0x11,
            PersonalFactionStance       = 0x12,
            CurrentHealth               = 0x13,
            CurrentShields              = 0x14,
            MaxShields                  = 0x15,
            MaxHealth                   = 0x16,
            CurrentDurabilityPct        = 0x17,
            EnergyParams                = 0x18,
            CharacterStats              = 0x19,
            EmoteID                     = 0x1a,
            AttachedTo                  = 0x1b,
            SnapMount                   = 0x1c,
            SinFlags                    = 0x1d,
            SinFlagsPrivate             = 0x1e,
            SinFactionsAcquiredBy       = 0x1f,
            SinTeamsAcquiredBy          = 0x20,
            ArmyGUID                    = 0x21,
            ArmyIsOfficer               = 0x22,
            EncounterPartyTuple         = 0x23,
            DockedParams                = 0x24,
            LookAtTarget                = 0x25,
            ZoneUnlocks                 = 0x26,
            RegionUnlocks               = 0x27,
            ChatPartyLeaderId           = 0x28,
            ScopeBubbleInfo             = 0x29,
            CarryableObjects_0          = 0x2a,
            CarryableObjects_1          = 0x2b,
            CarryableObjects_2          = 0x2c,
            CachedAssets                = 0x2d,
            RespawnTimes                = 0x2e,
            ProgressionXp               = 0x2f,
            PermanentStatusEffects      = 0x30,
            XpBoostModifier             = 0x31,
            XpPermanentModifier         = 0x32,
            XpZoneModifier              = 0x33,
            XpVipModifier               = 0x34,
            XpEventModifier             = 0x35,
            ResourceBoostModifier       = 0x36,
            ResourcePermanentModifier   = 0x37,
            ResourceZoneModifier        = 0x38,
            ResourceVipModifier         = 0x39,
            ResourceEventModifier       = 0x3a,
            MoneyBoostModifier          = 0x3b,
            MoneyPermanentModifier      = 0x3c,
            MoneyZoneModifier           = 0x3d,
            MoneyVipModifier            = 0x3e,
            MoneyEventModifier          = 0x3f,
            ReputationBoostModifier     = 0x40,
            ReputationPermanentModifier = 0x41,
            ReputationZoneModifier      = 0x42,
            ReputationVipModifier       = 0x43,
            ReputationEventModifier     = 0x44,
            Wallet                      = 0x45,
            Loyalty                     = 0x46,
            Level                       = 0x47,
            EffectiveLevel              = 0x48,
            LevelResetCount             = 0x49,
            OldestDeployables           = 0x4a,
            PerkRespecs                 = 0x4b,
            ArcStatus                   = 0x4c,
            LeaveZoneTime               = 0x4d,
            ChatMuteStatus              = 0x4e,
            TimedDailyReward            = 0x4f,
            TimedDailyRewardResult      = 0x50,
            SinCardType                 = 0x51,
            SinCardFields_0             = 0x52,
            SinCardFields_1             = 0x53,
            SinCardFields_2             = 0x54,
            SinCardFields_3             = 0x55,
            SinCardFields_4             = 0x56,
            SinCardFields_5             = 0x57,
            SinCardFields_6             = 0x58,
            SinCardFields_7             = 0x59,
            SinCardFields_8             = 0x5a,
            SinCardFields_9             = 0x5b,
            SinCardFields_10            = 0x5c,
            SinCardFields_11            = 0x5d,
            SinCardFields_12            = 0x5e,
            SinCardFields_13            = 0x5f,
            SinCardFields_14            = 0x60,
            SinCardFields_15            = 0x61,
            SinCardFields_16            = 0x62,
            SinCardFields_17            = 0x63,
            SinCardFields_18            = 0x64,
            SinCardFields_19            = 0x65,
            SinCardFields_20            = 0x66,
            SinCardFields_21            = 0x67,
            SinCardFields_22            = 0x68,
            AssetOverrides              = 0x69,
            FriendCount                 = 0x6a,
            CAISStatus                  = 0x6b,
            ScalingLevel                = 0x6c,
            PvPRank                     = 0x6d,
            PvPRankPoints               = 0x6e,
            PvPTokens                   = 0x6f,
            BountyPointsLastClaimed     = 0x70,
            EliteLevel                  = 0x71,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.TimePlayed)]
        public uint TimePlayed;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentWeight)]
        public uint CurrentWeight;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EncumberedWeight)]
        public uint EncumberedWeight;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AuthorizedTerminal)]
        public AuthorizedTerminalData AuthorizedTerminal;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PingTime)]
        public uint PingTime;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StaticInfo)]
        public StaticInfoData StaticInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SpawnTime)]
        public uint SpawnTime;
        [AeroIf(nameof(Idx), ShadowFieldIndex.VisualOverrides)]
        public byte VisualOverrides; // TODO: More data if non 0?
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentEquipment)]
        public EquipmentData CurrentEquipment;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SelectedLoadout)]
        public uint SelectedLoadout;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SelectedLoadoutIsPvP)]
        public uint SelectedLoadoutIsPvP;
        [AeroIf(nameof(Idx), ShadowFieldIndex.GibVisualsID)]
        public GibVisuals GibVisualsId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SpawnPose)]
        public CharacterSpawnPose SpawnPose;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ProcessDelay)]
        public uint ProcessDelay;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SpectatorMode)]
        public byte SpectatorMode;

        // TODO: Bitfield - Cinematic Camera
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CinematicCamera)]
        // --

        [AeroIf(nameof(Idx), ShadowFieldIndex.CharacterState)]
        public CharacterStateData CharacterState; 
        [AeroIf(nameof(Idx), ShadowFieldIndex.HostilityInfo)]
        public HostilityInfoData HostilityInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentHealth)]
        public uint CurrentHealth;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentShields)]
        public uint CurrentShields;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxShields)]
        public MaxVital MaxHealth;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxHealth)]
        public MaxVital MaxShields;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentDurabilityPct)]
        public byte CurrentDurabilityPct;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EnergyParams)]
        public EnergyParamsData EnergyParams;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CharacterStats)]
        public CharacterStatsData CharacterStats;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EmoteID)]
        public EmoteData EmoteId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AttachedTo)]
        public AttachedToData AttachedTo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SnapMount)]
        public byte SnapMount;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinFlags)]
        public byte SinFlags;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinFlagsPrivate)]
        public byte SinFlagsPrivate;

        // TODO: Bitfield - SinFactionsAcquiredBy
        // [AeroIf(nameof(Idx), ShadowFieldIndex.SinFactionsAcquiredBy)]
        // public SinFactionsAcquiredByData SinFactionsAcquiredBy;
        // --
        // TODO: Bitfield - SinTeamsAcquiredBy
        // [AeroIf(nameof(Idx), ShadowFieldIndex.SinTeamsAcquiredBy)]
        // public SinTeamsAcquiredByData SinTeamsAcquiredBy;
        // --

        [AeroIf(nameof(Idx), ShadowFieldIndex.ArmyGUID)]
        public ulong ArmyGUID;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ArmyIsOfficer)]
        public byte ArmyIsOfficer;

        // TODO: Bitfield - EncounterPartyTuple
        // [AeroIf(nameof(Idx), ShadowFieldIndex.EncounterPartyTuple)]
        // --
        
        [AeroIf(nameof(Idx), ShadowFieldIndex.DockedParams)]
        [AeroArray(21)]
        public byte[] DockedParams;

        [AeroIf(nameof(Idx), ShadowFieldIndex.LookAtTarget)]
        public LookAtTargetData LookAtTarget;

        [AeroIf(nameof(Idx), ShadowFieldIndex.ZoneUnlocks)]
        [AeroArray(8)]
        public byte[] ZoneUnlocks; // Bitfield

        [AeroIf(nameof(Idx), ShadowFieldIndex.RegionUnlocks)]
        [AeroArray(8)]
        public byte[] RegionUnlocks; // Bitfield

        [AeroIf(nameof(Idx), ShadowFieldIndex.ChatPartyLeaderId)]
        public EntityId ChatPartyLeaderId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;

        // TODO: Bitfield - CarryableObjects_0
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CarryableObjects_0)]
        // -
        // TODO: Bitfield - CarryableObjects_1
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CarryableObjects_1)]
        // -
        // TODO: Bitfield - CarryableObjects_2
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CarryableObjects_2)]
        // -
        // TODO: Bitfield - CachedAssets
        // [AeroIf(nameof(Idx), ShadowFieldIndex.CachedAssets)]
        // -

        [AeroIf(nameof(Idx), ShadowFieldIndex.RespawnTimes)]
        public RespawnTimesData RespawnTimes;
        
        [AeroIf(nameof(Idx), ShadowFieldIndex.ProgressionXp)]
        [AeroArray(4)]
        public byte[] ProgressionXp; // TODO: Verify, not sure if a single value or several

        [AeroIf(nameof(Idx), ShadowFieldIndex.PermanentStatusEffects)]
        public PermanentStatusEffectsData PermanentStatusEffects;
        [AeroIf(nameof(Idx), ShadowFieldIndex.XpBoostModifier)]
        public StatModifierData XpBoostModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.XpPermanentModifier)]
        public StatModifierData XpPermanentModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.XpZoneModifier)]
        public StatModifierData XpZoneModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.XpVipModifier)]
        public StatModifierData XpVipModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.XpEventModifier)]
        public StatModifierData XpEventModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ResourceBoostModifier)]
        public StatModifierData ResourceBoostModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ResourcePermanentModifier)]
        public StatModifierData ResourcePermanentModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ResourceZoneModifier)]
        public StatModifierData ResourceZoneModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ResourceVipModifier)]
        public StatModifierData ResourceVipModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ResourceEventModifier)]
        public StatModifierData ResourceEventModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MoneyBoostModifier)]
        public StatModifierData MoneyBoostModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MoneyPermanentModifier)]
        public StatModifierData MoneyPermanentModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MoneyZoneModifier)]
        public StatModifierData MoneyZoneModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MoneyVipModifier)]
        public StatModifierData MoneyVipModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MoneyEventModifier)]
        public StatModifierData MoneyEventModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ReputationBoostModifier)]
        public StatModifierData ReputationBoostModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ReputationPermanentModifier)]
        public StatModifierData ReputationPermanentModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ReputationZoneModifier)]
        public StatModifierData ReputationZoneModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ReputationVipModifier)]
        public StatModifierData ReputationVipModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ReputationEventModifier)]
        public StatModifierData ReputationEventModifier;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Wallet)]
        public WalletData Wallet;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Loyalty)]
        public LoyaltyData Loyalty;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Level)]
        public byte Level;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EffectiveLevel)]
        public byte EffectiveLevel;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LevelResetCount)]
        public byte LevelResetCount;
        [AeroIf(nameof(Idx), ShadowFieldIndex.OldestDeployables)]
        public byte OldestDeployables; // TODO: Verify, probably an array
        [AeroIf(nameof(Idx), ShadowFieldIndex.PerkRespecs)]
        public uint PerkRespecs;

        // TODO: Bitfield - ArcStatus  = 0x4c,
        // [AeroIf(nameof(Idx), ShadowFieldIndex.ArcStatus)]
        // --
        // TODO: Bitfield - LeaveZoneTime  = 0x4d,
        // [AeroIf(nameof(Idx), ShadowFieldIndex.LeaveZoneTime)]
        // public uint LeaveZoneTime; // TOOD: Verify
        // --
        
        [AeroIf(nameof(Idx), ShadowFieldIndex.ChatMuteStatus)]
        public byte ChatMuteStatus;
        [AeroIf(nameof(Idx), ShadowFieldIndex.TimedDailyReward)]
        public ulong TimedDailyReward;

        // TODO: Bitfield -  TimedDailyRewardResult      = 0x50,
        // [AeroIf(nameof(Idx), ShadowFieldIndex.TimedDailyRewardResult)]
        // --

        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardType)]
        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint SinCardType;

        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_0)]
        public SinCardFieldData SinCardFields_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_1)]
        public SinCardFieldData SinCardFields_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_2)]
        public SinCardFieldData SinCardFields_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_3)]
        public SinCardFieldData SinCardFields_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_4)]
        public SinCardFieldData SinCardFields_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_5)]
        public SinCardFieldData SinCardFields_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_6)]
        public SinCardFieldData SinCardFields_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_7)]
        public SinCardFieldData SinCardFields_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_8)]
        public SinCardFieldData SinCardFields_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_9)]
        public SinCardFieldData SinCardFields_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_10)]
        public SinCardFieldData SinCardFields_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_11)]
        public SinCardFieldData SinCardFields_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_12)]
        public SinCardFieldData SinCardFields_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_13)]
        public SinCardFieldData SinCardFields_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_14)]
        public SinCardFieldData SinCardFields_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_15)]
        public SinCardFieldData SinCardFields_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_16)]
        public SinCardFieldData SinCardFields_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_17)]
        public SinCardFieldData SinCardFields_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_18)]
        public SinCardFieldData SinCardFields_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_19)]
        public SinCardFieldData SinCardFields_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_20)]
        public SinCardFieldData SinCardFields_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_21)]
        public SinCardFieldData SinCardFields_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.SinCardFields_22)]
        public SinCardFieldData SinCardFields_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.AssetOverrides)]
        public byte AssetOverrides;
        [AeroIf(nameof(Idx), ShadowFieldIndex.FriendCount)]
        public ushort FriendCount;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CAISStatus)]
        public CAISStatusData CAISStatus;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScalingLevel)]
        public uint ScalingLevel;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PvPRank)]
        public uint PvPRank;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PvPRankPoints)]
        public uint PvPRankPoints;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PvPTokens)]
        public uint PvPTokens;
        [AeroIf(nameof(Idx), ShadowFieldIndex.BountyPointsLastClaimed)]
        public uint BountyPointsLastClaimed;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EliteLevel)]
        public uint EliteLevel;

    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 1)]
    public partial class Character_BaseController_Update
    {
        [AeroArray(-226)]
        public Character_BaseController_ShadowFieldUpdate[] Updates;
    }
}