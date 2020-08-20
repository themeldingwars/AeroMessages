using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 69, true)]
    public class GenericBountyStatusChanged : BaseScript
    {

        public uint BountyId; // Unsure how this id works
        public byte Status;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            BountyId = Stream.Read.UInt();
            Status = Stream.Read.Byte();
        }
    }
}