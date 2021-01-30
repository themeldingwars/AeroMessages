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

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public float[] Position;
        public uint? Position_Time;
        public float Radius;
        public uint Radius_Time;
        public byte BubbleType;
        public byte FxFlags;
        public byte[] ScopeBubbleInfo;

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
                        Position_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.Radius:
                        Radius = Stream.Read.Float();
                        Radius_Time = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.BubbleType:
                        BubbleType = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.FxFlags:
                        FxFlags = Stream.Read.Byte();
                        break;

                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;

                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

    
        }



    }
}