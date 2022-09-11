using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 33)]
    public partial class VotekickInitiated
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
        public uint Unk4;
        public ulong Unk5;
        public sbyte Unk6;
    }
}