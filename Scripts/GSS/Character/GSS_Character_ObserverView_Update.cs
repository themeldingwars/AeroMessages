using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 8, 1, true)]
    public class CharacterObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            StaticInfo              = 0x00,
            SpawnTime               = 0x01,
            EffectsFlags            = 0x02, // aka flashlight
            GibVisualsID            = 0x03,
            ProcessDelay            = 0x04, // Equivalent of 0x0d on base controller
            CharacterState          = 0x05,
            HostilityInfo           = 0x06, // Not sure about the parsing 
            PersonalFactionStance   = 0x07, // Not sure about the parsing 
            CurrentHealthPct        = 0x08, // % integer
            MaxHealth               = 0x09,
            EmoteID                 = 0x0A,
            AttachedTo              = 0x0B, // used when the character is mounted to a vehicle
            SnapMount               = 0x0C,
            SinFlags                = 0x0D,
            SinFactionsAcquiredBy   = 0x0E,
            SinTeamsAcquiredBy      = 0x0F,
            ArmyGUID                = 0x10,
            OwnerId                 = 0x11,
            NPCType                 = 0x12,
            DockedParams            = 0x13,
            LookAtTarget            = 0x14,
            WaterLevelAndDesc       = 0x15,
            CarryableObjects_0      = 0x16,
            CarryableObjects_1      = 0x17,
            CarryableObjects_2      = 0x18,
            RespawnTimes            = 0x19,
            SinCardType             = 0x1a,
            SinCardFields_0         = 0x1b,
            SinCardFields_1         = 0x1c,
            SinCardFields_2         = 0x1d,
            SinCardFields_3         = 0x1e,
            SinCardFields_4         = 0x1f,
            SinCardFields_5         = 0x20,
            SinCardFields_6         = 0x21,
            SinCardFields_7         = 0x22,
            SinCardFields_8         = 0x23,
            SinCardFields_9         = 0x24,
            SinCardFields_10        = 0x25,
            SinCardFields_11        = 0x26,
            SinCardFields_12        = 0x27,
            SinCardFields_13        = 0x28,
            SinCardFields_14        = 0x29,
            SinCardFields_15        = 0x2a,
            SinCardFields_16        = 0x2b,
            SinCardFields_17        = 0x2c,
            SinCardFields_18        = 0x2d,
            SinCardFields_19        = 0x2e,
            SinCardFields_20        = 0x2f,
            SinCardFields_21        = 0x30,
            SinCardFields_22        = 0x31,
            AssetOverrides          = 0x32,

            // These are not named by the client
            Clear_PersonalFactionStance = 0x87, // Guess
            Clear_AttachedTo            = 0x8b, // Confirmed
            Clear_SinFactionsAcquiredBy = 0x8e, // Guess
            Clear_SinTeamsAcquiredBy    = 0x8f, // Guess
            Clear_LookAtTarget          = 0x94, // Confirmed
            Clear_CarryableObjects_0    = 0x96, // Guess
            Clear_CarryableObjects_1    = 0x97, // Guess
            Clear_CarryableObjects_2    = 0x98, // Guess
            Clear_RespawnTimes          = 0x99, // Guess
            Clear_SinCardFields_0       = 0x9b, // Guess
            Clear_SinCardFields_1       = 0x9c, // Guess
            Clear_SinCardFields_2       = 0x9d, // Guess
            Clear_SinCardFields_3       = 0x9e, // Guess
            Clear_SinCardFields_4       = 0x9f, // Guess
            Clear_SinCardFields_5       = 0xa0, // Guess
            Clear_SinCardFields_6       = 0xa1, // Guess
            Clear_SinCardFields_7       = 0xa2, // Guess
            Clear_SinCardFields_8       = 0xa3, // Guess
            Clear_SinCardFields_9       = 0xa4, // Guess
            Clear_SinCardFields_10      = 0xa5, // Guess
            Clear_SinCardFields_11      = 0xa6, // Guess
            Clear_SinCardFields_12      = 0xa7, // Guess
            Clear_SinCardFields_13      = 0xa8, // Guess
            Clear_SinCardFields_14      = 0xa9, // Guess
            Clear_SinCardFields_15      = 0xaa, // Guess
            Clear_SinCardFields_16      = 0xab, // Guess
            Clear_SinCardFields_17      = 0xac, // Guess
            Clear_SinCardFields_18      = 0xad, // Guess
            Clear_SinCardFields_19      = 0xae, // Guess
            Clear_SinCardFields_20      = 0xaf, // Guess
            Clear_SinCardFields_21      = 0xb0, // Guess
            Clear_SinCardFields_22      = 0xb1, // Guess
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public string StaticInfo;

        public byte? EffectsFlags;
        public uint? GibVisualsID;
        public uint? GibVisualsID_Time;
        public uint? ProcessDelay; 
        public byte? CharacterState;
        public uint? CharacterState_Time;
        public byte[] HostilityInfo;

        public byte[] PersonalFactionStance;

        public byte? CurrentHealthPct;
        public uint? MaxHealth;
        public uint? MaxHealth_Time;
        public ushort? EmoteID; // Sdb table 73, id column
        public uint? EmoteID_Time;

        public string AttachedTo_VehicleEntity1;
        public string AttachedTo_VehicleEntity2;
        public byte[] AttachedTo_Bytes;

        public byte? SnapMount;
        public byte? SinFlags; // guess

        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;

        public ulong? ArmyGUID;
        public ulong? OwnerId;
        public uint? NPCType; // guess
        public byte[] DockedParams; // guess

        public string LookAtTarget_TargetId;
        public float[] LookAtTarget_Position;
        public byte[] LookAtTarget_UnkBytes;

        public byte? WaterLevelAndDesc;

        // TODO: CarryableObjects

        public uint? RespawnTimes_Time1;
        public uint? RespawnTimes_Time2;

        public uint? SinCardType;

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

        public byte? AssetOverrides;

        public bool? Clear_PersonalFactionStance;
        public bool? Clear_AttachedTo;
        public bool? Clear_SinFactionsAcquiredBy;
        public bool? Clear_SinTeamsAcquiredBy;
        public bool? Clear_LookAtTarget;
        public bool? Clear_CarryableObjects_0;
        public bool? Clear_CarryableObjects_1;
        public bool? Clear_CarryableObjects_2;
        public bool? Clear_RespawnTimes;
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
            MyExtensions.Stream = Stream;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
 
                    case ShadowFieldIndex.StaticInfo:
                        // Unfinished
                        long startOffset = Stream.baseStream.ByteOffset;
                        Stream.Read.StringZ();
                        Stream.Read.StringZ();
                        Stream.Read.Byte();
                        Stream.Read.Byte();
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.Byte();
                        Stream.Read.Byte();
                        Stream.Read.Byte();
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.UShort();
                        Stream.Read.UInt();
                        byte numberOfHeadAccessories = Stream.Read.Byte();
                        Stream.Read.UIntArray(numberOfHeadAccessories);
                        Stream.Read.UInt();
                        Stream.Read.UInt();
                        Stream.Read.ByteArray(3);

                        long endOffset = Stream.baseStream.ByteOffset;
                        Stream.baseStream.ByteOffset = startOffset;
                        int length = (int)(endOffset-startOffset);
                        StaticInfo = Stream.Read.String(length);

                        break;

                    case ShadowFieldIndex.EffectsFlags:
                        EffectsFlags = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.GibVisualsID:
                        GibVisualsID = Stream.Read.UInt();
                        GibVisualsID_Time = Stream.Read.UInt();
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
                        PersonalFactionStance = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.CurrentHealthPct:
                        CurrentHealthPct = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.MaxHealth:
                        MaxHealth = Stream.Read.UInt();
                        MaxHealth_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.EmoteID:
                        EmoteID = Stream.Read.UShort();
                        EmoteID_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.AttachedTo:
                        AttachedTo_VehicleEntity1 = Stream.Read.
                        Entity();
                        AttachedTo_VehicleEntity2 = Stream.Read.
                        Entity();
                        AttachedTo_Bytes = Stream.Read.ByteArray(3);
                        break;

                    case ShadowFieldIndex.SnapMount:
                        SnapMount = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.SinFlags:
                        SinFlags = Stream.Read.Byte();
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

                    case ShadowFieldIndex.OwnerId:
                        OwnerId = Stream.Read.ULong();
                        break;

                    case ShadowFieldIndex.NPCType:
                        NPCType = Stream.Read.UInt(); // guess
                        break;

                    case ShadowFieldIndex.DockedParams:
                        DockedParams = Stream.Read.ByteArray(19); // guess
                        break;

                    case ShadowFieldIndex.LookAtTarget:
                        LookAtTarget_TargetId = Stream.Read.Entity();
                        LookAtTarget_Position = Stream.Read.FloatArray(3);
                        LookAtTarget_UnkBytes = Stream.Read.ByteArray(4);
                        break;

                    case ShadowFieldIndex.WaterLevelAndDesc:
                        WaterLevelAndDesc = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.RespawnTimes:
                        RespawnTimes_Time1 = Stream.Read.UInt();
                        RespawnTimes_Time2 = Stream.Read.UInt();
                        break;

                    // TODO: CarryableObjects

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

                    case ShadowFieldIndex.AssetOverrides:
                        AssetOverrides = Stream.Read.Byte(); // probably more if we have content
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

                    case ShadowFieldIndex.Clear_SinTeamsAcquiredBy:
                        Clear_SinTeamsAcquiredBy = true;
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

                    case ShadowFieldIndex.Clear_RespawnTimes:
                        Clear_RespawnTimes = true;
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
        public string EntityId;
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
                    EntityId = R.Entity();
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
                    result += $"{EntityId}";
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
            
        public enum Controller : byte
        {
            Generic = 0x00,
            Character = 0x01,
            Melding = 0x0f,
            MeldingBubble = 0x11,
            AreaVisualData = 0x13,
            Vehicle = 0x1a,
            Anchor = 0x20,
            Deployable = 0x22,
            Turret = 0x26,
            TinyObjectType = 0x29,
            CharacterAbilityPhysics = 0x2a,
            ProjectileObjectType = 0x2b,
            Outpost = 0x2c,
            ResourceArea = 0x2e,
            ResourceNode = 0x2f,
            Encounter = 0x31,
            Carryable = 0x32,
            LootStoreExtension = 0x34,
            TeamManager = 0x36,
        }

        public static string Entity(this Bitter.BinaryReader rdr)
        {
            Controller controller;
            ulong id;

            controller = (Controller) rdr.Byte();
            Stream.baseStream.ByteOffset--;
            id = rdr.ULong() & 0xFFFFFFFFFFFFFF00;

            if (controller == 0 && id == 0) return "None";
            return $"{controller}:{id}";
        }

        public static string[] EntityArray(this Bitter.BinaryReader R, int num)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.Entity());
            }
            return list.ToArray();
        }

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