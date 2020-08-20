using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 145, false)]
    public class CharacterBaseControllerPerformTextChat : BaseScript
    {
        public string Message;
        public byte Channel; // Might be a ushort

        // Remaining bytes are used in whispers (8) and friends chat (14)
        // Not sure about their contents.

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Message = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            Channel = Stream.Read.Byte();
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