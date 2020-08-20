using Bitter;
using System;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 57)]
    public class SynchronizationRequest : BaseScript
    {
        //public ulong Unk_MaybeTimestamp;
        //public DateTimeOffset Unk_MaybeTimestamp_AsUnixMillis;

        public override void Read(Bitter.BinaryStream Stream)
        {
           Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

           // Skip unks for now
           //Stream.baseStream.ByteOffset += 14;

           //Unk_MaybeTimestamp = Stream.Read.ULong();
           //Unk_MaybeTimestamp_AsUnixMillis = MicrosToUnixMillis(Unk_MaybeTimestamp);
        }

        private DateTimeOffset MicrosToUnixMillis(ulong Micros)
        {
            ulong Millis = Micros / 1000;
            return DateTimeOffset.FromUnixTimeMilliseconds((long) Millis);
        }
    }
}