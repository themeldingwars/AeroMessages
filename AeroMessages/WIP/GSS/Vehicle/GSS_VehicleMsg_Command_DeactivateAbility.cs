/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 28
    TypeName: Vehicle::CombatController
    MsgId: 88
    MsgName: ActivateAbility
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    public partial class Vehicle_Command_DeactivateAbility
    {
        public uint Time;
        public byte AbilityIdx; // 0x05 == Honk, 0x08 == SIN, lookup in vehicle components
    }
}