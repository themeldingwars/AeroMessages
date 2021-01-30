using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 29, 1, true)]
    public class VehicleObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            VehicleType           = 0x00,
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
            SnapMount             = 0x18, // Not effect flags
            ProcessDelay          = 0x19,
            HostilityInfo         = 0x1a, // Faction
            PersonalFactionStance = 0x1b, // 20 bytes of idk
            CurrentHealth         = 0x1c,
            MaxHealth             = 0x1d,
            CurrentShields        = 0x1e,
            MaxShields            = 0x1f,
            SinFlags              = 0x20,
            SinFactionsAcquiredBy = 0x21,
            SinTeamsAcquiredBy    = 0x22,
            WaterLevelAndDesc     = 0x23,
            EffectsFlags          = 0x24,
            SinCardType           = 0x25,
            SinCardFields_0       = 0x26,
            SinCardFields_1       = 0x27,
            SinCardFields_2       = 0x28,
            SinCardFields_3       = 0x29,
            SinCardFields_4       = 0x2a,
            SinCardFields_5       = 0x2b,
            SinCardFields_6       = 0x2c,
            SinCardFields_7       = 0x2d,
            SinCardFields_8       = 0x2e,
            SinCardFields_9       = 0x2f,
            SinCardFields_10      = 0x30,
            SinCardFields_11      = 0x31,
            SinCardFields_12      = 0x32,
            SinCardFields_13      = 0x33,
            SinCardFields_14      = 0x34,
            SinCardFields_15      = 0x35,
            SinCardFields_16      = 0x36,
            SinCardFields_17      = 0x37,
            SinCardFields_18      = 0x38,
            SinCardFields_19      = 0x39,
            SinCardFields_20      = 0x3a,
            SinCardFields_21      = 0x3b,
            SinCardFields_22      = 0x3c,
            ScopeBubbleInfo       = 0x3d,
            ScalingLevel          = 0x3e,

            Reset_PersonalFactionStance = 0x9b,
            Reset_SinFactionsAcquiredBy = 0xa1,
            Reset_SinTeamsAcquiredBy    = 0xa2,
            Reset_SinCardFields_0  = 0xa6,
            Reset_SinCardFields_1  = 0xa7,
            Reset_SinCardFields_2  = 0xa8,
            Reset_SinCardFields_3  = 0xa9,
            Reset_SinCardFields_4  = 0xaa,
            Reset_SinCardFields_5  = 0xab,
            Reset_SinCardFields_6  = 0xac,
            Reset_SinCardFields_7  = 0xad,
            Reset_SinCardFields_8  = 0xae,
            Reset_SinCardFields_9  = 0xaf,
            Reset_SinCardFields_10 = 0xb0,
            Reset_SinCardFields_11 = 0xb1,
            Reset_SinCardFields_12 = 0xb2,
            Reset_SinCardFields_13 = 0xb3,
            Reset_SinCardFields_14 = 0xb4,
            Reset_SinCardFields_15 = 0xb5,
            Reset_SinCardFields_16 = 0xb6,
            Reset_SinCardFields_17 = 0xb7,
            Reset_SinCardFields_18 = 0xb8,
            Reset_SinCardFields_19 = 0xb9,
            Reset_SinCardFields_20 = 0xba,
            Reset_SinCardFields_21 = 0xbb,
            Reset_SinCardFields_22 = 0xbc,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield


        public ushort? VehicleType; // 0x00, Sdb table 47, id column.
        public byte[] Configuration;
        public byte[] Flags;
        public byte? EngineState; // 0x03, 0 - off, 1 - ignition, 2 - drivable
        public byte? PathState;
        public byte[] OwnerId; // 0x05
        public string OwnerName;
        public uint? OwnerLocalString;
        public byte[] OccupantIds_0; // 0x08
        public byte[] OccupantIds_1; // 0x09
        public byte[] OccupantIds_2; // 0x0a
        public byte[] OccupantIds_3; // 0x0b
        public byte[] OccupantIds_4; // 0x0c
        public byte[] OccupantIds_5; // 0x0d
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
        public uint? ProcessDelay;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        public uint? CurrentHealth;
        public uint? MaxHealth;
        public uint? CurrentShields;
        public uint? MaxShields;
        public byte? SinFlags;
        public byte? SinFlagsPrivate;
        public byte[] SinFactionsAcquiredBy;
        public byte[] SinTeamsAcquiredBy;
        public byte? WaterLevelAndDesc;
        public byte? EffectsFlags;
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
            MyExtensions.Stream = Stream;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.VehicleType:
                        VehicleType = Stream.Read.UShort();
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
                    case ShadowFieldIndex.SinFlags:
                        SinFlags = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.SinFactionsAcquiredBy:
                        SinFactionsAcquiredBy = Stream.Read.ByteArray(2);
                        break;
                    case ShadowFieldIndex.SinTeamsAcquiredBy:
                        SinTeamsAcquiredBy = Stream.Read.ByteArray(2);
                        break;
                    case ShadowFieldIndex.WaterLevelAndDesc:
                        WaterLevelAndDesc = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.EffectsFlags:
                        EffectsFlags = Stream.Read.Byte();
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
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
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

    }
}