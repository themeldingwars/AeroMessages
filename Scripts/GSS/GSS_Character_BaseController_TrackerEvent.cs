using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 134, true)]
    public class CharacterBaseControllerTrackerEvent : BaseScript
    {
        public byte[] Entity;
        public byte[] Unk1;
        public string Text;
        public byte Unk2;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Entity = Stream.Read.ByteArray(8);
            Unk1 = Stream.Read.ByteArray(6);
            Text = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            Unk2 = Stream.Read.Byte();
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