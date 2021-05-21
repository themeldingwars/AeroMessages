[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 204, Ver: 1962)]
public partial class CharacterBaseControllerSlotModuleRequest : AeroBase
{
    public ulong ItemGUID;

    [AeroArray(typeof(byte))]
    public SlotModuleRequest[] Modules;
}

[Aero(AeroType.Block)]
public partial class SlotModuleRequest : AeroBase
{
    [AeroSDB("dbitems::RootItem", "sdb_id")]
    [AeroSDB("dbitems::ItemModuleSlots", "item_id")]
    public uint SdbId;

    [AeroSDB("dbitems::ItemModuleSlots", "slot_index")]
    public byte SlotIdx;
}