using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.GlobalCounterUpdate, GssVersion.V1, GssVersion.V67)]
    public partial class GlobalCounterUpdate
    {
        [AeroString] public string Unk1;
        public ulong Unk2;
    }
}