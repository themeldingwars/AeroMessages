/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 28
    TypeName: Vehicle::CombatController
    MsgId: 84
    MsgName: AbilityFailed
META_END
 */
[Aero]
public partial class Vehicle_Event_AbilityFailed
{
    [AeroSDB("apt::AbilityData", "id")]
    public uint AbilityId;

    [AeroArray(4)]
    public byte[] Unk;
}