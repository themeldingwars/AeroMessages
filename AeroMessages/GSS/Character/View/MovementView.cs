using Aero.Gen.Attributes;
using Aero.Protocol;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterView.MovementView, GssVersion.V1, GssVersion.V67)]
    public partial class MovementView
    {
        private MovementData Movement;
    }
}