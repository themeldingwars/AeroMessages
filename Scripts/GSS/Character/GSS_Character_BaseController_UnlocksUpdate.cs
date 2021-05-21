[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 130, Ver: 1962)]
public partial class CharacterBaseControllerUnlocksUpdate : AeroBase
{
    public byte ClearExistingData; // 1 for full update, 0 for partitial

    [AeroArray(typeof(byte))]
    public UnlockGroup[] Groups;
}

[Aero(AeroType.Block)]
public partial class UnlockGroup : AeroBase
{
    [AeroNullTermString]
    public string Key;

    [AeroArray(typeof(byte))] // TODO: Aero needs support for handling additional bytes if size is 255
    UnlockGroupEntry[] Entries;

    public byte UnkEndOfKeyByte;
}

[Aero(AeroType.Block)]
public partial class UnlockGroupEntry : AeroBase
{
    [AeroSDB("dbitems::Certificate", "id")]
    public uint CertId;

    [AeroArray(typeof(byte))]
    public uint[] Unk1_Data;

    [AeroArray(typeof(byte))]
    public uint[] Unk2_Data;

    [AeroArray(typeof(byte))]
    public uint[] Unk3_Data;
}
