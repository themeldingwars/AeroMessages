using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 37, 3, true)]
    public class DeployableHardpointViewKeyframe : BaseScript
    {
        public uint DeployableTypeId; // Of the selected deployable
        public byte HaveEntity;
        public byte[] Entity;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            DeployableTypeId = Stream.Read.UInt();
            HaveEntity = Stream.Read.Byte();
            if (HaveEntity > 0x00) {
                Entity = Stream.Read.ByteArray(8);
            }
        }
    }
}