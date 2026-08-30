using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.RequestAllAchievements, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class RequestAllAchievements
    {
        // Nothing to parse
    }
}