using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.NpcDevCmdResponse, GssVersion.V1, GssVersion.V74)]
    public partial class NpcDevCmdResponse
    {
        [AeroString] public string Unk1;
        [AeroString] public string Unk2;
    }
}