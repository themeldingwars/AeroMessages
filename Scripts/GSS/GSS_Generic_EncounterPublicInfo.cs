using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 112, true)]
    public class GenericEncounterPublicInfo : BaseScript
    {

        public byte[] EncounterId; // ObjectiveSet? Entity?
        public string EncounterJSON;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            EncounterId = Stream.Read.ByteArray(8);

            int remainingBytes = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
            EncounterJSON = Stream.Read.String(remainingBytes);


            
        }
    }
}