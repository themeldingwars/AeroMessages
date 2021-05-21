[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 150, Ver: 1962)]
public partial class CharacterBaseControllerSalvageResponse : AeroBase
{
    public byte Unk1;

    [AeroArray(typeof(byte))]
    public ItemSalvageResponse[] SalvageResponses;
}

[Aero(AeroType.Block)]
public partial class ItemSalvageResponse : AeroBase
{
    public ulong GUID;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint SdbId;

    public uint Quantity; // (Needed when stackables like modules are salvaged in bulk)
}