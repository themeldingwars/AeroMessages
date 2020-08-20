using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.Control, 4)]
    public class TimeSyncRequest : BaseScript
    {
		public ulong ClientTime; // Microseconds Client System Uptime (hrtime)

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
			ClientTime = Stream.Read.ULong();
        }
    }
}