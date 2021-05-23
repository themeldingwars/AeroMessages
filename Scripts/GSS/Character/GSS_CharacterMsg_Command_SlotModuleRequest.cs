/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 204
    MsgName: SlotModuleRequest
META_END
 */
[Aero]
public partial class Character_Command_SlotModuleRequest
{
    public ulong ItemGUID;

    [AeroArray(typeof(byte))]
    public SlotModuleRequest[] Modules;
}

[AeroBlock]
public struct SlotModuleRequest
{
    [AeroSDB("dbitems::RootItem", "sdb_id")]
    [AeroSDB("dbitems::ItemModuleSlots", "item_id")]
    public uint SdbId;

    [AeroSDB("dbitems::ItemModuleSlots", "slot_index")]
    public byte SlotIdx;
}