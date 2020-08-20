using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 182, false)]
    public class CharacterBaseControllerResourceNodeBeaconCalldownRequest : BaseScript
    {
        public float[] Position;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Position = Stream.Read.FloatArray(3);
        }
    }
}