using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 102, true)]
    public class GenericEncounterUIScopeOut : BaseScript
    {

        public byte[] EncounterId; // ObjectiveSet? Entity?

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            EncounterId = Stream.Read.ByteArray(8);            
        }
    }
}