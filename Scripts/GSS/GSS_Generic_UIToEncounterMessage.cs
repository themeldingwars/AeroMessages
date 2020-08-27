using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 251, 17, false)]
    public class GenericUIToEncounterMessage : BaseScript
    {

        public string Key1;
        public string Key2;
        public string JSON;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Key1 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            Key2 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
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