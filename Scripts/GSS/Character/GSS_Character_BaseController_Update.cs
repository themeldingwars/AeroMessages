using Bitter;
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
            SinTeamsAqquiredBy      = 0x20,
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
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

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
        public uint? GibVisualsID_1;
        public uint? GibVisualsID_Time;
        public byte[] SpawnPose;
        public uint? ProcessDelay;
        public byte? CharacterState;
        public uint? CharacterState_Time;
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
        public uint? EnergyParams_Unk;
        public float? EnergyParams_RechargeRelated;
        public uint? EnergyParams_Time;
        public byte[] CharacterStats;
        public ulong? ArmyGUID;
        
        public byte? ArmyIsOfficer;

        public byte[] ZoneUnlocks;
        public byte[] RegionUnlocks;
        public byte[] ScopeBubbleInfo;
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
        public byte[] Wallet;

        public byte? Level;
        public byte? EffectiveLevel;

        public uint PerkRespecs;
        public ushort FriendCount;
        public byte[] CAISStatus;
        public byte[] ScalingLevel;
        public uint PvPRank;
        public uint PvPRankPoints;
        public uint PvPTokens;
        public uint BountyPointsLastClaimed;
        public uint EliteLevel;

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
                        GibVisualsID_1 = Stream.Read.UInt();
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
                        EnergyParams_Unk = Stream.Read.UInt(); // Not sure
                        EnergyParams_RechargeRelated = Stream.Read.Float();
                        EnergyParams_Time = Stream.Read.UInt();
                        break;

                    //case ShadowFieldIndex.CharacterStats:
                    //    CharacterStats = ; // Variable length needs indepth parsing
                    //    break;

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
                        ScopeBubbleInfo = Stream.Read.ByteArray(9);
                        break;

                    case ShadowFieldIndex.ProgressionXp:
                        ProgressionXp = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.PermanentStatusEffects:
                        let pse_count = Stream.Read.Byte();
                        PermanentStatusEffects = Stream.Read.ByteArray(pse_count * (4+4+8));
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
                        Wallet = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Level:
                        Level = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.EffectiveLevel:
                        EffectiveLevel = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.PerkRespecs:
                        PerkRespecs = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.FriendCount:
                        FriendCount = Stream.Read.UShort();
                        break;

                    case ShadowFieldIndex.CAISStatus:
                        CAISStatus = Stream.Read.ByteArray(5);
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

                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }
}