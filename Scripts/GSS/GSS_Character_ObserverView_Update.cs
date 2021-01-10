using Bitter;
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

            // These actions may not actually be shadowfields but some other form of events?
            DismountVehicle         = 0x8B, // Maybe this is a special key with no params, and then 0x0C is used to dismount?
            Unk_Special_0x99        = 0x99, // No value
        }

        public string UnableToParseWarning; // Will be set if we enocunter an unhandled shadowfield

        public byte? StaticInfo_1;
        public uint? StaticInfo_Time1;
        public uint? StaticInfo_Time2;

        public byte? EffectsFlags;

        public uint? GibVisualsID_Id;
        public uint? GibVisualsID_Time;

        public ushort? ProcessDelay_ShortTime; 
        public byte[] ProcessDelay_2;


        public byte? CharacterState;
        public uint? CharacterState_Time;
        public byte[] HostilityInfo;
        public byte[] PersonalFactionStance;
        public byte? CurrentHealthPct;
        public uint? MaxHealth; // assumption
        public ushort? EmoteID_EmoteId; // Sdb table 73, id column
        public uint? EmoteID_Time;

        public byte[] AttachedTo;


        public byte? WaterLevelAndDesc;
        public uint? RespawnTimes_Time1;
        public uint? RespawnTimes_Time2;


        public byte[] DismountedVehicle;
        public bool? Unk_Special_0x99;

        public byte[] UnableToParse;
       

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
 
                    case ShadowFieldIndex.StaticInfo:
                        StaticInfo_1 = Stream.Read.Byte();
                        StaticInfo_Time1 = Stream.Read.UInt();
                        StaticInfo_Time2 = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.EffectsFlags:
                        EffectsFlags = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.GibVisualsID:
                        GibVisualsID_Id = Stream.Read.UInt();
                        GibVisualsID_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.ProcessDelay:
                        ProcessDelay_ShortTime = Stream.Read.UShort();
                        ProcessDelay_2 = Stream.Read.ByteArray(2);
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
                        break;

                    case ShadowFieldIndex.EmoteID:
                        EmoteID_EmoteId = Stream.Read.UShort();
                        EmoteID_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.AttachedTo:
                        AttachedTo = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.WaterLevelAndDesc:
                        WaterLevelAndDesc = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.RespawnTimes:
                        RespawnTimes_Time1 = Stream.Read.UInt();
                        RespawnTimes_Time2 = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.DismountVehicle:
                        DismountedVehicle = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_Special_0x99:
                        // No value
                        Unk_Special_0x99 = true;
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