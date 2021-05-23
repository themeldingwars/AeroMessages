/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 202
    MsgName: SalvageRequest
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_SalvageRequest
    {
        [AeroArray(typeof(byte))]
        public ItemSalvageRequest[] SalvageRequests;
    }

    [AeroBlock]
    public struct ItemSalvageRequest
    {
        public ulong GUID;

        [AeroSDB("dbitems::RootItem", "sdb_id")]
        public uint SdbId;

        public uint Quantity; // (Needed when stackables like modules are salvaged in bulk)
    }
}