using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.Matrix, 17)]
    public class Login : BaseScript
    {
        public byte Unk1;
        public ushort ClientVersion;
        public byte[] Unk2;
        public ulong CharacterGUID;
        public byte[] Unk3;
        public string Red5Sig2; // From Web Requests to ClientAPI
        public byte[] Red5Sig1; // From Web Requests to ClientAPI

        public override void Read(Bitter.BinaryStream Stream)
        {
            MyExtensions.BStream = Stream;
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Unk1 = Stream.Read.Byte();
            ClientVersion = Stream.Read.UShort();
            Unk2 = Stream.Read.ByteArray(3);

            CharacterGUID = Stream.Read.ULong();

            Unk3 = Stream.Read.ByteArray(13);
            Red5Sig2 = Stream.Read.StringZ();
            _ = Stream.Read.Byte();
            Red5Sig1 = Stream.Read.ByteArray((int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset));
        }
    }

    // Add "MyExtensions.BStream = Stream;" as first line in Packet Read function.
    public static class MyExtensions
    {
        public static Bitter.BinaryStream BStream;
        
        public static string StringZ(this Bitter.BinaryReader R)
        {
            string res = "";
            do
            {
                byte b = R.Byte();
                if (b == 0x00)
                    break;
                res += (char)b;
            }
            while (BStream.baseStream.ByteOffset < BStream.baseStream.Length);
            return res;
        }
        
        public static void SkipZeros(this Bitter.BinaryReader R)
        {
            byte b;
            do
            {
                b = R.Byte();
            }
            while( b == 0 );
            BStream.baseStream.ByteOffset--;
        }
    }
}