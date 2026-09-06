using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SetMovementSimulation, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SetMovementSimulation
    {
        public ushort UpdatePeriodMax; // network.updatePeriodMax
    }
}