using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 8, 3, true)]
    public class CharacterObserverViewKeyframe : BaseScript
    {
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
        public byte EffectsFlag;
        public byte[] Unk5;
        public uint Time2;
        public byte[] Unk6;
        public byte CharacterState;
        public uint CharacterStateTime;
        public byte[] Faction; // Left Byte is Mode: 1 = Factions, 2 = Teams. Right byte is the Faction or Team Id respectively.
        public byte[] Unk7;

        public byte[] Unk9;
        public byte HealthPercent;
        public uint HealthMax;
        public uint HealthTime;
        public ushort EmoteId; // Sdb table 73, id column
        public uint EmoteTime;

        public byte[] Mounted_Unk_VehicleEntity1; // Couldnt get this to actually work in the client
        public byte[] Mounted_Unk_VehicleEntity2;
        public byte[] Mounted_Unk_Bytes;

        public byte[] Unk11;
        public ulong ArmyGUID;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(4);

            DisplayName = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            UniqueName = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            Gender = Stream.Read.Byte();
            Race = Stream.Read.Byte();
            CharInfoId = Stream.Read.UInt();
            Head = Stream.Read.UInt();
            Eyes = Stream.Read.UInt();

            Unk2 = Stream.Read.Byte();

            IsNpc = Stream.Read.Byte();
            StaffFlags = Stream.Read.Byte(); // 1=dev,2=mentor,4=ranger,8=publisher
            CharacterTypeId = Stream.Read.UInt();
            Voice = Stream.Read.UInt();
            TitleId = Stream.Read.UShort();
            NameLocalizationId = Stream.Read.UInt();

            byte NumberOfHeadAccessories = Stream.Read.Byte();
            HeadAccessories = Stream.Read.UIntArray(NumberOfHeadAccessories);

            Vehicle = Stream.Read.UInt();
            Glider = Stream.Read.UInt();

            Unk3 = Stream.Read.ByteArray(2);

            byte NumberOfWarpaintColors = Stream.Read.Byte();
            if (NumberOfWarpaintColors > 0)
            {
                WarpaintColors = Stream.Read.UIntArray(NumberOfWarpaintColors);
            }

            byte NumberOfWarpaintPalettes = Stream.Read.Byte();
            if (NumberOfWarpaintPalettes > 0)
            {
                WarpaintPalettes_Data = Stream.Read.ByteArray((1+4) * NumberOfWarpaintPalettes);
            }

            byte NumberOfWarpaintPatterns = Stream.Read.Byte();
            if (NumberOfWarpaintPatterns > 0)
            {
                WarpaintPatterns_Data = Stream.Read.ByteArray((4+(4*2)+1) * NumberOfWarpaintPatterns);
            }

            byte NumberOfOrnaments = Stream.Read.Byte();
            if (NumberOfOrnaments > 0)
            {
                Ornaments = Stream.Read.UIntArray(NumberOfOrnaments);
            }

            Unk4 = Stream.Read.ByteArray(3);
            
            ArmyTag = Stream.Read.String(GetNullTerminatedStrSize(Stream));

    
            Time1 = Stream.Read.UInt();
            EffectsFlag = Stream.Read.Byte();
            Unk5 = Stream.Read.ByteArray(4);
            Time2 = Stream.Read.UInt();
            Unk6 = Stream.Read.ByteArray(4);
            CharacterState = Stream.Read.Byte();
            CharacterStateTime = Stream.Read.UInt();
            Faction = Stream.Read.ByteArray(2);

            if (IsNpc == 0x00)
            {
                Unk7 = Stream.Read.ByteArray(5*4);
            }

            HealthPercent = Stream.Read.Byte();
            HealthMax = Stream.Read.UInt();
            HealthTime = Stream.Read.UInt();
            EmoteId = Stream.Read.UShort();
            EmoteTime = Stream.Read.UInt();

            byte lookahead_Vehicle = Stream.Read.Byte();
            if (lookahead_Vehicle > 0)
            {
                Stream.baseStream.ByteOffset -= 1;
                Mounted_Unk_VehicleEntity1 = Stream.Read.ByteArray(8);
                Mounted_Unk_VehicleEntity2 = Stream.Read.ByteArray(8);
                Mounted_Unk_Bytes = Stream.Read.ByteArray(3);
            }

            Unk11 = Stream.Read.ByteArray(1);
            ArmyGUID = Stream.Read.ULong();
        }

        // Reads until we find 0x00, then resets the head and returns the number of bytes read.
        private int GetNullTerminatedStrSize(Bitter.BinaryStream Stream)
        {
            long StartOffset = Stream.baseStream.ByteOffset;
            do
            {
                byte b = Stream.Read.Byte();
                if (b == 0x00)
                {
                    break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            long EndOffset = Stream.baseStream.ByteOffset;
            Stream.baseStream.ByteOffset = StartOffset;
            return (int)(EndOffset - StartOffset);
        }
    }
}