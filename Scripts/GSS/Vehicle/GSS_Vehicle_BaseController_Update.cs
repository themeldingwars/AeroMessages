using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 27, 1, true)]
    public class VehicleBaseControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {   
            VehicleId             = 0x00,
            Configuration         = 0x01,
            Flags                 = 0x02,
            EngineState           = 0x03, // VehicleEnabled
            PathState             = 0x04,
            OwnerId               = 0x05,
            OwnerName             = 0x06,
            OwnerLocalString      = 0x07,
            OccupantIds_0         = 0x08,
            OccupantIds_1         = 0x09,
            OccupantIds_2         = 0x0a,
            OccupantIds_3         = 0x0b,
            OccupantIds_4         = 0x0c,
            OccupantIds_5         = 0x0d,
            DeployableIds_0       = 0x0e,
            DeployableIds_1       = 0x0f,
            DeployableIds_2       = 0x10,
            DeployableIds_3       = 0x11,
            DeployableIds_4       = 0x12,
            DeployableIds_5       = 0x13,
            DeployableIds_6       = 0x14,
            DeployableIds_7       = 0x15,
            DeployableIds_8       = 0x16,
            DeployableIds_9       = 0x17,
            SnapMount             = 0x18,
            SpawnPose             = 0x19,
            SpawnVelocity         = 0x1a,
            CurrentPose           = 0x1b, // MovementInput
            ProcessDelay          = 0x1c,
            HostilityInfo         = 0x1d,
            PersonalFactionStance = 0x1e,
            CurrentHealth         = 0x1f,
            MaxHealth             = 0x20,
            CurrentShields        = 0x21,
            MaxShields            = 0x22,
            CurrentResources      = 0x23,
            MaxResources          = 0x24,
            WaterLevelAndDesc     = 0x25,
            SinFlags              = 0x26,
            SinFlagsPrivate       = 0x27,
            SinFactionsAcquiredBy = 0x28,
            SinTeamsAcquiredBy    = 0x29,
            SinCardType           = 0x2a,
            SinCardFields_0       = 0x2b,
            SinCardFields_1       = 0x2c,
            SinCardFields_2       = 0x2d,
            SinCardFields_3       = 0x2e,
            SinCardFields_4       = 0x2f,
            SinCardFields_5       = 0x30,
            SinCardFields_6       = 0x31,
            SinCardFields_7       = 0x32,
            SinCardFields_8       = 0x33,
            SinCardFields_9       = 0x34,
            SinCardFields_10      = 0x35,
            SinCardFields_11      = 0x36,
            SinCardFields_12      = 0x37,
            SinCardFields_13      = 0x38,
            SinCardFields_14      = 0x39,
            SinCardFields_15      = 0x3a,
            SinCardFields_16      = 0x3b,
            SinCardFields_17      = 0x3c,
            SinCardFields_18      = 0x3d,
            SinCardFields_19      = 0x3e,
            SinCardFields_20      = 0x3f,
            SinCardFields_21      = 0x40,
            SinCardFields_22      = 0x41,
            ScopeBubbleInfo       = 0x42,
            ScalingLevel          = 0x43,

            Clear_PersonalFactionStance = 0x9e,
            Clear_SinFactionsAcquiredBy = 0xa8,
            Clear_SinTeamsAcquiredBy    = 0xa9,
            Clear_SinCardFields_0       = 0xab,
            Clear_SinCardFields_1       = 0xac,
            Clear_SinCardFields_2       = 0xad,
            Clear_SinCardFields_3       = 0xae,
            Clear_SinCardFields_4       = 0xaf,
            Clear_SinCardFields_5       = 0xb0,
            Clear_SinCardFields_6       = 0xb1,
            Clear_SinCardFields_7       = 0xb2,
            Clear_SinCardFields_8       = 0xb3,
            Clear_SinCardFields_9       = 0xb4,
            Clear_SinCardFields_10      = 0xb5,
            Clear_SinCardFields_11      = 0xb6,
            Clear_SinCardFields_12      = 0xb7,
            Clear_SinCardFields_13      = 0xb8,
            Clear_SinCardFields_14      = 0xb9,
            Clear_SinCardFields_15      = 0xba,
            Clear_SinCardFields_16      = 0xbb,
            Clear_SinCardFields_17      = 0xbc,
            Clear_SinCardFields_18      = 0xbd,
            Clear_SinCardFields_19      = 0xbe,
            Clear_SinCardFields_20      = 0xbf,
            Clear_SinCardFields_21      = 0xc0,
            Clear_SinCardFields_22      = 0xc1,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public ushort? VehicleId;
        public byte[] Configuration;
        public byte[] Flags;
        public byte? EngineState;
        public byte? PathState;
        public byte[] OwnerId;
        public string OwnerName;
        public uint? OwnerLocalString;
        public byte[] OccupantIds_0;
        public byte[] OccupantIds_1;
        public byte[] OccupantIds_2;
        public byte[] OccupantIds_3;
        public byte[] OccupantIds_4;
        public byte[] OccupantIds_5;
        public byte[] DeployableIds_0;
        public byte[] DeployableIds_1;
        public byte[] DeployableIds_2;
        public byte[] DeployableIds_3;
        public byte[] DeployableIds_4;
        public byte[] DeployableIds_5;
        public byte[] DeployableIds_6;
        public byte[] DeployableIds_7;
        public byte[] DeployableIds_8;
        public byte[] DeployableIds_9;
        public byte? SnapMount;
        public float[] SpawnPose_Position; // 0x19
        public float[] SpawnPose_Rotation; // 0x19
        public float[] SpawnPose_Direction; // 0x19
        public uint? SpawnPose_Time; // 0x19
        public float[] SpawnVelocity;
        public float[] CurrentPose_Position; // 0x1B
        public float[] CurrentPose_Rotation; // 0x1B
        public float[] CurrentPose_Direction; // 0x1B
        public ushort? CurrentPose_State; // 0x1B
        public uint? CurrentPose_Time; // 0x1B
        public uint? ProcessDelay;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        public uint? CurrentHealth;
        public uint? MaxHealth;
        public uint? CurrentShields;
        public uint? MaxShields;
        public uint? CurrentResources;
        public uint? MaxResources;
        public byte? WaterLevelAndDesc;
        public byte? SinFlags;
        public byte? SinFlagsPrivate;
        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;
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
        public byte[] ScopeBubbleInfo;
        public uint? ScalingLevel;

        public bool? Clear_PersonalFactionStance;
        public bool? Clear_SinFactionsAcquiredBy;
        public bool? Clear_SinTeamsAcquiredBy;
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
                    case ShadowFieldIndex.VehicleId:
                        VehicleId = Stream.Read.UShort();
                        break;
                    case ShadowFieldIndex.Configuration:
                        Configuration = Stream.Read.ByteArray(32);
                        break;
                    case ShadowFieldIndex.Flags:
                        Flags = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.EngineState:
                        EngineState = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.PathState:
                        PathState = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.OwnerId:
                        OwnerId = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.OwnerName:
                        OwnerName = Stream.Read.StringZ();
                        break;
                    case ShadowFieldIndex.OwnerLocalString:
                        OwnerLocalString = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.OccupantIds_0:
                        OccupantIds_0 = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.OccupantIds_1:
                        OccupantIds_1 = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.OccupantIds_2:
                        OccupantIds_2 = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.OccupantIds_3:
                        OccupantIds_3 = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.OccupantIds_4:
                        OccupantIds_4 = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.OccupantIds_5:
                        OccupantIds_5 = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.DeployableIds_0:
                        DeployableIds_0 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_1:
                        DeployableIds_1 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_2:
                        DeployableIds_2 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_3:
                        DeployableIds_3 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_4:
                        DeployableIds_4 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_5:
                        DeployableIds_5 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_6:
                        DeployableIds_6 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_7:
                        DeployableIds_7 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_8:
                        DeployableIds_8 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.DeployableIds_9:
                        DeployableIds_9 = Stream.Read.ByteArray(13);
                        break;
                    case ShadowFieldIndex.SnapMount:
                        SnapMount = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.SpawnPose:
                        SpawnPose_Position = Stream.Read.FloatArray(3);
                        SpawnPose_Rotation = Stream.Read.FloatArray(4);
                        SpawnPose_Direction = Stream.Read.FloatArray(3);
                        SpawnPose_Time = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.SpawnVelocity:
                        SpawnVelocity = Stream.Read.FloatArray(3);
                        break;
                    case ShadowFieldIndex.CurrentPose: // MovementInput
                        CurrentPose_Position = Stream.Read.FloatArray(3);
                        CurrentPose_Rotation = Stream.Read.FloatArray(4);
                        CurrentPose_Direction = Stream.Read.FloatArray(3);
                        CurrentPose_State = Stream.Read.UShort();
                        CurrentPose_Time = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay = Stream.Read.UInt();
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
                    case ShadowFieldIndex.MaxHealth:
                        MaxHealth = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.CurrentShields:
                        CurrentShields = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.MaxShields:
                        MaxShields = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.CurrentResources:
                        CurrentResources = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.MaxResources:
                        MaxResources = Stream.Read.UInt();
                        break;
                    case ShadowFieldIndex.WaterLevelAndDesc:
                        WaterLevelAndDesc = Stream.Read.Byte();
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
                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.ScalingLevel:
                        ScalingLevel = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Clear_PersonalFactionStance:
                        Clear_PersonalFactionStance = true;
                        break;
                    case ShadowFieldIndex.Clear_SinFactionsAcquiredBy:
                        Clear_SinFactionsAcquiredBy = true;
                        break;
                    case ShadowFieldIndex.Clear_SinTeamsAcquiredBy:
                        Clear_SinTeamsAcquiredBy = true;
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