using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 118, false)]
    public class GenericChatMessageList : BaseScript
    {
        public byte Unk1;

        public byte[] Sender_Entity;
        public string Sender_Name;
        public string Message;
        public byte Channel;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.Byte();
            Sender_Entity = Stream.Read.ByteArray(8);
            Sender_Name = Stream.Read.String(GetNullTerminatedStrSize(Stream));
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