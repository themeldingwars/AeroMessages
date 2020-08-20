using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 8, 1, true)]
    public class CharacterObserverViewUpdate : BaseScript
    {
        // Take anything that is Unk with a huge grain of salt.
        enum ShadowFieldIndex : byte
        {
            Unk_0x00                = 0x00,
            Unk_0x01                = 0x01,
            EffectsFlag             = 0x02, // aka flashlight
            Unk_0x03                = 0x03,
            Unk_0x04                = 0x04, // Equivalent of 0x0d on base controller
            CharacterState          = 0x05,
            Faction                 = 0x06,
            CurrentHealthPercent    = 0x08, // % integer
            PerformEmote            = 0x0A,
            MountVehicle            = 0x0B,
            Unk_0x15                = 0x15,
            Unk_0x19                = 0x19,
            DismountVehicle         = 0x8B,

            Unk_Special_0x99        = 0x99, // No value
        }

        public byte? Unk_0x00_1;
        public uint? Unk_0x00_Time1;
        public uint? Unk_0x00_Time2;

        public byte? EffectsFlag;

        public byte[] Unk_0x03_Unk;
        public uint? Unk_0x03_Time;

        public ushort? Unk_0x04_ShortTime; 
        public byte[] Unk_0x04_2;


        public byte? CharacterState;
        public uint? CharacterState_Time;
        public byte[] Faction;
        public byte? CurrentHealthPercent;
        public ushort? PerformEmote_EmoteId; // Sdb table 73, id column
        public uint? PerformEmote_Time;
        public byte[] MountedVehicle;
        public byte? Unk_0x15;
        public uint? Unk_0x19_Time1;
        public uint? Unk_0x19_Time2;
        public byte[] DismountedVehicle;

        public bool? Unk_Special_0x99;

        public byte[] UnableToParse;


        /*
        public byte[] Unk1;
        public string DisplayName;
        public string UniqueName;
        public byte Gender;
        public byte Race;
        public uint CharInfoId; // Sdb table 240
        public uint Head;
        public uint Eyes;
        public byte Unk2;
        public byte IsNpc;
        public byte StaffFlags;
        public uint CharacterTypeId; // Sdb table 280
        public uint Voice;
        public ushort TitleId;
        public uint NameLocalizationId; // Sdb table 31
        public uint[] HeadAccessories;
        public uint Vehicle;
        public uint Glider;
        // Character Visuals
        public byte[] Unk3;
        public uint[] WarpaintColors; // Skin/Hair colors here
        public byte[] WarpaintPalettes_Data; // 1 byte type, 4 byte id
        public byte[] WarpaintPatterns_Data; // 4 byte id, 4*2 byte transform (halfs), 1 byte "usage"
        public uint[] Ornaments;
        public byte[] Unk4;
        // --
        public string ArmyTag;

        // Beyond here it will not match well for NPCs
        // This section needs some work, too many varied length unks
        public uint Time1;
        public byte[] Unk5;
        public uint Time2;
        public byte[] Unk6;
        public byte CharacterState;
        public uint Time3;
        public byte[] Faction; // Left Byte is Mode: 1 = Factions, 2 = Teams. Right byte is the Faction or Team Id respectively.
        public byte[] Unk7;

        public byte[] Unk9;
        public byte HealthPercent;
        public uint HealthMax;
        public uint Time4;
        public byte[] Unk10;
        public byte[] Mounted_Unk_VehicleEntity1; // Couldnt get this to actually work in the client
        public byte[] Mounted_Unk_VehicleEntity2;
        public byte[] Mounted_Unk_Bytes;
        public byte[] Unk11;
        public ulong ArmyGUID;
        */
       

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
 
                    case ShadowFieldIndex.Unk_0x00:
                        Unk_0x00_1 = Stream.Read.Byte();
                        Unk_0x00_Time1 = Stream.Read.UInt();
                        Unk_0x00_Time2 = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.EffectsFlag:
                        EffectsFlag = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.Unk_0x03:
                        Unk_0x03_Unk = Stream.Read.ByteArray(4);
                        Unk_0x03_Time = Stream.Read.UInt();
                        break;


                    case ShadowFieldIndex.Unk_0x04:
                        Unk_0x04_ShortTime = Stream.Read.UShort();
                        Unk_0x04_2 = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.CharacterState:
                        CharacterState = Stream.Read.Byte();
                        CharacterState_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Faction:
                        Faction = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.CurrentHealthPercent:
                        CurrentHealthPercent = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.PerformEmote:
                        PerformEmote_EmoteId = Stream.Read.UShort();
                        PerformEmote_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.MountVehicle:
                        MountedVehicle = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Unk_0x15:
                        Unk_0x15 = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.Unk_0x19:
                        Unk_0x19_Time1 = Stream.Read.UInt();
                        Unk_0x19_Time2 = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.DismountVehicle:
                        DismountedVehicle = Stream.Read.ByteArray(2);
                        break;

                    case ShadowFieldIndex.Unk_Special_0x99:
                        // No value
                        Unk_Special_0x99 = true;
                        break;

                    default:
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
        }
    }
}