using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 8, 101, true)]
    public class CharacterObserverViewCurrentPoseUpdate : BaseScript
    {
        public ushort ShortTime;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            ShortTime = Stream.Read.UShort();  
        }
    }
}