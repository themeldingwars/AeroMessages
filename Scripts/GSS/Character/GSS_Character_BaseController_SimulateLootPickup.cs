using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 132, false)]
    public class CharacterBaseControllerSimulateLootPickup : BaseScript
    {
        public uint LootSdbID;
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            LootSdbID = Stream.Read.UInt();
            int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
            Unk = Stream.Read.ByteArray(remaining);
        }
    }
}