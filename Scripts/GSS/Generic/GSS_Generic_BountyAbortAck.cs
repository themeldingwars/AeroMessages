using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 70, true)]
    public class GenericBountyAbortAck : BaseScript
    {

        public uint BountyId; // Unsure how this id works
        public byte[] Unk1;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            BountyId = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(2);
        }
    }
}