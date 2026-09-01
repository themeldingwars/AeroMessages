using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.FindNearbyResourceAreas, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class FindNearbyResourceAreas
    {
        // Nothing to parse
    }
}