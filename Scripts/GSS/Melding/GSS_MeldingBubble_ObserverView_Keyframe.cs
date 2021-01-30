using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 18, 3, true)]
    public class MeldingBubbleObserverViewKeyframe : BaseScript
    {
        public float[] Position;
        public uint Position_Time;
        public float Radius;
        public uint Radius_Time;
        public byte BubbleType;
        public byte FxFlags;
        public byte[] ScopeBubbleInfo;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.Stream = Stream;

            if (true) {
                Position = Stream.Read.FloatArray(3);
                Position_Time = Stream.Read.UInt();
                Radius = Stream.Read.Float();
                Radius_Time = Stream.Read.UInt();
                BubbleType = Stream.Read.Byte();
                FxFlags = Stream.Read.Byte();
                ScopeBubbleInfo = Stream.Read.ByteArray(8);
            }
            
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