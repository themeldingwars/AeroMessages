using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 154, true)]
    public class CharacterBaseControllerSlotGearResponse : BaseScript
    {
        public uint LoadoutId;
        public ulong ItemGUID;
        public byte SlotIdx;
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            LoadoutId = Stream.Read.UInt();
            ItemGUID = Stream.Read.ULong();
            SlotIdx = Stream.Read.Byte();
            Unk = Stream.Read.ByteArray(5); // 1 more byte than request
        }
    }
}