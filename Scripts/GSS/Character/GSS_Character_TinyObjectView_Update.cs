using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 13, 1, true)]
    public class CharacterTinyObjectViewUpdate : BaseScript
    {

        enum ShadowFieldIndex : byte
        {
            TinyObjects_0 = 0x00,
            TinyObjects_1 = 0x01,
            TinyObjects_2 = 0x02,
            TinyObjects_3 = 0x03,
            TinyObjects_4 = 0x04,
            TinyObjects_5 = 0x05,
            TinyObjects_6 = 0x06,
            TinyObjects_7 = 0x07,
            TinyObjects_8 = 0x08,
            TinyObjects_9 = 0x09,
            TinyObjects_10 = 0x0a,
            TinyObjects_11 = 0x0b,
            TinyObjects_12 = 0x0c,
            TinyObjects_13 = 0x0d,
            TinyObjects_14 = 0x0e,
            TinyObjects_15 = 0x0f,
            TinyObjects_16 = 0x10,
            TinyObjects_17 = 0x11,
            TinyObjects_18 = 0x12,
            TinyObjects_19 = 0x13,
            TinyObjects_20 = 0x14,
            TinyObjects_21 = 0x15,
            TinyObjects_22 = 0x16,
            TinyObjects_23 = 0x17,
            TinyObjects_24 = 0x18,
            TinyObjects_25 = 0x19,
            TinyObjects_26 = 0x1a,
            TinyObjects_27 = 0x1b,
            TinyObjects_28 = 0x1c,
            TinyObjects_29 = 0x1d,
            TinyObjects_30 = 0x1e,
            TinyObjects_31 = 0x1f,

            Clear_TinyObjects_0 = 0x80,
            Clear_TinyObjects_1 = 0x81,
            Clear_TinyObjects_2 = 0x82,
            Clear_TinyObjects_3 = 0x83,
            Clear_TinyObjects_4 = 0x84,
            Clear_TinyObjects_5 = 0x85,
            Clear_TinyObjects_6 = 0x86,
            Clear_TinyObjects_7 = 0x87,
            Clear_TinyObjects_8 = 0x88,
            Clear_TinyObjects_9 = 0x89,
            Clear_TinyObjects_10 = 0x8a,
            Clear_TinyObjects_11 = 0x8b,
            Clear_TinyObjects_12 = 0x8c,
            Clear_TinyObjects_13 = 0x8d,
            Clear_TinyObjects_14 = 0x8e,
            Clear_TinyObjects_15 = 0x8f,
            Clear_TinyObjects_16 = 0x90,
            Clear_TinyObjects_17 = 0x91,
            Clear_TinyObjects_18 = 0x92,
            Clear_TinyObjects_19 = 0x93,
            Clear_TinyObjects_20 = 0x94,
            Clear_TinyObjects_21 = 0x95,
            Clear_TinyObjects_22 = 0x96,
            Clear_TinyObjects_23 = 0x97,
            Clear_TinyObjects_24 = 0x98,
            Clear_TinyObjects_25 = 0x99,
            Clear_TinyObjects_26 = 0x9a,
            Clear_TinyObjects_27 = 0x9b,
            Clear_TinyObjects_28 = 0x9c,
            Clear_TinyObjects_29 = 0x9d,
            Clear_TinyObjects_30 = 0x9e,
            Clear_TinyObjects_31 = 0x9f,
        }

        public TinyObject? TinyObjects_0;
        public TinyObject? TinyObjects_1;
        public TinyObject? TinyObjects_2;
        public TinyObject? TinyObjects_3;
        public TinyObject? TinyObjects_4;
        public TinyObject? TinyObjects_5;
        public TinyObject? TinyObjects_6;
        public TinyObject? TinyObjects_7;
        public TinyObject? TinyObjects_8;
        public TinyObject? TinyObjects_9;
        public TinyObject? TinyObjects_10;
        public TinyObject? TinyObjects_11;
        public TinyObject? TinyObjects_12;
        public TinyObject? TinyObjects_13;
        public TinyObject? TinyObjects_14;
        public TinyObject? TinyObjects_15;
        public TinyObject? TinyObjects_16;
        public TinyObject? TinyObjects_17;
        public TinyObject? TinyObjects_18;
        public TinyObject? TinyObjects_19;
        public TinyObject? TinyObjects_20;
        public TinyObject? TinyObjects_21;
        public TinyObject? TinyObjects_22;
        public TinyObject? TinyObjects_23;
        public TinyObject? TinyObjects_24;
        public TinyObject? TinyObjects_25;
        public TinyObject? TinyObjects_26;
        public TinyObject? TinyObjects_27;
        public TinyObject? TinyObjects_28;
        public TinyObject? TinyObjects_29;
        public TinyObject? TinyObjects_30;
        public TinyObject? TinyObjects_31;

        public bool? Clear_TinyObjects_0;
        public bool? Clear_TinyObjects_1;
        public bool? Clear_TinyObjects_2;
        public bool? Clear_TinyObjects_3;
        public bool? Clear_TinyObjects_4;
        public bool? Clear_TinyObjects_5;
        public bool? Clear_TinyObjects_6;
        public bool? Clear_TinyObjects_7;
        public bool? Clear_TinyObjects_8;
        public bool? Clear_TinyObjects_9;
        public bool? Clear_TinyObjects_10;
        public bool? Clear_TinyObjects_11;
        public bool? Clear_TinyObjects_12;
        public bool? Clear_TinyObjects_13;
        public bool? Clear_TinyObjects_14;
        public bool? Clear_TinyObjects_15;
        public bool? Clear_TinyObjects_16;
        public bool? Clear_TinyObjects_17;
        public bool? Clear_TinyObjects_18;
        public bool? Clear_TinyObjects_19;
        public bool? Clear_TinyObjects_20;
        public bool? Clear_TinyObjects_21;
        public bool? Clear_TinyObjects_22;
        public bool? Clear_TinyObjects_23;
        public bool? Clear_TinyObjects_24;
        public bool? Clear_TinyObjects_25;
        public bool? Clear_TinyObjects_26;
        public bool? Clear_TinyObjects_27;
        public bool? Clear_TinyObjects_28;
        public bool? Clear_TinyObjects_29;
        public bool? Clear_TinyObjects_30;
        public bool? Clear_TinyObjects_31;

        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.TinyObjects_0:
                        TinyObjects_0 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_1:
                        TinyObjects_1 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_2:
                        TinyObjects_2 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_3:
                        TinyObjects_3 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_4:
                        TinyObjects_4 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_5:
                        TinyObjects_5 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_6:
                        TinyObjects_6 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_7:
                        TinyObjects_7 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_8:
                        TinyObjects_8 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_9:
                        TinyObjects_9 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_10:
                        TinyObjects_10 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_11:
                        TinyObjects_11 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_12:
                        TinyObjects_12 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_13:
                        TinyObjects_13 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_14:
                        TinyObjects_14 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_15:
                        TinyObjects_15 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_16:
                        TinyObjects_16 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_17:
                        TinyObjects_17 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_18:
                        TinyObjects_18 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_19:
                        TinyObjects_19 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_20:
                        TinyObjects_20 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_21:
                        TinyObjects_21 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_22:
                        TinyObjects_22 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_23:
                        TinyObjects_23 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_24:
                        TinyObjects_24 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_25:
                        TinyObjects_25 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_26:
                        TinyObjects_26 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_27:
                        TinyObjects_27 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_28:
                        TinyObjects_28 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_29:
                        TinyObjects_29 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_30:
                        TinyObjects_30 = Stream.Read.TinyObject();
                        break;
                    case ShadowFieldIndex.TinyObjects_31:
                        TinyObjects_31 = Stream.Read.TinyObject();
                        break;

                    case ShadowFieldIndex.Clear_TinyObjects_0:
                        Clear_TinyObjects_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_1:
                        Clear_TinyObjects_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_2:
                        Clear_TinyObjects_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_3:
                        Clear_TinyObjects_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_4:
                        Clear_TinyObjects_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_5:
                        Clear_TinyObjects_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_6:
                        Clear_TinyObjects_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_7:
                        Clear_TinyObjects_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_8:
                        Clear_TinyObjects_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_9:
                        Clear_TinyObjects_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_10:
                        Clear_TinyObjects_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_11:
                        Clear_TinyObjects_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_12:
                        Clear_TinyObjects_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_13:
                        Clear_TinyObjects_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_14:
                        Clear_TinyObjects_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_15:
                        Clear_TinyObjects_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_16:
                        Clear_TinyObjects_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_17:
                        Clear_TinyObjects_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_18:
                        Clear_TinyObjects_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_19:
                        Clear_TinyObjects_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_20:
                        Clear_TinyObjects_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_21:
                        Clear_TinyObjects_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_22:
                        Clear_TinyObjects_22 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_23:
                        Clear_TinyObjects_23 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_24:
                        Clear_TinyObjects_24 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_25:
                        Clear_TinyObjects_25 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_26:
                        Clear_TinyObjects_26 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_27:
                        Clear_TinyObjects_27 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_28:
                        Clear_TinyObjects_28 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_29:
                        Clear_TinyObjects_29 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_30:
                        Clear_TinyObjects_30 = true;
                        break;
                    case ShadowFieldIndex.Clear_TinyObjects_31:
                        Clear_TinyObjects_31 = true;
                        break;

                    default:
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

  
        }
    }

    public struct TinyObject
    {
        public ushort TypeId; // SDB Table 152
        public float[] Position;
        public byte[] Faction;

        public TinyObject(Bitter.BinaryReader R)
        {
            TypeId = R.UShort();
            Position = R.FloatArray(3);
            Faction = R.ByteArray(2);
        }

        public override string ToString() => $"TypeId: {TypeId}, Position: [{(Position != null ? String.Join(", ", Position) : "null")}, Faction: [{(Faction != null ? String.Join(", ", Faction) : "null")}]";
    }

    public static class MyExtensions
    {
        public static TinyObject TinyObject(this Bitter.BinaryReader R)
        {
            return new TinyObject(R);
        }

        public static TinyObject[] TinyObjectArray(this Bitter.BinaryReader R, int num)
        {
            List<TinyObject> list = new List<TinyObject>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.TinyObject());
            }
            return list.ToArray();
        }
    }
    
}