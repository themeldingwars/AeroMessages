using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 103, true)]
    public class CharacterBaseControllerRespawned : BaseScript
    {
        public ushort ShortTime;
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            ShortTime = Stream.Read.UShort();
            Unk = Stream.Read.ByteArray(2);
        }
    }
}