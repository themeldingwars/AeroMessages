using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 68, true)]
    public class GenericMissionActivationAck : BaseScript
    {

        public uint MissionId; // Sdb table 7, id column, and table 48, mission_id column
        public byte[] Unk1;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            MissionId = Stream.Read.UInt();
            Unk1 = Stream.Read.ByteArray(2);
        }
    }
}