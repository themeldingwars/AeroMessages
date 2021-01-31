using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 23, 3, true)]
    public class AreaVisualDataTinyObjectViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            TinyObjects_0,
            TinyObjects_1,
            TinyObjects_2,
            TinyObjects_3,
            TinyObjects_4,
            TinyObjects_5,
            TinyObjects_6,
            TinyObjects_7,
            TinyObjects_8,
            TinyObjects_9,
            TinyObjects_10,
            TinyObjects_11,
            TinyObjects_12,
            TinyObjects_13,
            TinyObjects_14,
            TinyObjects_15,
            TinyObjects_16,
            TinyObjects_17,
            TinyObjects_18,
            TinyObjects_19,
            TinyObjects_20,
            TinyObjects_21,
            TinyObjects_22,
            TinyObjects_23,
            TinyObjects_24,
            TinyObjects_25,
            TinyObjects_26,
            TinyObjects_27,
            TinyObjects_28,
            TinyObjects_29,
            TinyObjects_30,
            TinyObjects_31,
        }

        public byte[] Bitfield;

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

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Bitfield = Stream.Read.BitArray(32);

                if (Bitfield[(int)BitfieldIndex.TinyObjects_0] == 0)
                {
                    TinyObjects_0 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_1] == 0)
                {
                    TinyObjects_1 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_2] == 0)
                {
                    TinyObjects_2 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_3] == 0)
                {
                    TinyObjects_3 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_4] == 0)
                {
                    TinyObjects_4 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_5] == 0)
                {
                    TinyObjects_5 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_6] == 0)
                {
                    TinyObjects_6 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_7] == 0)
                {
                    TinyObjects_7 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_8] == 0)
                {
                    TinyObjects_8 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_9] == 0)
                {
                    TinyObjects_9 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_10] == 0)
                {
                    TinyObjects_10 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_11] == 0)
                {
                    TinyObjects_11 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_12] == 0)
                {
                    TinyObjects_12 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_13] == 0)
                {
                    TinyObjects_13 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_14] == 0)
                {
                    TinyObjects_14 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_15] == 0)
                {
                    TinyObjects_15 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_16] == 0)
                {
                    TinyObjects_16 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_17] == 0)
                {
                    TinyObjects_17 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_18] == 0)
                {
                    TinyObjects_18 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_19] == 0)
                {
                    TinyObjects_19 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_20] == 0)
                {
                    TinyObjects_20 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_21] == 0)
                {
                    TinyObjects_21 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_22] == 0)
                {
                    TinyObjects_22 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_23] == 0)
                {
                    TinyObjects_23 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_24] == 0)
                {
                    TinyObjects_24 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_25] == 0)
                {
                    TinyObjects_25 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_26] == 0)
                {
                    TinyObjects_26 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_27] == 0)
                {
                    TinyObjects_27 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_28] == 0)
                {
                    TinyObjects_28 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_29] == 0)
                {
                    TinyObjects_29 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_30] == 0)
                {
                    TinyObjects_30 = Stream.Read.TinyObject();
                }

                if (Bitfield[(int)BitfieldIndex.TinyObjects_31] == 0)
                {
                    TinyObjects_31 = Stream.Read.TinyObject();
                }
                
            }
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