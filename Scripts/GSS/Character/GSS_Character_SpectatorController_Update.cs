using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 7, 1, true)]
    public class CharacterSpectatorControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            PingTime = 0x00,
            SpecatorMode = 0x01,
            CinematicCamera = 0x02,
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