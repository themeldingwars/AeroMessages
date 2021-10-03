/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 28
    TypeName: Vehicle::CombatController
    MsgId: 83
    MsgName: AbilityActivated
META_END
 */
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