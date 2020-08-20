using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 35)]
    public class WelcomeToTheMatrix : BaseScript
    {
        public ulong PlayerID;
        public ushort Unk1;
        public ushort Unk2;

        public override void Read(Bitter.BinaryStream Stream)
        {
           Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

           PlayerID = Stream.Read.ULong();
           Unk1     = Stream.Read.UShort();
           Unk2     = Stream.Read.UShort();
        }
    }
}