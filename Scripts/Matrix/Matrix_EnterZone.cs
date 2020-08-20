using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 37)]
    public class EnterZone : BaseScript
    {
        public ulong InstanceId;
        public uint ZoneId;
        public ulong ZoneTimestamp;
        public byte PreviewModeFlag;
        public string ZoneOwner;
        public byte[] Unk1;
        public byte HotfixLevel;
        public ulong MatchId;
        public byte[] Unk2;
        public string ZoneName;
        public byte Unk3;
        public byte[] Unk_ZoneTime;
        public byte[] Unk4;
        public byte SpectatorModeFlag;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            InstanceId = Stream.Read.ULong();
            ZoneId = Stream.Read.UInt();
            ZoneTimestamp = Stream.Read.ULong();
            PreviewModeFlag = Stream.Read.Byte();
            ZoneOwner = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            Unk1 = Stream.Read.ByteArray(6);
            HotfixLevel = Stream.Read.Byte();
            MatchId = Stream.Read.ULong();
            Unk2 = Stream.Read.ByteArray(5);
            ZoneName = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            Unk3 = Stream.Read.Byte();
            Unk_ZoneTime = Stream.Read.ByteArray(16);
            Unk4 = Stream.Read.ByteArray(41);
            SpectatorModeFlag = Stream.Read.Byte();
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