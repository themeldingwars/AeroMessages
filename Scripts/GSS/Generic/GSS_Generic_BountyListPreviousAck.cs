using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 77, true)]
    public class GenericBountyListPreviousAck : BaseScript
    {

        public byte[] Unk;
        public string JSON;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            Unk = Stream.Read.ByteArray(3);
            JSON = Stream.Read.String(GetNullTerminatedStrSize(Stream));
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