using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 116)]
    public partial class GlobalCounterUpdate
    {
        [AeroString] public string Unk1;
        public ulong Unk2;
    }
}