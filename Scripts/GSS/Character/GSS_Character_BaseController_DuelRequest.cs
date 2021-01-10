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

    [Script(MessageType.GSS, 2, 188, false)]
    public class CharacterBaseControllerDuelRequest : BaseScript
    {
        public byte[] Unk1;
        public byte[] RequestingEntity;
        public byte[] Unk2;
        public string TargetName;
        public byte[] Unk3;
        public byte[] TargetEntity;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.ByteArray(2);
            RequestingEntity = Stream.Read.ByteArray(8);
            Unk2 = Stream.Read.ByteArray(9);
            TargetName = Stream.Read.StringZ(Stream);
            Unk3 = Stream.Read.ByteArray(20);
        }
    }
}