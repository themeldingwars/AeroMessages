using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 57)]
    public class SynchronizationRequest : BaseScript
    {
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
        }
    }
}