using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 31, 3, true)]
    public class VehicleMovementViewKeyframe : BaseScript
    {
        public float[] Position;
        public float[] Rotation;
        public float[] Direction;
        public ushort MovementState;
        public uint Time;
        public byte[] Unk1;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Position = Stream.Read.FloatArray(3);
            Rotation = Stream.Read.FloatArray(4);
            Direction = Stream.Read.FloatArray(3);
            MovementState = Stream.Read.UShort();
            Time = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(4*3);
        }
    }
}