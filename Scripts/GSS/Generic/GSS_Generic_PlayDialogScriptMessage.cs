using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 108, true)]
    public class GenericPlayDialogScriptMessage : BaseScript
    {

        public uint DialogId; // Sdb table 4, id column, always has a match. Sometimes hits on event_id in table 14 and table 55.
        public byte Unk1;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            DialogId = Stream.Read.UInt();
            Unk1 = Stream.Read.Byte();
        }
    }
}