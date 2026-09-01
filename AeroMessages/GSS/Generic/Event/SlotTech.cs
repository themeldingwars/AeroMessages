using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.SlotTech, GssVersion.V1, GssVersion.V67)]
    public partial class SlotTech
    {
        public uint Unk; // sdbid?
    }
}