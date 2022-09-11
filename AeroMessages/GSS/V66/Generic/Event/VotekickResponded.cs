using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 34)]
    public partial class VotekickResponded
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
        public sbyte Unk4;
        public ushort Unk5;
        public ushort Unk6;
    }
}