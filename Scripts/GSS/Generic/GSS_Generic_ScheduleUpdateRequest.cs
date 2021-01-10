using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 251, 19, false)]
    public class GenericScheduleUpdateRequest : BaseScript
    {
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
        }
    }
}