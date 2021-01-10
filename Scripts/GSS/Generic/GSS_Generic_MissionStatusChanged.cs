using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 65, true)]
    public class GenericMissionStatusChanged : BaseScript
    {
        public uint MissionID; // Sdb table 7, id column, and table 48, mission_id column
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            MissionID = Stream.Read.UInt();
            Unk = Stream.Read.ByteArray(5);
        }
    }
}