/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 95
    MsgName: WeaponProjectileFired
META_END
 */
[Aero]
public partial class Character_Event_WeaponProjectileFired
{
    public ushort ShortTime;

    [AeroArray(3)]
    public ushort[] PackedAim; // TODO: Aero needs to unpack to Vector3

    public byte Unk;
}