using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 121, true)]
    public class CharacterBaseControllerPrivateDialog : BaseScript
    {
        
        public uint Time;
        public byte[] Entity;
        public uint DialogId;


        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Time = Stream.Read.UInt();
            Entity = Stream.Read.ByteArray(8);
            DialogId = Stream.Read.UInt();
        }

        
    }
}