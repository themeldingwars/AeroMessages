using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 60)]
    public partial class NpcDevCmdResponse
    {
        [AeroString] public string Unk1;
        [AeroString] public string Unk2;
    }
}