using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 12, 1, true)]
    public class CharacterMovementViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            // If you are seeing other fields, chances are there is a refId collision
            // It might be showing you a combat view for example.
            Movement = 0x00,
        }

        public float[] Position;
        public float[] Rotation;
        public float[] Aim;
        public ushort? MovementState;
        public uint? Time;


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Movement:
                        Position = Stream.Read.FloatArray(3);
                        Rotation = Stream.Read.FloatArray(4);
                        Aim = Stream.Read.FloatArray(3);
                        MovementState = Stream.Read.UShort();
                        Time = Stream.Read.UInt();
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