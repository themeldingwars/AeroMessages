using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 37, 3, true)]
    public class DeployableHardpointViewKeyframe : BaseScript
    {
        // Just quickly scoping this out
        public byte[] Unk1;
        public byte[] Entity;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(5);
            Entity = Stream.Read.ByteArray(8);
        }
    }
}