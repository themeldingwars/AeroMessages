/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 11
    TypeName: Character::CombatView
    MsgId: 96
    MsgName: AbilityProjectileFired
META_END
 */
[Aero]
public partial class Character_Event_AbilityProjectileFired
{
    public ushort ShortTime;
    public ushort[] PackedUnk; // Could be a ruse, if not, what vector would this be???

    public ushort[] PackedAim; // TODO: Aero needs to unpack this to Vector3

    [AeroSDB("dbitems::Ammo", "id")] // Definition
    [AeroSDB("aptfs::FireProjectileCommandDef", "ammotype")] // Reference values, eg Range
    public ushort AmmoType;
    public float Range;

    [AeroArray(14)]
    public byte[] Unk1;

    public ushort Hardpoint;

    [AeroArray(2)]
    public byte[] Unk5;

    public byte UnkFlag;
    [AeroIf(nameof(UnkFlag), true)]
    public ulong UnkFlaggedEntity;
}