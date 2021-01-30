using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 37, 1, true)]
    public class DeployableHardpointViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            HardpointChildType = 0x00,
            HardpointChildId = 0x01,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public uint HardpointChildType; // DeployableTypeId Of the selected deployable
        public byte HardpointChildId_HaveEntity;
        public byte[] HardpointChildId_Entity;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.HardpointChildType:
                        HardpointChildType = Stream.Read.UInt();
                        break;

                    case ShadowFieldIndex.HardpointChildId:
                        HardpointChildId_HaveEntity = Stream.Read.Byte();
                        if (HardpointChildId_HaveEntity > 0x00) {
                            HardpointChildId_Entity = Stream.Read.ByteArray(8);
                        }
                        break;

                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

    
        }



    }
}