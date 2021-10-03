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
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 204)]
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