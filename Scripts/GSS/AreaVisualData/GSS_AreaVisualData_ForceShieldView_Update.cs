using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    public struct ForceShieldsData
    {
        // TODO:

        public ForceShieldsData(Bitter.BinaryReader R)
        {
            
        }

        public override string ToString() => $"";
    }

    [Script(MessageType.GSS, 25, 1, true)]
    public class AreaVisualDataForceShieldViewUpdate : BaseScript
    {

        enum ShadowFieldIndex : byte
        {
            Position = 0x00,
            ForceShields_0  = 0x01,
            ForceShields_1  = 0x02,
            ForceShields_2  = 0x03,
            ForceShields_3  = 0x04,
            ForceShields_4  = 0x05,
            ForceShields_5  = 0x06,
            ForceShields_6  = 0x07,
            ForceShields_7  = 0x08,
            ForceShields_8  = 0x09,
            ForceShields_9  = 0x0a,
            ForceShields_10 = 0x0b,
            ForceShields_11 = 0x0c,
            ForceShields_12 = 0x0d,
            ForceShields_13 = 0x0e,
            ForceShields_14 = 0x0f,
            ForceShields_15 = 0x10,
            ForceShields_16 = 0x11,
            ForceShields_17 = 0x12,
            ForceShields_18 = 0x13,
            ForceShields_19 = 0x14,
            ForceShields_20 = 0x15,
            ForceShields_21 = 0x16,
            ForceShields_22 = 0x17,
            ForceShields_23 = 0x18,
            ForceShields_24 = 0x19,
            ForceShields_25 = 0x1a,
            ForceShields_26 = 0x1b,
            ForceShields_27 = 0x1c,
            ForceShields_28 = 0x1d,
            ForceShields_29 = 0x1e,
            ForceShields_30 = 0x1f,
            ForceShields_31 = 0x20,
            ScopeBubbleInfo = 0x21,
        }

        public string UnableToParseWarning; // Will be set if we encounter an unhandled shadowfield

        public ForceShieldsData? ForceShields_0;
        public ForceShieldsData? ForceShields_1;
        public ForceShieldsData? ForceShields_2;
        public ForceShieldsData? ForceShields_3;
        public ForceShieldsData? ForceShields_4;
        public ForceShieldsData? ForceShields_5;
        public ForceShieldsData? ForceShields_6;
        public ForceShieldsData? ForceShields_7;
        public ForceShieldsData? ForceShields_8;
        public ForceShieldsData? ForceShields_9;
        public ForceShieldsData? ForceShields_10;
        public ForceShieldsData? ForceShields_11;
        public ForceShieldsData? ForceShields_12;
        public ForceShieldsData? ForceShields_13;
        public ForceShieldsData? ForceShields_14;
        public ForceShieldsData? ForceShields_15;
        public ForceShieldsData? ForceShields_16;
        public ForceShieldsData? ForceShields_17;
        public ForceShieldsData? ForceShields_18;
        public ForceShieldsData? ForceShields_19;
        public ForceShieldsData? ForceShields_20;
        public ForceShieldsData? ForceShields_21;
        public ForceShieldsData? ForceShields_22;
        public ForceShieldsData? ForceShields_23;
        public ForceShieldsData? ForceShields_24;
        public ForceShieldsData? ForceShields_25;
        public ForceShieldsData? ForceShields_26;
        public ForceShieldsData? ForceShields_27;
        public ForceShieldsData? ForceShields_28;
        public ForceShieldsData? ForceShields_29;
        public ForceShieldsData? ForceShields_30;
        public ForceShieldsData? ForceShields_31;


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.ForceShields_0:
                        ForceShields_0 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_1:
                        ForceShields_1 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_2:
                        ForceShields_2 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_3:
                        ForceShields_3 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_4:
                        ForceShields_4 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_5:
                        ForceShields_5 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_6:
                        ForceShields_6 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_7:
                        ForceShields_7 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_8:
                        ForceShields_8 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_9:
                        ForceShields_9 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_10:
                        ForceShields_10 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_11:
                        ForceShields_11 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_12:
                        ForceShields_12 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_13:
                        ForceShields_13 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_14:
                        ForceShields_14 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_15:
                        ForceShields_15 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_16:
                        ForceShields_16 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_17:
                        ForceShields_17 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_18:
                        ForceShields_18 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_19:
                        ForceShields_19 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_20:
                        ForceShields_20 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_21:
                        ForceShields_21 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_22:
                        ForceShields_22 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_23:
                        ForceShields_23 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_24:
                        ForceShields_24 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_25:
                        ForceShields_25 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_26:
                        ForceShields_26 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_27:
                        ForceShields_27 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_28:
                        ForceShields_28 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_29:
                        ForceShields_29 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_30:
                        ForceShields_30 = Stream.Read.ForceShieldsData();
                        break;
                    case ShadowFieldIndex.ForceShields_31:
                        ForceShields_31 = Stream.Read.ForceShieldsData();
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


    public static class MyExtensions
    {
        public static ForceShieldsData ForceShieldsData(this Bitter.BinaryReader R)
        {
            return new ForceShieldsData(R);
        }

        public static ForceShieldsData[] ForceShieldsDataArray(this Bitter.BinaryReader R, int num)
        {
            List<ForceShieldsData> list = new List<ForceShieldsData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ForceShieldsData());
            }
            return list.ToArray();
        }
    }
    
}