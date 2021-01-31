using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 25, 3, true)]
    public class AreaVisualDataForceShieldViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte
        {
            ForceShields_0,
            ForceShields_1,
            ForceShields_2,
            ForceShields_3,
            ForceShields_4,
            ForceShields_5,
            ForceShields_6,
            ForceShields_7,
            ForceShields_8,
            ForceShields_9,
            ForceShields_10,
            ForceShields_11,
            ForceShields_12,
            ForceShields_13,
            ForceShields_14,
            ForceShields_15,
            ForceShields_16,
            ForceShields_17,
            ForceShields_18,
            ForceShields_19,
            ForceShields_20,
            ForceShields_21,
            ForceShields_22,
            ForceShields_23,
            ForceShields_24,
            ForceShields_25,
            ForceShields_26,
            ForceShields_27,
            ForceShields_28,
            ForceShields_29,
            ForceShields_30,
            ForceShields_31,
        }

        public byte[] Bitfield;
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
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            if (true) {
                Bitfield = Stream.Read.BitArray(32);
                Position = Stream.Read.FloatArray(3);

                if (Bitfield[(int)BitfieldIndex.ForceShields_0] == 0)
                {
                    ForceShields_0 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_1] == 0)
                {
                    ForceShields_1 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_2] == 0)
                {
                    ForceShields_2 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_3] == 0)
                {
                    ForceShields_3 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_4] == 0)
                {
                    ForceShields_4 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_5] == 0)
                {
                    ForceShields_5 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_6] == 0)
                {
                    ForceShields_6 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_7] == 0)
                {
                    ForceShields_7 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_8] == 0)
                {
                    ForceShields_8 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_9] == 0)
                {
                    ForceShields_9 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_10] == 0)
                {
                    ForceShields_10 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_11] == 0)
                {
                    ForceShields_11 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_12] == 0)
                {
                    ForceShields_12 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_13] == 0)
                {
                    ForceShields_13 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_14] == 0)
                {
                    ForceShields_14 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_15] == 0)
                {
                    ForceShields_15 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_16] == 0)
                {
                    ForceShields_16 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_17] == 0)
                {
                    ForceShields_17 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_18] == 0)
                {
                    ForceShields_18 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_19] == 0)
                {
                    ForceShields_19 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_20] == 0)
                {
                    ForceShields_20 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_21] == 0)
                {
                    ForceShields_21 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_22] == 0)
                {
                    ForceShields_22 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_23] == 0)
                {
                    ForceShields_23 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_24] == 0)
                {
                    ForceShields_24 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_25] == 0)
                {
                    ForceShields_25 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_26] == 0)
                {
                    ForceShields_26 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_27] == 0)
                {
                    ForceShields_27 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_28] == 0)
                {
                    ForceShields_28 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_29] == 0)
                {
                    ForceShields_29 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_30] == 0)
                {
                    ForceShields_30 = Stream.Read.ForceShield();
                }

                if (Bitfield[(int)BitfieldIndex.ForceShields_31] == 0)
                {
                    ForceShields_31 = Stream.Read.ForceShield();
                }

                ScopeBubbleInfo = Stream.Read.ByteArray(8);
            }
        }
    }

    public struct ForceShield
    {
        // Need to verify
        public uint MaybeType;
        public float[] Position;
        public float[] Orientation;
        public float[] Direction;
        public byte Unk2;
        public byte[] HostilityInfo;

        public ForceShield(Bitter.BinaryReader R)
        {
            MaybeType = R.UInt();
            Position = R.HalfArray(3);
            Orientation = R.HalfArray(4);
            Direction = R.HalfArray(3);
            Unk2 = R.Byte();
            HostilityInfo = R.ByteArray(2);       
        }

        public override string ToString() => $"MaybeType: {MaybeType}, Position: [{(Position != null ? String.Join(", ", Position) : "null")}], Orientation: [{(Orientation != null ? String.Join(", ", Orientation) : "null")}], Direction: [{(Direction != null ? String.Join(", ", Direction) : "null")}], Unk2: {Unk2}, HostilityInfo: [{(HostilityInfo != null ? String.Join(", ", HostilityInfo) : "null")}]";
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