using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 31, false)]
    public class GenericVendorProductRequest : BaseScript
    {
        public uint TerminalId;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            TerminalId = Stream.Read.UInt();
        }
    }
}