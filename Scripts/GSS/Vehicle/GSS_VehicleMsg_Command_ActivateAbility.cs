/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 28
    TypeName: Vehicle::CombatController
    MsgId: 87
    MsgName: ActivateAbility
META_END
 */
[Aero]
public partial class Vehicle_Command_ActivateAbility
{
    public uint Time;
    public byte AbilityIdx; // 0x05 == Honk, 0x08 == SIN, lookup in vehicle components

    [AeroArray(2)]
    public byte[] Unk;
}