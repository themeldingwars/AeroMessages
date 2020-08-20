using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 71, true)]
    public class GenericBountyActivationAck : BaseScript
    {

        public uint BountyId; // Unsure how this id works
        public byte[] Unk1;
        public uint MissionId; // Sdb table 7, id column, and table 48, mission_id column
        public byte[] Unk2;
        public string Name;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            BountyId = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(7);
            MissionId = Stream.Read.UInt();
            Unk2 = Stream.Read.ByteArray(9);
            Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));
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