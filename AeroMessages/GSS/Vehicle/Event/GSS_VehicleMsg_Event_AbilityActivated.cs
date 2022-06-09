using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 83)]
    public partial class Vehicle_Event_AbilityActivated
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;

        public uint Time;
    }
}