using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 179, false)]
    public class CharacterBaseControllerVehicleCalldownRequest : BaseScript
    {
        public ushort VehicleID; // Sdb table 47, id column.

        public float[] Position;
        public float[] Rotation;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            VehicleID = Stream.Read.UShort();

            Position = Stream.Read.FloatArray(3);
            Rotation = Stream.Read.FloatArray(4);
        }
    }
}