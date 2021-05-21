[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 107, Ver: 1962)]
public partial class CharacterCombatControllerDealtHit : AeroBase
{
    /*
    [Flags]
    public Enum DamageResponseFlags : byte
    {
        Critical = 0,
        Unk = 1,
        Effective = 3,
        Resisted = 4
    }
    */

    // There are some variations of this message that don't include target and/or dealer entity and I'm not sure the parsing works properly then.
    // TookHit has similiar variation.
    public byte HaveTargetEntity;
    [AeroIf(HaveTargetEntity, true)]
    public ulong TargetEntity;

    public byte HaveDealerEntity;
    [AeroIf(HaveDealerEntity, true)]
    public string DealerEntity;

    public uint DamageValue;

    [AeroSDB("dbcharacter::DamageType", "id")]
    public byte DamageType; // Sdb table 330, id column

    public byte Unk_3_byte;

    // Damage Response Flags
    // 1 - Critical
    // 2 - ???
    // 4 - Effective
    // 8 - Resisted
    // (Effective+Resisted => Immune)
    public byte DamageFlags;


}