using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.RefreshBounties, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class RefreshBounties
    {
        // Nothing to parse
    }
}