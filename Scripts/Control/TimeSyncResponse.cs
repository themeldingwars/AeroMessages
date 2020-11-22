using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.Control, 5)]
    public class TimeSyncResponse : BaseScript
    {
        public ulong ClientTime; // Microseconds Client System Uptime (hrtime)
        public ulong ServerTime; // Microseconds UNIX Epoch

        public DateTimeOffset ServerTimeAsUnixMillis;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            ClientTime = Stream.Read.ULong();
            ServerTime = Stream.Read.ULong();
            ServerTimeAsUnixMillis = MicrosToUnixMillis(ServerTime);
        }

        private DateTimeOffset MicrosToUnixMillis(ulong Micros)
        {
            ulong Millis = Micros / 1000;
            return DateTimeOffset.FromUnixTimeMilliseconds((long) Millis);
        }
    }
}