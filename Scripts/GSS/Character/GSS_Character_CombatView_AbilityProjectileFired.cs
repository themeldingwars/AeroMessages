[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 11, 96, Ver: 1962)]
public partial class CharacterCombatViewAbilityProjectileFired : AeroBase
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
    [AeroIf(UnkFlag, true)]
    public ulong UnkFlaggedEntity;
}