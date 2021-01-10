using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 20, 1, true)]
    public class AreaVisualDataObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Position        = 0x00,
            ScopeBubbleInfo = 0x01,
            ContextFlags_0  = 0x02,
            ContextFlags_1  = 0x03,
            ContextFlags_2  = 0x04,
            ContextFlags_3  = 0x05,
            ContextFlags_4  = 0x06,
            ContextFlags_5  = 0x07,
            ContextFlags_6  = 0x08,
            ContextFlags_7  = 0x09,
            ContextFlags_8  = 0x0a,
            ContextFlags_9  = 0x0b,
            ContextFlags_10 = 0x0c,
            ContextFlags_11 = 0x0d,
            ContextFlags_12 = 0x0e,
            ContextFlags_13 = 0x0f,
            ContextFlags_14 = 0x10,
            ContextFlags_15 = 0x11,
            ContextFlags_16 = 0x12,
            ContextFlags_17 = 0x13,
            ContextFlags_18 = 0x14,
            ContextFlags_19 = 0x15,
            ContextFlags_20 = 0x16,
            ContextFlags_21 = 0x17,
            ContextFlags_22 = 0x18,
            ContextFlags_23 = 0x19,
            ContextTeams_0  = 0x1a,
            ContextTeams_1  = 0x1b,
            ContextTeams_2  = 0x1c,
            ContextTeams_3  = 0x1d,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public float[] Position;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Position:
                        Position = Stream.Read.FloatArray(3);
                        break;
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