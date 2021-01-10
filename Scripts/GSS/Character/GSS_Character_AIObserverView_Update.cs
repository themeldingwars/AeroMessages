using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 19, 1, true)]
    public class CharacterAIObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
           ListenerId       = 0x00,
           SpawnTime        = 0x01,
           Wallet           = 0x02,
           ScopeBubbleInfo  = 0x03,
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