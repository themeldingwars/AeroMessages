using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 39)]
    public partial class ScoreBoardAddPlayer
    {   
        public ulong Unk1;
        public ulong Unk2;
        [AeroString] public string Unk3;
        public float Unk4;
        public byte Unk5;
        public uint Unk6;
        public byte Unk7;
        public byte Unk8; // Separate read func
        public sbyte Unk9;
        public byte Unk10;
    }
}