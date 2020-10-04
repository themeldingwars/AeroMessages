using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 91, true)]
    public class GenericInteractableStatusChanged : BaseScript
    {

        public byte[] Entity;
        public byte[] Unk;
        public byte Interactable;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            Entity = Stream.Read.ByteArray(8);
            Unk = Stream.Read.ByteArray(5);
            Interactable = Stream.Read.Byte();
        }
    }
}