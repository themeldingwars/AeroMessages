using Bitter;
namespace PacketPeepScript
{
    // This pretty rough, not tested
    [Script(MessageType.GSS, 45, 1, true)]
    public class OutpostObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Unk_0x06 = 0x06,
            Unk_0x08 = 0x08, 
        }

        public byte? Unk_0x06;
        public byte? Unk_0x08;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Unk_0x06:
                        Unk_0x06 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Unk_0x08:
                        Unk_0x08 = Stream.Read.Byte();
                        break;

                    default:
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }
}