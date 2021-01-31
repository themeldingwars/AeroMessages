using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
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

            Clear_ForceShields_0  = 0x81,
            Clear_ForceShields_1  = 0x82,
            Clear_ForceShields_2  = 0x83,
            Clear_ForceShields_3  = 0x84,
            Clear_ForceShields_4  = 0x85,
            Clear_ForceShields_5  = 0x86,
            Clear_ForceShields_6  = 0x87,
            Clear_ForceShields_7  = 0x88,
            Clear_ForceShields_8  = 0x89,
            Clear_ForceShields_9  = 0x8a,
            Clear_ForceShields_10 = 0x8b,
            Clear_ForceShields_11 = 0x8c,
            Clear_ForceShields_12 = 0x8d,
            Clear_ForceShields_13 = 0x8e,
            Clear_ForceShields_14 = 0x8f,
            Clear_ForceShields_15 = 0x90,
            Clear_ForceShields_16 = 0x91,
            Clear_ForceShields_17 = 0x92,
            Clear_ForceShields_18 = 0x93,
            Clear_ForceShields_19 = 0x94,
            Clear_ForceShields_20 = 0x95,
            Clear_ForceShields_21 = 0x96,
            Clear_ForceShields_22 = 0x97,
            Clear_ForceShields_23 = 0x98,
            Clear_ForceShields_24 = 0x99,
            Clear_ForceShields_25 = 0x9a,
            Clear_ForceShields_26 = 0x9b,
            Clear_ForceShields_27 = 0x9c,
            Clear_ForceShields_28 = 0x9d,
            Clear_ForceShields_29 = 0x9e,
            Clear_ForceShields_30 = 0x9f,
            Clear_ForceShields_31 = 0xa0,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public float[] Position;
        public ForceShield? ForceShields_0;
        public ForceShield? ForceShields_1;
        public ForceShield? ForceShields_2;
        public ForceShield? ForceShields_3;
        public ForceShield? ForceShields_4;
        public ForceShield? ForceShields_5;
        public ForceShield? ForceShields_6;
        public ForceShield? ForceShields_7;
        public ForceShield? ForceShields_8;
        public ForceShield? ForceShields_9;
        public ForceShield? ForceShields_10;
        public ForceShield? ForceShields_11;
        public ForceShield? ForceShields_12;
        public ForceShield? ForceShields_13;
        public ForceShield? ForceShields_14;
        public ForceShield? ForceShields_15;
        public ForceShield? ForceShields_16;
        public ForceShield? ForceShields_17;
        public ForceShield? ForceShields_18;
        public ForceShield? ForceShields_19;
        public ForceShield? ForceShields_20;
        public ForceShield? ForceShields_21;
        public ForceShield? ForceShields_22;
        public ForceShield? ForceShields_23;
        public ForceShield? ForceShields_24;
        public ForceShield? ForceShields_25;
        public ForceShield? ForceShields_26;
        public ForceShield? ForceShields_27;
        public ForceShield? ForceShields_28;
        public ForceShield? ForceShields_29;
        public ForceShield? ForceShields_30;
        public ForceShield? ForceShields_31;
        public byte[] ScopeBubbleInfo;
        public bool? Clear_ForceShields_0;
        public bool? Clear_ForceShields_1;
        public bool? Clear_ForceShields_2;
        public bool? Clear_ForceShields_3;
        public bool? Clear_ForceShields_4;
        public bool? Clear_ForceShields_5;
        public bool? Clear_ForceShields_6;
        public bool? Clear_ForceShields_7;
        public bool? Clear_ForceShields_8;
        public bool? Clear_ForceShields_9;
        public bool? Clear_ForceShields_10;
        public bool? Clear_ForceShields_11;
        public bool? Clear_ForceShields_12;
        public bool? Clear_ForceShields_13;
        public bool? Clear_ForceShields_14;
        public bool? Clear_ForceShields_15;
        public bool? Clear_ForceShields_16;
        public bool? Clear_ForceShields_17;
        public bool? Clear_ForceShields_18;
        public bool? Clear_ForceShields_19;
        public bool? Clear_ForceShields_20;
        public bool? Clear_ForceShields_21;
        public bool? Clear_ForceShields_22;
        public bool? Clear_ForceShields_23;
        public bool? Clear_ForceShields_24;
        public bool? Clear_ForceShields_25;
        public bool? Clear_ForceShields_26;
        public bool? Clear_ForceShields_27;
        public bool? Clear_ForceShields_28;
        public bool? Clear_ForceShields_29;
        public bool? Clear_ForceShields_30;
        public bool? Clear_ForceShields_31;


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.Position:
                        Position = Stream.Read.FloatArray(3);
                        break;
                    case ShadowFieldIndex.ForceShields_0:
                        ForceShields_0 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_1:
                        ForceShields_1 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_2:
                        ForceShields_2 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_3:
                        ForceShields_3 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_4:
                        ForceShields_4 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_5:
                        ForceShields_5 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_6:
                        ForceShields_6 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_7:
                        ForceShields_7 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_8:
                        ForceShields_8 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_9:
                        ForceShields_9 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_10:
                        ForceShields_10 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_11:
                        ForceShields_11 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_12:
                        ForceShields_12 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_13:
                        ForceShields_13 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_14:
                        ForceShields_14 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_15:
                        ForceShields_15 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_16:
                        ForceShields_16 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_17:
                        ForceShields_17 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_18:
                        ForceShields_18 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_19:
                        ForceShields_19 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_20:
                        ForceShields_20 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_21:
                        ForceShields_21 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_22:
                        ForceShields_22 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_23:
                        ForceShields_23 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_24:
                        ForceShields_24 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_25:
                        ForceShields_25 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_26:
                        ForceShields_26 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_27:
                        ForceShields_27 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_28:
                        ForceShields_28 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_29:
                        ForceShields_29 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_30:
                        ForceShields_30 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ForceShields_31:
                        ForceShields_31 = Stream.Read.ForceShield();
                        break;
                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.Clear_ForceShields_0:
                        Clear_ForceShields_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_1:
                        Clear_ForceShields_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_2:
                        Clear_ForceShields_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_3:
                        Clear_ForceShields_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_4:
                        Clear_ForceShields_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_5:
                        Clear_ForceShields_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_6:
                        Clear_ForceShields_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_7:
                        Clear_ForceShields_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_8:
                        Clear_ForceShields_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_9:
                        Clear_ForceShields_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_10:
                        Clear_ForceShields_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_11:
                        Clear_ForceShields_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_12:
                        Clear_ForceShields_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_13:
                        Clear_ForceShields_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_14:
                        Clear_ForceShields_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_15:
                        Clear_ForceShields_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_16:
                        Clear_ForceShields_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_17:
                        Clear_ForceShields_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_18:
                        Clear_ForceShields_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_19:
                        Clear_ForceShields_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_20:
                        Clear_ForceShields_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_21:
                        Clear_ForceShields_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_22:
                        Clear_ForceShields_22 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_23:
                        Clear_ForceShields_23 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_24:
                        Clear_ForceShields_24 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_25:
                        Clear_ForceShields_25 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_26:
                        Clear_ForceShields_26 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_27:
                        Clear_ForceShields_27 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_28:
                        Clear_ForceShields_28 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_29:
                        Clear_ForceShields_29 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_30:
                        Clear_ForceShields_30 = true;
                        break;
                    case ShadowFieldIndex.Clear_ForceShields_31:
                        Clear_ForceShields_31 = true;
                        break;

                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

  
        }
    }

    public struct ForceShield
    {
        // TODO:

        public ForceShield(Bitter.BinaryReader R)
        {
            
        }

        public override string ToString() => $"";
    }

    public static class MyExtensions
    {
        public static ForceShield ForceShield(this Bitter.BinaryReader R)
        {
            return new ForceShield(R);
        }

        public static ForceShield[] ForceShieldArray(this Bitter.BinaryReader R, int num)
        {
            List<ForceShield> list = new List<ForceShield>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ForceShield());
            }
            return list.ToArray();
        }
    }
    
}