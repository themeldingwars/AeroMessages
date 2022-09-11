using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 174)]
    public partial class TutorialStateUpdateEvt
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
    }
}