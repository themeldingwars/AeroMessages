using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 197)]
    public partial class SetMovementSimulation
    {
        public ushort UpdatePeriodMax; // network.updatePeriodMax
    }
}