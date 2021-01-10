using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 53, 1, true)]
    public class LootStoreExtensionLootObjectViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            LootObjects_0 = 0x00,
            LootObjects_1 = 0x01,
            LootObjects_2 = 0x02,
            LootObjects_3 = 0x03,
            LootObjects_4 = 0x04,
            LootObjects_5 = 0x05,
            LootObjects_6 = 0x06,
            LootObjects_7 = 0x07,
            LootObjects_8 = 0x08,
            LootObjects_9 = 0x09,
            LootObjects_10 = 0x0a,
            LootObjects_11 = 0x0b,
            LootObjects_12 = 0x0c,
            LootObjects_13 = 0x0d,
            LootObjects_14 = 0x0e,
            LootObjects_15 = 0x0f,
            LootObjects_16 = 0x10,
            LootObjects_17 = 0x11,
            LootObjects_18 = 0x12,
            LootObjects_19 = 0x13,
            LootObjects_20 = 0x14,
            LootObjects_21 = 0x15,
            LootObjects_22 = 0x16,
            LootObjects_23 = 0x17,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
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