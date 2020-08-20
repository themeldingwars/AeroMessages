using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 142, false)]
    public class CharacterBaseControllerPerformEmote : BaseScript
    {
        public uint Time;
        public ushort EmoteId; // Sdb table 73, id column

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            EmoteId = Stream.Read.UShort();
        }
    }
}