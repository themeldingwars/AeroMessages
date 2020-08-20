using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 180, false)]
    public class CharacterBaseControllerVehicleCalldownRequest : BaseScript
    {
        public uint DeployableId; // Sdb table 187, id column.

        public float[] Position;
        public float[] Rotation;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            DeployableId = Stream.Read.UInt();
            Position = Stream.Read.FloatArray(3);
            Rotation = Stream.Read.FloatArray(4);
        }
    }
}