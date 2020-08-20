using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 251, 25, false)]
    public class GenericRequestEncounterInfo : BaseScript
    {

        public byte[] EncounterId; // ObjectiveSet? Entity?

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
    
            EncounterId = Stream.Read.ByteArray(8);
        }
    }
}