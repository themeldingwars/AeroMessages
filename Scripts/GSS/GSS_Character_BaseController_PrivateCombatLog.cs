using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 92, true)]
    public class CharacterBaseControllerPrivateCombatLog : BaseScript
    {
        
        public byte[] Unk1;

        public ushort DataLength;
        public byte[] Data; // Multiple variations, often gametime towards the end of a row.

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(4);
            DataLength = Stream.Read.UShort();
            Data = Stream.Read.ByteArray(DataLength);
        }

        
    }
}