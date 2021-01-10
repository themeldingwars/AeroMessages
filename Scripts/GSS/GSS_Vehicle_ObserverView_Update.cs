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
            ScalingLevel          = 0x3e,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield


        public byte[] Flags;
        public byte? EngineState;
        public byte? PathState;
        public byte[] OccupantIds_0; // 0x08
        public byte[] OccupantIds_1; // 0x09
        public byte[] OccupantIds_2; // 0x0a
        public byte[] OccupantIds_3; // 0x0b
        public byte[] OccupantIds_4; // 0x0c
        public byte[] OccupantIds_5; // 0x0d
        public byte? SnapMount; 
        public byte[] ProcessDelay;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        public uint? CurrentHealth;
        public byte[] MaxHealth;
        public byte? WaterLevelAndDesc;
        public byte? EffectsFlags; 
        public byte[] ScalingLevel;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Flags:
                        Flags = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.EngineState:
                        EngineState = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.PathState:
                        PathState = Stream.Read.Byte();
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
                    case ShadowFieldIndex.SnapMount:
                        SnapMount = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay = Stream.Read.ByteArray(4);
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
                        MaxHealth = Stream.Read.ByteArray(4);
                        break;
                    case ShadowFieldIndex.WaterLevelAndDesc:
                        WaterLevelAndDesc = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.EffectsFlags:
                        EffectsFlags = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.ScalingLevel:
                        ScalingLevel = Stream.Read.ByteArray(4);
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