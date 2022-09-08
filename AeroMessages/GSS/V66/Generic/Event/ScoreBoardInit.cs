using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 36)]
    public partial class ScoreBoardInit
    {   
        [AeroArray(typeof(byte))] public ScoreBoardInitData[] Unk1;
        public sbyte Unk2;
        public sbyte Unk3;
        public byte Unk4;
        public sbyte Unk5;
        [AeroString] public string Unk6;
    }

    [AeroBlock]
    public struct ScoreBoardInitData
    {
        public ulong Unk1;
        public ulong Unk2;
        [AeroString] public string Unk3;
        public float Unk4;
        public byte Unk5;
        public uint Unk6;
        public byte Unk7;
        public byte Unk8;
        public sbyte Unk9;
        public byte Unk10;
        public ScoreBoardData1 Unk11;
        [AeroArray(typeof(byte))] public ScoreBoardData3[] Unk12;
        public uint Unk13;
        public sbyte Unk14;
        [AeroArray(typeof(byte))] public ScoreBoardData1[] Unk15; // 00c53610
    }

    [AeroBlock]
    public struct ScoreBoardData1
    {
        // 00c52e90
        [AeroArray(18)] public uint[] Unk1;
        [AeroArray(typeof(byte))] public ScoreBoardData2[] Unk2;
        public uint Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct ScoreBoardData2
    {
        // 00c52d00
        public byte Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
    }

    [AeroBlock]
    public struct ScoreBoardData3
    {
        // 00c52520
        public int Unk1;
        public int Unk2;
        public int Unk3;
    }
}