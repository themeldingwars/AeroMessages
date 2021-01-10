using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 150, false)]
    public class CharacterBaseControllerSelectLoadout : BaseScript
    {
        public uint LoadoutId;
        public byte Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            LoadoutId = Stream.Read.UInt();
            Unk = Stream.Read.Byte();
        }
    }
}