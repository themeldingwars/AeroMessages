using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 101, true)]
    public class GenericEncounterUIUpdate : BaseScript
    {

        public byte[] EncounterId; // ObjectiveSet? Entity?
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            EncounterId = Stream.Read.ByteArray(8);
            int remainingBytes = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
            Unk = Stream.Read.ByteArray(remainingBytes);      
        }
    }
}