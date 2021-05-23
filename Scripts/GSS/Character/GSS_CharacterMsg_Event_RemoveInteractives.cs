/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 124
    MsgName: RemoveInteractives
META_END
 */
[Aero]
public partial class Character_Event_RemoveInteractives
{
    //[AeroArray(typeof(byte))]
    //public ulong[] Entity;
    
    public byte Unk1; // TODO: Test if length
    public ulong Entity;
}