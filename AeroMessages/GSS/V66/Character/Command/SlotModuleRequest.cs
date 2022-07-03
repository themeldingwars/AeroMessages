using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 204)]
    public partial class SlotModuleRequest
    {
        public ulong ItemGUID;

        [AeroArray(typeof(byte))]
        public SlotModuleRequestData[] Modules;
    }

    [AeroBlock]
    public struct SlotModuleRequestData
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        //[AeroSdb("dbitems::ItemModuleSlots", "item_id")]
        public uint SdbId;

        [AeroSdb("dbitems::ItemModuleSlots", "slot_index")]
        public byte SlotIdx;
    }
}