/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 24
    TypeName: AreaVisualData::LootObjectView
    MsgId: 83
    MsgName: LootObjectCollected
META_END
 */
[Aero]
public partial class AreaVisualData_LootObjectView_LootObjectCollected
{
    [AeroArray(4)]
    public byte[] Unk;

    public ulong LootedByEntity; // Could be the opposite
    public ulong LootedToEntity; // Could be the opposite
}