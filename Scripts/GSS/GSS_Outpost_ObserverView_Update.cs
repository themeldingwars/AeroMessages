using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 45, 1, true)]
    public class OutpostObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            OutpostName            = 0x00,
            Position               = 0x01,
            LevelBandId            = 0x02,
            SinUnlockIndex         = 0x03,
            TeleportCost           = 0x04,
            Dynamic_00             = 0x05,
            Dynamic_01             = 0x06,
            Dynamic_02             = 0x07,
            Dynamic_03             = 0x08,
            Dynamic_04             = 0x09,
            Dynamic_05             = 0x0a,
            Dynamic_06             = 0x0b,
            Dynamic_07             = 0x0c,
            Dynamic_08             = 0x0d,
            Dynamic_09             = 0x0e,
            Dynamic_10             = 0x0f,
            Dynamic_11             = 0x10,
            NearbyResourceItems_0  = 0x11,
            NearbyResourceItems_1  = 0x12,
            NearbyResourceItems_2  = 0x13,
            NearbyResourceItems_3  = 0x14,
            NearbyResourceItems_4  = 0x15,
            NearbyResourceItems_5  = 0x16,
            NearbyResourceItems_6  = 0x17,
            NearbyResourceItems_7  = 0x18,
            NearbyResourceItems_8  = 0x19,
            NearbyResourceItems_9  = 0x1a,
            NearbyResourceItems_10 = 0x1b,
            NearbyResourceItems_11 = 0x1c,
            NearbyResourceItems_12 = 0x1d,
            NearbyResourceItems_13 = 0x1e,
            NearbyResourceItems_14 = 0x1f,
            NearbyResourceItems_15 = 0x20,
            EncounterId            = 0x21,
            ScopeBubbleInfo        = 0x22,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public byte? Dynamic_01;
        public byte? Dynamic_03;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Dynamic_01:
                        Dynamic_01 = Stream.Read.Byte();
                        break;
                    case ShadowFieldIndex.Dynamic_03:
                        Dynamic_03 = Stream.Read.Byte();
                        break;

                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }
}