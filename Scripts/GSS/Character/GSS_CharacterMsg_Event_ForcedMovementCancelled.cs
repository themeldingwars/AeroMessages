/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 114
    MsgName: ForcedMovementCancelled
META_END
 */
[Aero]
public partial class CharacterCombat_Event_ForcedMovementCancelled
{

    [AeroSDB("apt::BaseCommandDef")]
    public uint CommandId;

    public ushort ShortTime;
}