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
[Aero]
public partial class Vehicle_Event_AbilityActivated
{
    [AeroSDB("apt::AbilityData", "id")]
    public uint AbilityId;

    public uint Time;
}