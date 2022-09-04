using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 84)]
    public partial class ContentUnlocked
    {
        [AeroString] public string Unk1;
        public uint Unk2;
        public ulong Unk3;
    }
}