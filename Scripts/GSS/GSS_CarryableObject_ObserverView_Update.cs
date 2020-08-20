using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 51, 1, true)]
    public class CarryableObjectObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Position = 0x02,
            Unk_0x06 = 0x06,
            Unk_0x65 = 0x65,
        }

        public float[] Position;
        public byte[] Unk_0x06;

        public float[] Unk_0x65_Position;
        public float[] Unk_0x65_MaybeVelocity;
        public uint? Unk_0x65_Time;

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

                    case ShadowFieldIndex.Unk_0x06:
                        //Unk_0x06 = Stream.Read.ByteArray(3);
                        break;

                    case ShadowFieldIndex.Unk_0x65:
                        Unk_0x65_Position = Stream.Read.FloatArray(3);
                        Unk_0x65_MaybeVelocity = Stream.Read.FloatArray(3);
                        Unk_0x65_Time = Stream.Read.UInt();
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