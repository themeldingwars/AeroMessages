using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 20, 3, true)]
    public class AreaVisualDataObserverViewKeyframe : BaseScript
    {
        enum BitfieldIndex : byte // This is a bit of an assumption and needs to be verified
        {
            ContextFlags_0,
            ContextFlags_1,
            ContextFlags_2,
            ContextFlags_3,
            ContextFlags_4,
            ContextFlags_5,
            ContextFlags_6,
            ContextFlags_7,
            ContextFlags_8,
            ContextFlags_9,
            ContextFlags_10,
            ContextFlags_11,
            ContextFlags_12,
            ContextFlags_13,
            ContextFlags_14,
            ContextFlags_15,
            ContextFlags_16,
            ContextFlags_17,
            ContextFlags_18,
            ContextFlags_19,
            ContextFlags_20,
            ContextFlags_21,
            ContextFlags_22,
            ContextFlags_23,
            ContextTeams_0,
            ContextTeams_1,
            ContextTeams_2,
            ContextTeams_3,
        }

        public string PeepWarning;

        public byte[] Bitfield;
        public float[] Position;
        public byte[] ScopeBubbleInfo;
        public ContextFlag ContextFlags_0;
        public ContextFlag ContextFlags_1;
        public ContextFlag ContextFlags_2;
        public ContextFlag ContextFlags_3;
        public ContextFlag ContextFlags_4;
        public ContextFlag ContextFlags_5;
        public ContextFlag ContextFlags_6;
        public ContextFlag ContextFlags_7;
        public ContextFlag ContextFlags_8;
        public ContextFlag ContextFlags_9;
        public ContextFlag ContextFlags_10;
        public ContextFlag ContextFlags_11;
        public ContextFlag ContextFlags_12;
        public ContextFlag ContextFlags_13;
        public ContextFlag ContextFlags_14;
        public ContextFlag ContextFlags_15;
        public ContextFlag ContextFlags_16;
        public ContextFlag ContextFlags_17;
        public ContextFlag ContextFlags_18;
        public ContextFlag ContextFlags_19;
        public ContextFlag ContextFlags_20;
        public ContextFlag ContextFlags_21;
        public ContextFlag ContextFlags_22;
        public ContextFlag ContextFlags_23;
        public ContextTeam ContextTeams_0;
        public ContextTeam ContextTeams_1;
        public ContextTeam ContextTeams_2;
        public ContextTeam ContextTeams_3;


        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;

            Bitfield = Stream.Read.BitArray(32);
            Position = Stream.Read.FloatArray(3);
            ScopeBubbleInfo = Stream.Read.ByteArray(8);

            if (Bitfield[(int)BitfieldIndex.ContextFlags_0] == 0)
                ContextFlags_0 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_1] == 0)
                ContextFlags_1 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_2] == 0)
                ContextFlags_2 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_3] == 0)
                ContextFlags_3 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_4] == 0)
                ContextFlags_4 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_5] == 0)
                ContextFlags_5 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_6] == 0)
                ContextFlags_6 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_7] == 0)
                ContextFlags_7 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_8] == 0)
                ContextFlags_8 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_9] == 0)
                ContextFlags_9 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_10] == 0)
                ContextFlags_10 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_11] == 0)
                ContextFlags_11 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_12] == 0)
                ContextFlags_12 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_13] == 0)
                ContextFlags_13 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_14] == 0)
                ContextFlags_14 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_15] == 0)
                ContextFlags_15 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_16] == 0)
                ContextFlags_16 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_17] == 0)
                ContextFlags_17 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_18] == 0)
                ContextFlags_18 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_19] == 0)
                ContextFlags_19 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_20] == 0)
                ContextFlags_20 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_21] == 0)
                ContextFlags_21 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_22] == 0)
                ContextFlags_22 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextFlags_23] == 0)
                ContextFlags_23 = Stream.Read.ContextFlag();

            if (Bitfield[(int)BitfieldIndex.ContextTeams_0] == 0)
                ContextTeams_0 = Stream.Read.ContextTeam();

            if (Bitfield[(int)BitfieldIndex.ContextTeams_1] == 0)
                ContextTeams_1 = Stream.Read.ContextTeam();

            if (Bitfield[(int)BitfieldIndex.ContextTeams_2] == 0)
                ContextTeams_2 = Stream.Read.ContextTeam();

            if (Bitfield[(int)BitfieldIndex.ContextTeams_3] == 0)
                ContextTeams_3 = Stream.Read.ContextTeam();

        }
    }

    public struct ContextFlag
    {

        public ContextFlag(Bitter.BinaryReader R)
        {

        }

        public override string ToString() => $"ContextFlag";
    }

    public struct ContextTeam
    {

        public ContextTeam(Bitter.BinaryReader R)
        {

        }

        public override string ToString() => $"ContextTeam";
    }

    public static class MyExtensions
    {
        public static ContextFlag ContextFlag(this Bitter.BinaryReader R)
        {
            return new ContextFlag(R);
        }

        public static ContextFlag[] ContextFlagArray(this Bitter.BinaryReader R, int num)
        {
            List<ContextFlag> list = new List<ContextFlag>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ContextFlag());
            }
            return list.ToArray();
        }

        public static ContextTeam ContextTeam(this Bitter.BinaryReader R)
        {
            return new ContextTeam(R);
        }

        public static ContextTeam[] ContextTeamArray(this Bitter.BinaryReader R, int num)
        {
            List<ContextTeam> list = new List<ContextTeam>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.ContextTeam());
            }
            return list.ToArray();
        }
    }
}