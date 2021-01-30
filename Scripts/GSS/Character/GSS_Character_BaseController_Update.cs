using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 1, true)]
    public class CharacterBaseControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {   
            TimePlayed              = 0x00,
            CurrentWeight           = 0x01, // CurrentWeight
            EncumberedWeight        = 0x02, // MaxsInventorySlots
            AuthorizedTerminal      = 0x03,
            PingTime                = 0x04,
            StaticInfo              = 0x05, // ObserverData, Look to Character_ObserverView_Keyframe for decoding
            SpawnTime               = 0x06,
            VisualOverrides         = 0x07,
            CurrentEquipment        = 0x08, // EquipmentData, Look to Character_EquipmentView_Keyframe for decoding
            SelectedLoadout         = 0x09, // LoadoutId
            SelectedLoadoutIsPvP    = 0x0a,
            GibVisualsID            = 0x0b,
            SpawnPose               = 0x0c, // MovementData, Look to Character_MovementView_Keyframe for decoding
            ProcessDelay            = 0x0d, // Equivalent of 0x04 in Observer View
            SpectatorMode           = 0x0e,
            CinematicCamera         = 0x0f,
            CharacterState          = 0x10,
            HostilityInfo           = 0x11,
            PersonalFactionStance   = 0x12,
            CurrentHealth           = 0x13,
            CurrentShields          = 0x14,
            MaxShields              = 0x15,
            MaxHealth               = 0x16,
            CurrentDurabilityPct    = 0x17,
            EnergyParams            = 0x18,
            CharacterStats          = 0x19,
            EmoteID                 = 0x1a,
            AttachedTo              = 0x1b,
            SnapMount               = 0x1c,
            SinFlags                = 0x1d,
            SinFlagsPrivate         = 0x1e,
            SinFactionsAcquiredBy   = 0x1f,
            SinTeamsAcquiredBy      = 0x20,
            ArmyGUID                = 0x21,
            ArmyIsOfficer           = 0x22,
            EncounterPartyTuple     = 0x23,
            DockedParams            = 0x24,
            LookAtTarget            = 0x25,
            ZoneUnlocks             = 0x26,
            RegionUnlocks           = 0x27,
            ChatPartyLeaderId       = 0x28,
            ScopeBubbleInfo         = 0x29,

            CarryableObjects_0      = 0x2a,
            CarryableObjects_1      = 0x2b,
            CarryableObjects_2      = 0x2c,
            CachedAssets            = 0x2d,
            RespawnTimes            = 0x2e,

            ProgressionXp           = 0x2f,
            PermanentStatusEffects  = 0x30,
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

            // Reset fields
            Clear_CinematicCamera        = 0x8f,
            Clear_PersonalFactionStance  = 0x92,
            Clear_AttachedTo             = 0x9b,
            Clear_SinFactionsAcquiredBy  = 0x9f,
            Clear_SinTeamsAqquiredBy     = 0xa0,
            Clear_EncounterPartyTuple    = 0xa3,
            Clear_LookAtTarget           = 0xa5,
            Clear_CarryableObjects_0     = 0xaa,
            Clear_CarryableObjects_1     = 0xab,
            Clear_CarryableObjects_2     = 0xac,
            Clear_CachedAssets           = 0xad,
            Clear_RespawnTimes           = 0xae,
            Clear_ArcStatus              = 0xcc,
            Clear_LeaveZoneTime          = 0xcd,
            Clear_TimedDailyRewardResult = 0xd0,
            Clear_SinCardFields_0        = 0xd2,
            Clear_SinCardFields_1        = 0xd3,
            Clear_SinCardFields_2        = 0xd4,
            Clear_SinCardFields_3        = 0xd5,
            Clear_SinCardFields_4        = 0xd6,
            Clear_SinCardFields_5        = 0xd7,
            Clear_SinCardFields_6        = 0xd8,
            Clear_SinCardFields_7        = 0xd9,
            Clear_SinCardFields_8        = 0xda,
            Clear_SinCardFields_9        = 0xdb,
            Clear_SinCardFields_10       = 0xdc,
            Clear_SinCardFields_11       = 0xdd,
            Clear_SinCardFields_12       = 0xde,
            Clear_SinCardFields_13       = 0xdf,
            Clear_SinCardFields_14       = 0xe0,
            Clear_SinCardFields_15       = 0xe1,
            Clear_SinCardFields_16       = 0xe2,
            Clear_SinCardFields_17       = 0xe3,
            Clear_SinCardFields_18       = 0xe4,
            Clear_SinCardFields_19       = 0xe5,
            Clear_SinCardFields_20       = 0xe6,
            Clear_SinCardFields_21       = 0xe7,
            Clear_SinCardFields_22       = 0xe8,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public uint? TimePlayed;
        public uint? CurrentWeight;
        public uint? EncumberedWeight;
        public byte? AuthorizedTerminalType;
        public uint? AuthorizedTerminalId;
        public byte[] AuthorizedTerminalEntity;
        public uint? PingTime;
        public byte[] StaticInfo;
        public uint? SpawnTime;
        public byte? VisualOverrides;
        public byte[] CurrentEquipment;
        public uint? SelectedLoadout;
        public uint? SelectedLoadoutIsPvP;
        public uint? GibVisualsID_Value;
        public uint? GibVisualsID_Time;
        public byte[] SpawnPose;
        public uint? ProcessDelay;
        public byte? CharacterState;
        public uint? CharacterState_Time;
        public byte? SpectatorMode;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        public uint? CurrentHealth;
        public uint? CurrentShields;
        public uint? MaxShields;
        public uint? MaxShields_Time;
        public uint? MaxHealth;
        public uint? MaxHealth_Time;
        public byte? CurrentDurabilityPct;
        public float? EnergyParams_EnergyMax;
        public uint? EnergyParams_Delay;
        public float? EnergyParams_Recharge;
        public uint? EnergyParams_Time;

        public byte[] CharacterStats;

        public ushort? EmoteID_Value; // Sdb table 73, id column
        public uint? EmoteID_Time;
        public byte? SnapMount;
        public byte? SinFlags;
        public byte? SinFlagsPrivate;

        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;

        public ulong? ArmyGUID;
        public byte? ArmyIsOfficer;
        public byte[] ZoneUnlocks;
        public byte[] RegionUnlocks;
        public byte[] ScopeBubbleInfo;
        public byte[] ChatPartyLeaderId;
        public uint ProgressionXp;

        public byte[] PermanentStatusEffects;

        public byte[] XpBoostModifier;
        public byte[] XpPermanentModifier;
        public byte[] XpZoneModifier;
        public byte[] XpVipModifier;
        public byte[] XpEventModifier;
        public byte[] ResourceBoostModifier;
        public byte[] ResourcePermanentModifier;
        public byte[] ResourceZoneModifier;
        public byte[] ResourceVipModifier;
        public byte[] ResourceEventModifier;
        public byte[] MoneyBoostModifier;
        public byte[] MoneyPermanentModifier;
        public byte[] MoneyZoneModifier;
        public byte[] MoneyVipModifier;
        public byte[] MoneyEventModifier;
        public byte[] ReputationBoostModifier;
        public byte[] ReputationPermanentModifier;
        public byte[] ReputationZoneModifier;
        public byte[] ReputationVipModifier;
        public byte[] ReputationEventModifier;
        public uint Wallet_RedBeans;
        public uint Wallet_Epoch;
        public uint Loyalty_CurrentPoints;
        public uint Loyalty_LifetimePoints;
        public uint Loyalty_Tier;
        public byte? Level;
        public byte? EffectiveLevel;
        public byte? LevelResetCount;
        //public byte[] OldestDeployables; // Dunno
        public uint PerkRespecs;
        //public byte[] ArcStatus; // Dunno
        public uint? LeaveZoneTime; // Guess
        public byte? ChatMuteStatus;
        public byte[] TimedDailyReward;
        //public byte[] TimedDailyRewardResult // Dunno
        public uint SinCardType;
        public SinCardField SinCardFields_0;
        public SinCardField SinCardFields_1;
        public SinCardField SinCardFields_2;
        public SinCardField SinCardFields_3;
        public SinCardField SinCardFields_4;
        public SinCardField SinCardFields_5;
        public SinCardField SinCardFields_6;
        public SinCardField SinCardFields_7;
        public SinCardField SinCardFields_8;
        public SinCardField SinCardFields_9;
        public SinCardField SinCardFields_10;
        public SinCardField SinCardFields_11;
        public SinCardField SinCardFields_12;
        public SinCardField SinCardFields_13;
        public SinCardField SinCardFields_14;
        public SinCardField SinCardFields_15;
        public SinCardField SinCardFields_16;
        public SinCardField SinCardFields_17;
        public SinCardField SinCardFields_18;
        public SinCardField SinCardFields_19;
        public SinCardField SinCardFields_20;
        public SinCardField SinCardFields_21;
        public SinCardField SinCardFields_22;
        public ushort FriendCount;
        public byte CAISStatus_State;
        public uint CAISStatus_ElapsedSeconds; 
        public byte[] ScalingLevel;
        public uint PvPRank;
        public uint PvPRankPoints;
        public uint PvPTokens;
        public uint BountyPointsLastClaimed;
        public uint EliteLevel;


        public bool? Clear_CinematicCamera;
        public bool? Clear_PersonalFactionStance;
        public bool? Clear_AttachedTo;
        public bool? Clear_SinFactionsAcquiredBy;
        public bool? Clear_SinTeamsAqquiredBy;
        public bool? Clear_EncounterPartyTuple;
        public bool? Clear_LookAtTarget;
        public bool? Clear_CarryableObjects_0;
        public bool? Clear_CarryableObjects_1;
        public bool? Clear_CarryableObjects_2;
        public bool? Clear_CachedAssets;
        public bool? Clear_RespawnTimes;
        public bool? Clear_ArcStatus;
        public bool? Clear_LeaveZoneTime;
        public bool? Clear_TimedDailyRewardResult;
        public bool? Clear_SinCardFields_0;
        public bool? Clear_SinCardFields_1;
        public bool? Clear_SinCardFields_2;
        public bool? Clear_SinCardFields_3;
        public bool? Clear_SinCardFields_4;
        public bool? Clear_SinCardFields_5;
        public bool? Clear_SinCardFields_6;
        public bool? Clear_SinCardFields_7;
        public bool? Clear_SinCardFields_8;
        public bool? Clear_SinCardFields_9;
        public bool? Clear_SinCardFields_10;
        public bool? Clear_SinCardFields_11;
        public bool? Clear_SinCardFields_12;
        public bool? Clear_SinCardFields_13;
        public bool? Clear_SinCardFields_14;
        public bool? Clear_SinCardFields_15;
        public bool? Clear_SinCardFields_16;
        public bool? Clear_SinCardFields_17;
        public bool? Clear_SinCardFields_18;
        public bool? Clear_SinCardFields_19;
        public bool? Clear_SinCardFields_20;
        public bool? Clear_SinCardFields_21;
        public bool? Clear_SinCardFields_22;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.TimePlayed:
                        TimePlayed = Stream.Read.UInt();
                        break;
                        
                    case ShadowFieldIndex.CurrentWeight:
                        CurrentWeight = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.EncumberedWeight:
                        EncumberedWeight = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.AuthorizedTerminal:
                        AuthorizedTerminalType = Stream.Read.Byte();
                        AuthorizedTerminalId = Stream.Read.UInt();
                        AuthorizedTerminalEntity = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.PingTime:
                        PingTime = Stream.Read.UInt();
                        break;

                    //case ShadowFieldIndex.StaticInfo:
                    //    StaticInfo = ; // Variable length needs indepth parsing
                    //    break;

                    case ShadowFieldIndex.SpawnTime:
                        SpawnTime = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.VisualOverrides:
                        VisualOverrides = Stream.Read.Byte(); // TODO: Presumably more data if set?
                        break;

                    //case ShadowFieldIndex.CurrentEquipment:
                    //    CurrentEquipment = ; // Variable length needs indepth parsing
                    //    break;

                    case ShadowFieldIndex.SelectedLoadout:
                        SelectedLoadout = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.SelectedLoadoutIsPvP:
                        SelectedLoadoutIsPvP = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.GibVisualsID:
                        GibVisualsID_Value = Stream.Read.UInt();
                        GibVisualsID_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.SpawnPose:
                        SpawnPose = Stream.Read.ByteArray(67); // TODO: Might as well add indepth parsing
                        break;

                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.CharacterState:
                        CharacterState = Stream.Read.Byte();
                        CharacterState_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.SpectatorMode:
                        SpectatorMode = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.HostilityInfo:
                        HostilityInfo = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.PersonalFactionStance:
                        PersonalFactionStance = Stream.Read.ByteArray(20);
                        break;

                    case ShadowFieldIndex.CurrentHealth:
                        CurrentHealth = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.CurrentShields:
                        CurrentShields = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.MaxShields:
                        MaxShields = Stream.Read.UInt();
                        MaxShields_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.MaxHealth:
                        MaxHealth = Stream.Read.UInt();
                        MaxHealth_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.CurrentDurabilityPct:
                        CurrentDurabilityPct = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.EnergyParams:
                        EnergyParams_EnergyMax = Stream.Read.Float();
                        EnergyParams_Delay = Stream.Read.UInt(); // Not sure
                        EnergyParams_Recharge = Stream.Read.Float();
                        EnergyParams_Time = Stream.Read.UInt();
                        break;

                    //case ShadowFieldIndex.CharacterStats:
                    //    CharacterStats = ; // Variable length needs indepth parsing
                    //    break;

                    case ShadowFieldIndex.EmoteID:
                        EmoteID_Value = Stream.Read.UShort();
                        EmoteID_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.SnapMount:
                        SnapMount = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.SinFlags:
                        SinFlags = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.SinFlagsPrivate:
                        SinFlagsPrivate = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.SinFactionsAcquiredBy:
                        SinFactionsAcquiredBy = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.SinTeamsAcquiredBy:
                        SinTeamsAcquiredBy = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.ArmyGUID:
                        ArmyGUID = Stream.Read.ULong();
                        break;

                    case ShadowFieldIndex.ArmyIsOfficer:
                        ArmyIsOfficer = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.ZoneUnlocks:
                        ZoneUnlocks = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.RegionUnlocks:
                        RegionUnlocks = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ChatPartyLeaderId:
                        ChatPartyLeaderId = Stream.Read.ByteArray(8); // guess
                        break;

                    case ShadowFieldIndex.ProgressionXp:
                        ProgressionXp = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.PermanentStatusEffects:
                        byte pse_count = Stream.Read.Byte();
                        PermanentStatusEffects = Stream.Read.ByteArray((int)pse_count * (4+4+8));
                        break;

                    case ShadowFieldIndex.XpBoostModifier:
                        XpBoostModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.XpPermanentModifier:
                        XpPermanentModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.XpZoneModifier:
                        XpZoneModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.XpVipModifier:
                        XpVipModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.XpEventModifier:
                        XpEventModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ResourceBoostModifier:
                        ResourceBoostModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ResourcePermanentModifier:
                        ResourcePermanentModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ResourceZoneModifier:
                        ResourceZoneModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ResourceVipModifier:
                        ResourceVipModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ResourceEventModifier:
                        ResourceEventModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.MoneyBoostModifier:
                        MoneyBoostModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.MoneyPermanentModifier:
                        MoneyPermanentModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.MoneyZoneModifier:
                        MoneyZoneModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.MoneyVipModifier:
                        MoneyVipModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.MoneyEventModifier:
                        MoneyEventModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ReputationBoostModifier:
                        ReputationBoostModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ReputationPermanentModifier:
                        ReputationPermanentModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ReputationZoneModifier:
                        ReputationZoneModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ReputationVipModifier:
                        ReputationVipModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ReputationEventModifier:
                        ReputationEventModifier = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Wallet:
                        Wallet_RedBeans = Stream.Read.UInt();
                        Wallet_Epoch = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Loyalty:
                        Loyalty_CurrentPoints = Stream.Read.UInt();
                        Loyalty_LifetimePoints = Stream.Read.UInt();
                        Loyalty_Tier = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Level:
                        Level = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.EffectiveLevel:
                        EffectiveLevel = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.LevelResetCount:
                        LevelResetCount = Stream.Read.Byte();
                        break;
                    
                    //OldestDeployables

                    case ShadowFieldIndex.PerkRespecs:
                        PerkRespecs = Stream.Read.UInt();
                        break;


                    case ShadowFieldIndex.LeaveZoneTime:
                        LeaveZoneTime = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.ChatMuteStatus:
                        ChatMuteStatus = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.TimedDailyReward:
                        TimedDailyReward = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.SinCardType:
                        SinCardType = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.SinCardFields_0:
                        SinCardFields_0 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_1:
                        SinCardFields_1 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_2:
                        SinCardFields_2 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_3:
                        SinCardFields_3 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_4:
                        SinCardFields_4 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_5:
                        SinCardFields_5 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_6:
                        SinCardFields_6 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_7:
                        SinCardFields_7 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_8:
                        SinCardFields_8 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_9:
                        SinCardFields_9 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_10:
                        SinCardFields_10 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_11:
                        SinCardFields_11 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_12:
                        SinCardFields_12 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_13:
                        SinCardFields_13 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_14:
                        SinCardFields_14 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_15:
                        SinCardFields_15 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_16:
                        SinCardFields_16 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_17:
                        SinCardFields_17 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_18:
                        SinCardFields_18 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_19:
                        SinCardFields_19 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_20:
                        SinCardFields_20 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_21:
                        SinCardFields_21 = Stream.Read.SinCardField();
                        break;
                    case ShadowFieldIndex.SinCardFields_22:
                        SinCardFields_22 = Stream.Read.SinCardField();
                        break;

                    case ShadowFieldIndex.FriendCount:
                        FriendCount = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.CAISStatus:
                        CAISStatus_State = Stream.Read.Byte();
                        CAISStatus_ElapsedSeconds = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.PvPRank:
                        PvPRank = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.PvPRankPoints:
                        PvPRankPoints = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.PvPTokens:
                        PvPTokens = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.BountyPointsLastClaimed:
                        BountyPointsLastClaimed = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.EliteLevel:
                        EliteLevel = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Clear_CinematicCamera:
                        Clear_CinematicCamera = true;
                        break;
                    case ShadowFieldIndex.Clear_PersonalFactionStance:
                        Clear_PersonalFactionStance = true;
                        break;
                    case ShadowFieldIndex.Clear_AttachedTo:
                        Clear_AttachedTo = true;
                        break;
                    case ShadowFieldIndex.Clear_SinFactionsAcquiredBy:
                        Clear_SinFactionsAcquiredBy = true;
                        break;
                    case ShadowFieldIndex.Clear_SinTeamsAqquiredBy:
                        Clear_SinTeamsAqquiredBy = true;
                        break;
                    case ShadowFieldIndex.Clear_EncounterPartyTuple:
                        Clear_EncounterPartyTuple = true;
                        break;
                    case ShadowFieldIndex.Clear_LookAtTarget:
                        Clear_LookAtTarget = true;
                        break;
                    case ShadowFieldIndex.Clear_CarryableObjects_0:
                        Clear_CarryableObjects_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_CarryableObjects_1:
                        Clear_CarryableObjects_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_CarryableObjects_2:
                        Clear_CarryableObjects_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_CachedAssets:
                        Clear_CachedAssets = true;
                        break;
                    case ShadowFieldIndex.Clear_RespawnTimes:
                        Clear_RespawnTimes = true;
                        break;
                    case ShadowFieldIndex.Clear_ArcStatus:
                        Clear_ArcStatus = true;
                        break;
                    case ShadowFieldIndex.Clear_LeaveZoneTime:
                        Clear_LeaveZoneTime = true;
                        break;
                    case ShadowFieldIndex.Clear_TimedDailyRewardResult:
                        Clear_TimedDailyRewardResult = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_0:
                        Clear_SinCardFields_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_1:
                        Clear_SinCardFields_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_2:
                        Clear_SinCardFields_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_3:
                        Clear_SinCardFields_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_4:
                        Clear_SinCardFields_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_5:
                        Clear_SinCardFields_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_6:
                        Clear_SinCardFields_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_7:
                        Clear_SinCardFields_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_8:
                        Clear_SinCardFields_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_9:
                        Clear_SinCardFields_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_10:
                        Clear_SinCardFields_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_11:
                        Clear_SinCardFields_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_12:
                        Clear_SinCardFields_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_13:
                        Clear_SinCardFields_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_14:
                        Clear_SinCardFields_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_15:
                        Clear_SinCardFields_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_16:
                        Clear_SinCardFields_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_17:
                        Clear_SinCardFields_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_18:
                        Clear_SinCardFields_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_19:
                        Clear_SinCardFields_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_20:
                        Clear_SinCardFields_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_21:
                        Clear_SinCardFields_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_SinCardFields_22:
                        Clear_SinCardFields_22 = true;
                        break;

                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }

    public struct SinCardField
    {
        public enum SinCardFieldDataType : byte
        {
            LocalizationId = 0, // 4 bytes
            Integer = 1, // 4 bytes
            EntityId = 2, // 8 bytes
            UnkType_3 = 3, // 8 bytes
            Enum = 4, // stringz
            UnkType_5 = 5, // ?
            Short = 6, // 2 bytes
            Timer = 7, // 9 bytes
            Boolean = 8, // 0 bytes???
        }

        public SinCardFieldDataType DataType;

        public uint LocalizationId;
        public uint Integer;
        public byte[] EntityId;
        public string Enum;
        public ushort Short;

        public byte[] UnkData;


        public SinCardField(Bitter.BinaryReader R)
        {
            // Sigh
            LocalizationId = 0;
            Integer = 0;
            EntityId = null;
            Enum = "";
            Short = 0;
            UnkData = null;

            // Parse
            DataType = (SinCardFieldDataType) R.Byte();

            switch (DataType)
            {
                case SinCardFieldDataType.LocalizationId:
                    LocalizationId = R.UInt();
                    break;
                case SinCardFieldDataType.Integer:
                    Integer = R.UInt();
                    break;
                case SinCardFieldDataType.EntityId:
                    EntityId = R.ByteArray(8);
                    break;
                case SinCardFieldDataType.Enum:
                    Enum = R.StringZ();
                    break;
                case SinCardFieldDataType.Short:
                    Short = R.UShort();
                    break;
                case SinCardFieldDataType.Timer:
                    UnkData = R.ByteArray(9);
                    break;
            }
        }

        public override string ToString()
        {
            string result = $"{DataType}: ";

            switch (DataType)
            {
                case SinCardFieldDataType.LocalizationId:
                    result += $"{LocalizationId}";
                    break;
                case SinCardFieldDataType.Integer:
                    result += $"{Integer}";
                    break;
                case SinCardFieldDataType.EntityId:
                    result += $"[{(EntityId != null ? String.Join(", ", EntityId) : "null")}]";
                    break;
                case SinCardFieldDataType.Enum:
                    result += $"{Enum}";
                    break;
                case SinCardFieldDataType.Short:
                    result += $"{Short}";
                    break;
                case SinCardFieldDataType.Timer:
                    result += $"[{(UnkData != null ? String.Join(", ", UnkData) : "null")}]";
                    break;
            }

            return result;
        } 
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
        
        public static string StringZ(this Bitter.BinaryReader rdr)
        {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            return ret;
        }

        public static SinCardField SinCardField(this Bitter.BinaryReader R)
        {
            return new SinCardField(R);
        }

        public static SinCardField[] SinCardFieldArray(this Bitter.BinaryReader R, int num)
        {
            List<SinCardField> list = new List<SinCardField>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.SinCardField());
            }
            return list.ToArray();
        }
    }
}