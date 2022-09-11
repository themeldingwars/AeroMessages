using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 158)]
    public partial class UnlockContentSuccess
    {
        [AeroString] public string Unk1;
        public uint Unk2;
        public ulong Unk3;
    }
}