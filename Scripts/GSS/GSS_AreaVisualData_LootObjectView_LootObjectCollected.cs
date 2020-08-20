using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 24, 83, true)]
    public class AreaVisualDataLootObjectViewLootObjectCollected : BaseScript
    {

        public byte[] Unk;
        public byte[] LootedByEntity; // Could be the opposite
        public byte[] LootedToEntity; // Could be the opposite

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
        
            Unk = Stream.Read.ByteArray(4);
            LootedByEntity = Stream.Read.ByteArray(8);
            LootedToEntity = Stream.Read.ByteArray(8);
        }
    }
}