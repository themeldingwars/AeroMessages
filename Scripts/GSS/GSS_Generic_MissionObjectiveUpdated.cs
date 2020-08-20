using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 64, true)]
    public class GenericMissionObjectiveUpdated : BaseScript
    {
        public uint MissionID; // Sdb table 7, id column, and table 48, mission_id column
        public byte[] Unk1;
        public string TextObjectiveTitle;
        public string TextObjectiveProgress;
        public byte[] Unk2;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            MissionID = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(8);
            TextObjectiveTitle = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            TextObjectiveProgress = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            Unk2 = Stream.Read.ByteArray(5);
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