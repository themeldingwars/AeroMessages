using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.UnslotAllModulesRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class UnslotAllModulesRequest
    {
        public ulong ItemGUID;
    }
}