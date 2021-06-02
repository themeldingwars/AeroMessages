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
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
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
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        //[AeroSdb("dbitems::ItemModuleSlots", "item_id")]
        public uint SdbId;

        [AeroSdb("dbitems::ItemModuleSlots", "slot_index")]
        public byte SlotIdx;
    }
}