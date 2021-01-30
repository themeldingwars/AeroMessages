using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 249, false)]
    public class CharacterBaseControllerUpdateFriendStatus : BaseScript
    {
        public string TargetName;
        public byte[] Unk_Status;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            TargetName = Stream.Read.StringZ();
            Unk_Status = Stream.Read.ByteArray(2);
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