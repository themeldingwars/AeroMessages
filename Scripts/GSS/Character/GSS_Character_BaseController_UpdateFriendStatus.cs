using Bitter;
namespace PacketPeepScript
{
    public static class MyExtensions {
        public static string StringZ(this Bitter.BinaryReader rdr, Bitter.BinaryStream stream) {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (stream.baseStream.ByteOffset < stream.baseStream.Length);
            return ret;
        }
    }

    [Script(MessageType.GSS, 2, 249, false)]
    public class CharacterBaseControllerUpdateFriendStatus : BaseScript
    {
        public string TargetName;
        public byte[] Unk_Status;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            TargetName = Stream.Read.StringZ(Stream);
            Unk_Status = Stream.Read.ByteArray(2);
        }
    }
}