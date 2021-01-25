using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 16, 1, true)]
    public class MeldingObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            PerimeterSetName = 0x00,
            ActiveData = 0x01,
            ScopeBubbleInfo = 0x02,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield
        
        public string PerimiterSetName;

        // -- ActiveData --
        public byte[] Unk1;
        public byte[] Unk2_Consistent;
        public byte ControlPoints_1_Count;
        public float[] ControlPoints_1;
        public byte Offsets_1_Count;
        public float[] Offsets_1;
        public byte ControlPoints_2_Count;
        public float[] ControlPoints_2;
        public byte Offsets_2_Count;
        public float[] Offsets_2;
        // -- --

        public byte[] ScopeBubbleInfo;


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.BStream = Stream;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.PerimeterSetName:
                        PerimeterSetName = Stream.Read.StringZ();
                        break;

                    case ShadowFieldIndex.ActiveData:
                        // -- ActiveData --
                        Unk1 = Stream.Read.ByteArray(4);
                        Unk2_Consistent = Stream.Read.ByteArray(13);

                        ControlPoints_1_Count = Stream.Read.Byte();
                        ControlPoints_1 = Stream.Read.FloatArray(ControlPoints_1_Count*3);

                        Offsets_1_Count = Stream.Read.Byte();
                        Offsets_1 = Stream.Read.FloatArray(Offsets_1_Count*3);

                        ControlPoints_2_Count = Stream.Read.Byte();
                        ControlPoints_2 = Stream.Read.FloatArray(ControlPoints_2_Count*3); 

                        Offsets_2_Count = Stream.Read.Byte();
                        Offsets_2 = Stream.Read.FloatArray(Offsets_2_Count*3);
                        // -- --
                        break;

                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;

                    default:
                        UnableToParseWarning = $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

    
        }

    }

    public static class MyExtensions {
        public static Bitter.BinaryStream BStream;
        
        public static string StringZ(this Bitter.BinaryReader rdr) {
            string ret = "";
            
            do {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                
                ret += (char)b;
            } while (BStream.baseStream.ByteOffset < BStream.baseStream.Length);
            
            return ret;
        }
    }
}