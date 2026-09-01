using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ResetAllEliteLevelsUpgrades_Debug, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ResetAllEliteLevelsUpgradesDebug
    {
        // Nothing to parse
    }
}