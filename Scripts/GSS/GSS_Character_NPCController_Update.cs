using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 3, 1, true)]
    public class CharacterNPCControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
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
            NPCRouteInfo                = 0x72,
            Behavior                    = 0x73,
            OwnerId                     = 0x74,
            NPCType                     = 0x75,
            Gravity                     = 0x76,
            SpawnSource                 = 0x77,
            NPCVolumes_0                = 0x78,
            NPCVolumes_1                = 0x79,
            CurrentEnergyPct            = 0x7a,
            GroupLeashParams            = 0x7b,
            NpcFlags                    = 0x7c,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
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