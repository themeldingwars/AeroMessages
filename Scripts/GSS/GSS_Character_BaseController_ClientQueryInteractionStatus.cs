using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 186, false)]
    public class CharacterBaseControllerClientQueryInteractionStatus : BaseScript
    {
        public byte ControllerID;
        public byte[] EntityID;
        public byte Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            ControllerID = Stream.Read.Byte();
            EntityID = Stream.Read.ByteArray(7);
            Unk = Stream.Read.Byte();
        }
    }
}