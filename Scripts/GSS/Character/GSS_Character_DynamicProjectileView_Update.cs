using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 4, 1, true)]
    public class CharacterDynamicProjectileViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            DynamicProjectilePositions_0 = 0x00,
            DynamicProjectilePositions_1 = 0x01,
            DynamicProjectilePositions_2 = 0x02,
            DynamicProjectilePositions_3 = 0x03,
            DynamicProjectilePositions_4 = 0x04,
            DynamicProjectilePositions_5 = 0x05,
            DynamicProjectilePositions_6 = 0x06,
            DynamicProjectilePositions_7 = 0x07,
            DynamicProjectilePositions_8 = 0x08,
            DynamicProjectilePositions_9 = 0x09,
            DynamicProjectilePositions_10 = 0x0a,
            DynamicProjectilePositions_11 = 0x0b,
            DynamicProjectilePositions_12 = 0x0c,
            DynamicProjectilePositions_13 = 0x0d,
            DynamicProjectilePositions_14 = 0x0e,
            DynamicProjectilePositions_15 = 0x0f,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

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