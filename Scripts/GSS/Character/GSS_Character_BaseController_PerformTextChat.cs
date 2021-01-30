using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 145, false)]
    public class CharacterBaseControllerPerformTextChat : BaseScript
    {
        public string Message;
        public byte Channel; // Might be a ushort

        // Remaining bytes are used in whispers (8) and friends chat (14)
        // Not sure about their contents.

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            Message = Stream.Read.StringZ();
            Channel = Stream.Read.Byte();
        }
    }

    public static class MyExtensions
    {
        public static Bitter.BinaryStream Stream;
            
        public static string StringZ(this Bitter.BinaryReader rdr)
        {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);
            return ret;
        }
    }
}