/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 207
    MsgName: SlotVisualRequest
META_END
 */
[Aero]
public partial class Character_Command_SlotVisualRequest
{
    public uint LoadoutId;

    [AeroSDB("dbitems::RootItem", "sdb_id")]
    public uint ItemSdbId;

    public byte SlotIdx1; // ?
    public byte SlotIdx2; // ?

    [AeroArray(9)]
    public byte[] Unk;
}