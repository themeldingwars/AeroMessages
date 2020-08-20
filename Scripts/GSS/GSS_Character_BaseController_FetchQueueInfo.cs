using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 89, false)]
    public class CharacterBaseControllerFetchQueueInfo : BaseScript
    {
        
        public byte NumberOfKeys;
        public string? Key1;
        public string? Key2;
        public string? Key3;
        public string? Key4;
        public string? Key5;

        public byte[] Unk; // Last few bytes might be a level range

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            NumberOfKeys = Stream.Read.Byte();

            if (NumberOfKeys > 0) {
                Key1 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            }
            if (NumberOfKeys > 1) {
                Key2 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            }
            if (NumberOfKeys > 2) {
                Key3 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            }
            if (NumberOfKeys > 3) {
                Key4 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            }
            if (NumberOfKeys > 4) {
                Key5 = Stream.Read.String(GetNullTerminatedStrSize(Stream));
            }

            Unk = Stream.Read.ByteArray(12);

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