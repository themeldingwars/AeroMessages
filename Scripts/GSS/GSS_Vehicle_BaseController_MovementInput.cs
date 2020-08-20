using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 27, 83, false)]
    public class VehicleBaseControllerMovementInput : BaseScript
    {
        public float[] Position;
        public float[] Rotation;
        public float[] Direction;
        public ushort MovementState;
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Position = Stream.Read.FloatArray(3);
            Rotation = Stream.Read.FloatArray(4);
            Direction = Stream.Read.FloatArray(3);
            MovementState = Stream.Read.UShort();
            Time = Stream.Read.UInt();
        }
    }
}