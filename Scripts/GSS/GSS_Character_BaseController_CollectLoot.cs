using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 111, false)]
    public class CharacterBaseControllerCollectLoot : BaseScript
    {
        public byte[] LootEntityID;
        public byte[] Unk;
        public uint LootSdbID;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            LootEntityID = Stream.Read.ByteArray(8);
            Unk = Stream.Read.ByteArray(4);
            LootSdbID = Stream.Read.UInt();
        }
    }
}