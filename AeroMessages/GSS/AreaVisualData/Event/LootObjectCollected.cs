using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.V66.AreaVisualData.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssAreaVisualDataMessage.LootObjectCollected, GssAreaVisualDataView.LootObjectView, GssVersion.V1, GssVersion.V67)]
    public partial class LootObjectCollected // LootObjectView
    {
        public uint LootIndex;
        public EntityId LootedByEntity; // Could be the opposite
        public EntityId LootedToEntity; // Could be the opposite
    }
}