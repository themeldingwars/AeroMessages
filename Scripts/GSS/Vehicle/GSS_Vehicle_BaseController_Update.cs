using Bitter;
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

            Reset_PersonalFactionStance = 0x9e,
            Reset_SinFactionsAcquiredBy = 0xa8,
            Reset_SinTeamsAcquiredBy    = 0xa9,
            Reset_SinCardFields_0       = 0xab,
            Reset_SinCardFields_1       = 0xac,
            Reset_SinCardFields_2       = 0xad,
            Reset_SinCardFields_3       = 0xae,
            Reset_SinCardFields_4       = 0xaf,
            Reset_SinCardFields_5       = 0xb0,
            Reset_SinCardFields_6       = 0xb1,
            Reset_SinCardFields_7       = 0xb2,
            Reset_SinCardFields_8       = 0xb3,
            Reset_SinCardFields_9       = 0xb4,
            Reset_SinCardFields_10      = 0xb5,
            Reset_SinCardFields_11      = 0xb6,
            Reset_SinCardFields_12      = 0xb7,
            Reset_SinCardFields_13      = 0xb8,
            Reset_SinCardFields_14      = 0xb9,
            Reset_SinCardFields_15      = 0xba,
            Reset_SinCardFields_16      = 0xbb,
            Reset_SinCardFields_17      = 0xbc,
            Reset_SinCardFields_18      = 0xbd,
            Reset_SinCardFields_19      = 0xbe,
            Reset_SinCardFields_20      = 0xbf,
            Reset_SinCardFields_21      = 0xc0,
            Reset_SinCardFields_22      = 0xc1,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

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
        public byte[] ScopeBubbleInfo;
        public uint? ScalingLevel;

        public bool? Reset_PersonalFactionStance;
        public bool? Reset_SinFactionsAcquiredBy;
        public bool? Reset_SinTeamsAcquiredBy;
        public bool? Reset_SinCardFields_0;
        public bool? Reset_SinCardFields_1;
        public bool? Reset_SinCardFields_2;
        public bool? Reset_SinCardFields_3;
        public bool? Reset_SinCardFields_4;
        public bool? Reset_SinCardFields_5;
        public bool? Reset_SinCardFields_6;
        public bool? Reset_SinCardFields_7;
        public bool? Reset_SinCardFields_8;
        public bool? Reset_SinCardFields_9;
        public bool? Reset_SinCardFields_10;
        public bool? Reset_SinCardFields_11;
        public bool? Reset_SinCardFields_12;
        public bool? Reset_SinCardFields_13;
        public bool? Reset_SinCardFields_14;
        public bool? Reset_SinCardFields_15;
        public bool? Reset_SinCardFields_16;
        public bool? Reset_SinCardFields_17;
        public bool? Reset_SinCardFields_18;
        public bool? Reset_SinCardFields_19;
        public bool? Reset_SinCardFields_20;
        public bool? Reset_SinCardFields_21;
        public bool? Reset_SinCardFields_22;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

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
                        OwnerName = Stream.Read.StringZ(Stream);
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
                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;
                    case ShadowFieldIndex.ScalingLevel:
                        ScalingLevel = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Reset_PersonalFactionStance:
                        Reset_PersonalFactionStance = true;
                        break;
                    case ShadowFieldIndex.Reset_SinFactionsAcquiredBy:
                        Reset_SinFactionsAcquiredBy = true;
                        break;
                    case ShadowFieldIndex.Reset_SinTeamsAcquiredBy:
                        Reset_SinTeamsAcquiredBy = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_0:
                        Reset_SinCardFields_0 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_1:
                        Reset_SinCardFields_1 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_2:
                        Reset_SinCardFields_2 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_3:
                        Reset_SinCardFields_3 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_4:
                        Reset_SinCardFields_4 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_5:
                        Reset_SinCardFields_5 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_6:
                        Reset_SinCardFields_6 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_7:
                        Reset_SinCardFields_7 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_8:
                        Reset_SinCardFields_8 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_9:
                        Reset_SinCardFields_9 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_10:
                        Reset_SinCardFields_10 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_11:
                        Reset_SinCardFields_11 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_12:
                        Reset_SinCardFields_12 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_13:
                        Reset_SinCardFields_13 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_14:
                        Reset_SinCardFields_14 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_15:
                        Reset_SinCardFields_15 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_16:
                        Reset_SinCardFields_16 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_17:
                        Reset_SinCardFields_17 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_18:
                        Reset_SinCardFields_18 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_19:
                        Reset_SinCardFields_19 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_20:
                        Reset_SinCardFields_20 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_21:
                        Reset_SinCardFields_21 = true;
                        break;
                    case ShadowFieldIndex.Reset_SinCardFields_22:
                        Reset_SinCardFields_22 = true;
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

    public static class MyExtensions
    {
        public static string StringZ(this Bitter.BinaryReader rdr, Bitter.BinaryStream stream) {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (stream.baseStream.ByteOffset < stream.baseStream.Length);
            return ret;
        }

    }
}