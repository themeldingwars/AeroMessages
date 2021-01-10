using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 251, 21, false)]
    public class ServerGenericRemoteProximityAbilitySuccess : BaseScript
    {
        public byte[] SourceEntity;
        public byte Unk;
        public uint ClientProximityCommandId;
        public byte NumberOfAffected;
        public byte[] Entity1;
        public byte[] Entity2;
        public byte[] Entity3;
        public byte[] Entity4;
        public byte[] Entity5;
        public uint Time;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
        
            SourceEntity = Stream.Read.ByteArray(8);
            Unk = Stream.Read.Byte();
            ClientProximityCommandId = Stream.Read.UInt();
            NumberOfAffected = Stream.Read.Byte();
            
            if (NumberOfAffected > 0) {
                Entity1 = Stream.Read.ByteArray(8);
            }
            if (NumberOfAffected > 1) {
                Entity2 = Stream.Read.ByteArray(8);
            }
            if (NumberOfAffected > 2) {
                Entity3 = Stream.Read.ByteArray(8);
            }
            if (NumberOfAffected > 3) {
                Entity4 = Stream.Read.ByteArray(8);
            }
            if (NumberOfAffected > 3) {
                Entity5 = Stream.Read.ByteArray(8);
            }
            
            Time = Stream.Read.UInt();
        }
    }
}