using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.AiError, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)] // Not sure what controller it would be assoicated with
    public partial class AiError
    {
        [AeroString] public string Unk;
    }
}