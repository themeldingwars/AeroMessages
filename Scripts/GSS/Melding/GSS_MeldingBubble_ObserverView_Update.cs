using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 18, 1, true)]
    public class MeldingBubbleObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Position        = 0x00,
            Radius          = 0x01,
            BubbleType      = 0x02,
            FxFlags         = 0x03,
            ScopeBubbleInfo = 0x04,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

    
        }



    }
}