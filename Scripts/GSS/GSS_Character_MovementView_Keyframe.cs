using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 12, 3, true)]
    public class CharacterMovementViewKeyframe : BaseScript
    {
        public float[] Position;
        public float[] Rotation;
        public float[] Aim;
        public ushort MovementState;
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Position = Stream.Read.FloatArray(3);
            Rotation = Stream.Read.FloatArray(4);
            Aim = Stream.Read.FloatArray(3);
            MovementState = Stream.Read.UShort();
            Time = Stream.Read.UInt();
        }
    }
}