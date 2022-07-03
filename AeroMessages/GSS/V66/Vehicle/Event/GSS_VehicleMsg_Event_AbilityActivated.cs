using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 83)]
    public partial class AbilityActivated
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;

        public uint Time;
    }
}