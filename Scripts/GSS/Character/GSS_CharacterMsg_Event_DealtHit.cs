/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 107
    MsgName: DealtHit
META_END
 */
public partial class Character_Event_DealtHit
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
    [AeroIf(nameof(HaveTargetEntity), true)]
    public ulong TargetEntity;

    public byte HaveDealerEntity;
    [AeroIf(nameof(HaveDealerEntity), true)]
    public ulong DealerEntity;

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