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
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.AreaVisualData
{
    [Aero]
    public partial class AreaVisualData_LootObjectView_LootObjectCollected
    {
        [AeroArray(4)]
        public byte[] Unk;

        public EntityId LootedByEntity; // Could be the opposite
        public EntityId LootedToEntity; // Could be the opposite
    }
}