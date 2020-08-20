using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 100, true)]
    public class GenericEncounterUIScopeIn : BaseScript
    {

        public byte[] EncounterId; // ObjectiveSet? Entity?
        public ushort TextDataLength;
        public byte[] TextData; // Text keys with values inbetween or?
        public byte[] Unk;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            EncounterId = Stream.Read.ByteArray(8);
            TextDataLength = Stream.Read.UShort();
            TextData = Stream.Read.ByteArray((int)TextDataLength);


            int remainingBytes = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
            Unk = Stream.Read.ByteArray(remainingBytes);
        }
    }
}