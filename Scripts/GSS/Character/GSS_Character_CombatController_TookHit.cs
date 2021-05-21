[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 5, 105, Ver: 1962)]
public partial class CharacterCombatControllerTookHit : AeroBase
{
    // There are some variations of this message that don't include dealer entity.
    // DealtHit has similiar variations.
    // Maybe for fall dmg or similiar in this case.

    public byte HaveDealerEntity;

    [AeroIf(HaveDealerEntity, true)]
    public Type1Data Data;

    [AeroIf(HaveDealerEntity, false)]
    public Type0Data Data;
    
    // Always
    public ushort ShortTime;
    public byte Unk_Byte;
}

[Aero(AeroType.Block)]
public partial class Type1Data : AeroBase
{
    public ulong DealerEntity;

    public byte Unk_2_byte;
    public uint DamageValue;

    [AeroSDB("dbcharacter::DamageType", "id")]
    public byte DamageType;
    public byte Unk_3_byte;

    // Damage Response Flags
    // 1 - Critical
    // 2 - ???
    // 4 - Effective
    // 8 - Resisted
    // (Effective+Resisted => Immune)
    public byte DamageFlags;
}

[Aero(AeroType.Block)]
public partial class Type0Data : AeroBase
{
    [AeroArray(2)]
    public byte[] Unk;
}