using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 251, 17, false)]
    public class GenericUIToEncounterMessage : BaseScript
    {

        public string Key1;
        public string Key2;
        public string JSON;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            Key1 = Stream.Read.StringZ();
            Key2 = Stream.Read.StringZ();
            JSON = Stream.Read.StringZ();
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