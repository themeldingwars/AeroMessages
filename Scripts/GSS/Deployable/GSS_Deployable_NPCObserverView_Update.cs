/*
WONTPORT
Just shadowfields for something not seen in captures
 */
using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 36, 1, true)]
    public class DeployableNPCObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Behavior = 0x00,
            Function = 0x01,
            ScopeBubbleInfo = 0x02,
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