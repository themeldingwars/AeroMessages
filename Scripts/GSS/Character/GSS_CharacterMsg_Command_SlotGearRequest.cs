/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 206
    MsgName: SlotGearRequest
META_END
 */
[Aero]
public partial class Character_Command_SlotGearRequest
{
    public uint LoadoutId;
    public ulong ItemGUID;

    [AeroSDB("dbitems::LoadoutSlot", "id")]
    public byte SlotIdx;

    [AeroArray(4)]
    public byte[] Unk;
}