using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 103, true)]
    public class DisplayUiNotification : BaseScript
    {
        public uint LocalizedTextId; // Sdb table 31, id column.
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            LocalizedTextId = Stream.Read.UInt();
            Unk = Stream.Read.ByteArray(6);
        }
    }
}