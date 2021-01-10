using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 207, false)]
    public class CharacterBaseControllerSlotVisualRequest : BaseScript
    {
        public uint LoadoutId;
        public uint ItemSdbId;
        public byte SlotIdx1; // ?
        public byte SlotIdx2; // ?
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            LoadoutId = Stream.Read.UInt();
            ItemSdbId = Stream.Read.UInt();
            SlotIdx1 = Stream.Read.Byte();
            SlotIdx2 = Stream.Read.Byte();
            Unk = Stream.Read.ByteArray(9);
        }
    }
}