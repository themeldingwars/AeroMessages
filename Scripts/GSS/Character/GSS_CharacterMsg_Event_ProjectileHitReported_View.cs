/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 11
    TypeName: Character::CombatView
    MsgId: 97
    MsgName: ProjectileHitReported
META_END
 */
[Aero]
public partial class Character_Event_ProjectileHitReported_View
{
    // TODO: Verify if same as controller or not
    public ushort Unk1; // Matches Unk1 in ReportProjectileHit?
    public ushort ShortTime; 
    public byte Unk2;
    public byte Unk3_Always1;
}