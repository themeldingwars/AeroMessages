/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 137
    MsgName: DeactivateAbility
META_END
 */
[Aero]
public partial class Character_Command_DeactivateAbility
{
    public uint Time;
    public byte AbilitySlotIndex;
}