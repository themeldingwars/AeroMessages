/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 123
    MsgName: SelectFireMode
META_END
 */
[Aero]
public partial class Character_Command_SelectFireMode
{
    public uint Time;
    public byte FireMode;
}