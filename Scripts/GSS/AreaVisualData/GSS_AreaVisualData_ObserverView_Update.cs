using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 20, 1, true)]
    public class AreaVisualDataObserverViewUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            Position        = 0x00,
            ScopeBubbleInfo = 0x01,
            ContextFlags_0  = 0x02,
            ContextFlags_1  = 0x03,
            ContextFlags_2  = 0x04,
            ContextFlags_3  = 0x05,
            ContextFlags_4  = 0x06,
            ContextFlags_5  = 0x07,
            ContextFlags_6  = 0x08,
            ContextFlags_7  = 0x09,
            ContextFlags_8  = 0x0a,
            ContextFlags_9  = 0x0b,
            ContextFlags_10 = 0x0c,
            ContextFlags_11 = 0x0d,
            ContextFlags_12 = 0x0e,
            ContextFlags_13 = 0x0f,
            ContextFlags_14 = 0x10,
            ContextFlags_15 = 0x11,
            ContextFlags_16 = 0x12,
            ContextFlags_17 = 0x13,
            ContextFlags_18 = 0x14,
            ContextFlags_19 = 0x15,
            ContextFlags_20 = 0x16,
            ContextFlags_21 = 0x17,
            ContextFlags_22 = 0x18,
            ContextFlags_23 = 0x19,
            ContextTeams_0  = 0x1a,
            ContextTeams_1  = 0x1b,
            ContextTeams_2  = 0x1c,
            ContextTeams_3  = 0x1d,

            Clear_ContextFlags_0  =  0x82,
            Clear_ContextFlags_1  =  0x83,
            Clear_ContextFlags_2  =  0x84,
            Clear_ContextFlags_3  =  0x85,
            Clear_ContextFlags_4  =  0x86,
            Clear_ContextFlags_5  =  0x87,
            Clear_ContextFlags_6  =  0x88,
            Clear_ContextFlags_7  =  0x89,
            Clear_ContextFlags_8  =  0x8a,
            Clear_ContextFlags_9  =  0x8b,
            Clear_ContextFlags_10 =  0x8c,
            Clear_ContextFlags_11 =  0x8d,
            Clear_ContextFlags_12 =  0x8e,
            Clear_ContextFlags_13 =  0x8f,
            Clear_ContextFlags_14 =  0x90,
            Clear_ContextFlags_15 =  0x91,
            Clear_ContextFlags_16 =  0x92,
            Clear_ContextFlags_17 =  0x93,
            Clear_ContextFlags_18 =  0x94,
            Clear_ContextFlags_19 =  0x95,
            Clear_ContextFlags_20 =  0x96,
            Clear_ContextFlags_21 =  0x97,
            Clear_ContextFlags_22 =  0x98,
            Clear_ContextFlags_23 =  0x99,
            Clear_ContextTeams_0  =  0x9a,
            Clear_ContextTeams_1  =  0x9b,
            Clear_ContextTeams_2  =  0x9c,
            Clear_ContextTeams_3  =  0x9d,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

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

        public bool? Clear_ContextFlags_0;
        public bool? Clear_ContextFlags_1;
        public bool? Clear_ContextFlags_2;
        public bool? Clear_ContextFlags_3;
        public bool? Clear_ContextFlags_4;
        public bool? Clear_ContextFlags_5;
        public bool? Clear_ContextFlags_6;
        public bool? Clear_ContextFlags_7;
        public bool? Clear_ContextFlags_8;
        public bool? Clear_ContextFlags_9;
        public bool? Clear_ContextFlags_10;
        public bool? Clear_ContextFlags_11;
        public bool? Clear_ContextFlags_12;
        public bool? Clear_ContextFlags_13;
        public bool? Clear_ContextFlags_14;
        public bool? Clear_ContextFlags_15;
        public bool? Clear_ContextFlags_16;
        public bool? Clear_ContextFlags_17;
        public bool? Clear_ContextFlags_18;
        public bool? Clear_ContextFlags_19;
        public bool? Clear_ContextFlags_20;
        public bool? Clear_ContextFlags_21;
        public bool? Clear_ContextFlags_22;
        public bool? Clear_ContextFlags_23;
        public bool? Clear_ContextTeams_0;
        public bool? Clear_ContextTeams_1;
        public bool? Clear_ContextTeams_2;
        public bool? Clear_ContextTeams_3;

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
                    case ShadowFieldIndex.ScopeBubbleInfo:
                        ScopeBubbleInfo = Stream.Read.ByteArray(8);
                        break;

                    case ShadowFieldIndex.ContextFlags_0:
                        ContextFlags_0 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_1:
                        ContextFlags_1 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_2:
                        ContextFlags_2 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_3:
                        ContextFlags_3 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_4:
                        ContextFlags_4 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_5:
                        ContextFlags_5 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_6:
                        ContextFlags_6 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_7:
                        ContextFlags_7 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_8:
                        ContextFlags_8 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_9:
                        ContextFlags_9 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_10:
                        ContextFlags_10 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_11:
                        ContextFlags_11 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_12:
                        ContextFlags_12 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_13:
                        ContextFlags_13 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_14:
                        ContextFlags_14 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_15:
                        ContextFlags_15 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_16:
                        ContextFlags_16 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_17:
                        ContextFlags_17 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_18:
                        ContextFlags_18 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_19:
                        ContextFlags_19 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_20:
                        ContextFlags_20 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_21:
                        ContextFlags_21 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_22:
                        ContextFlags_22 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextFlags_23:
                        ContextFlags_23 = Stream.Read.ContextFlag();
                        break;
                    case ShadowFieldIndex.ContextTeams_0:
                        ContextTeams_0 = Stream.Read.ContextTeam();
                        break;
                    case ShadowFieldIndex.ContextTeams_1:
                        ContextTeams_1 = Stream.Read.ContextTeam();
                        break;
                    case ShadowFieldIndex.ContextTeams_2:
                        ContextTeams_2 = Stream.Read.ContextTeam();
                        break;
                    case ShadowFieldIndex.ContextTeams_3:
                        ContextTeams_3 = Stream.Read.ContextTeam();
                        break;

                    case ShadowFieldIndex.Clear_ContextFlags_0:
                        Clear_ContextFlags_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_1:
                        Clear_ContextFlags_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_2:
                        Clear_ContextFlags_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_3:
                        Clear_ContextFlags_3 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_4:
                        Clear_ContextFlags_4 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_5:
                        Clear_ContextFlags_5 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_6:
                        Clear_ContextFlags_6 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_7:
                        Clear_ContextFlags_7 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_8:
                        Clear_ContextFlags_8 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_9:
                        Clear_ContextFlags_9 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_10:
                        Clear_ContextFlags_10 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_11:
                        Clear_ContextFlags_11 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_12:
                        Clear_ContextFlags_12 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_13:
                        Clear_ContextFlags_13 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_14:
                        Clear_ContextFlags_14 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_15:
                        Clear_ContextFlags_15 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_16:
                        Clear_ContextFlags_16 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_17:
                        Clear_ContextFlags_17 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_18:
                        Clear_ContextFlags_18 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_19:
                        Clear_ContextFlags_19 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_20:
                        Clear_ContextFlags_20 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_21:
                        Clear_ContextFlags_21 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_22:
                        Clear_ContextFlags_22 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextFlags_23:
                        Clear_ContextFlags_23 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextTeams_0:
                        Clear_ContextTeams_0 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextTeams_1:
                        Clear_ContextTeams_1 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextTeams_2:
                        Clear_ContextTeams_2 = true;
                        break;
                    case ShadowFieldIndex.Clear_ContextTeams_3:
                        Clear_ContextTeams_3 = true;
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