[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 202, Ver: 1962)]
public partial class CharacterBaseControllerSalvageRequest : AeroBase
{
    [AeroArray(typeof(byte))]
    public ItemSalvageRequest[] SalvageRequests;
}

[Aero(AeroType.Block)]
public partial class ItemSalvageRequest : AeroBase
{
    public ulong GUID;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint SdbId;

    public uint Quantity; // (Needed when stackables like modules are salvaged in bulk)
}