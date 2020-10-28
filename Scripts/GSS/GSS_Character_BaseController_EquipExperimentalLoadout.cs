using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 236, false)]
    public class CharacterBaseControllerEquipExperimentalLoadout : BaseScript
    {
        public uint LoadoutId;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            LoadoutId = Stream.Read.UInt();
        }
    }
}