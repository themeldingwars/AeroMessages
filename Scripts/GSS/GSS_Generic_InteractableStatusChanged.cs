using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 91, true)]
    public class GenericInteractableStatusChanged : BaseScript
    {

        public byte[] Unk;
        public byte[] Entity;
        public byte Interactable;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            Unk = Stream.Read.ByteArray(5);
            Entity = Stream.Read.ByteArray(8);
            Interactable = Stream.Read.Byte();
        }
    }
}