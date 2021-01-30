using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 37, 3, true)]
    public class DeployableHardpointViewKeyframe : BaseScript
    {
        public uint HardpointChildType; // DeployableTypeId Of the selected deployable
        public byte HardpointChildId_HaveEntity;
        public byte[] HardpointChildId_Entity;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            HardpointChildType = Stream.Read.UInt();
            HardpointChildId_HaveEntity = Stream.Read.Byte();
            if (HardpointChildId_HaveEntity > 0x00) {
                HardpointChildId_Entity = Stream.Read.ByteArray(8);
            }
        }
    }
}