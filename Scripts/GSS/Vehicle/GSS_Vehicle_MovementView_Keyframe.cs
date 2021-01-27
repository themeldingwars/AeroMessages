using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 31, 3, true)]
    public class VehicleMovementViewKeyframe : BaseScript
    {
        public float[] CurrentPose_Position;
        public float[] CurrentPose_Rotation;
        public float[] CurrentPose_Direction;
        public ushort CurrentPose_MovementState;
        public uint CurrentPose_Time;
        public float[] SpawnVelocity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            CurrentPose_Position = Stream.Read.FloatArray(3);
            CurrentPose_Rotation = Stream.Read.FloatArray(4);
            CurrentPose_Direction = Stream.Read.FloatArray(3);
            CurrentPose_MovementState = Stream.Read.UShort();
            CurrentPose_Time = Stream.Read.UInt();
            SpawnVelocity = Stream.Read.FloatArray(3);
        }
    }
}