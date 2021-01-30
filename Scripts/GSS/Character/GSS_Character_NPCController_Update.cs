using Bitter;
using System;
using System.Collections.Generic;
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

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

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

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
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