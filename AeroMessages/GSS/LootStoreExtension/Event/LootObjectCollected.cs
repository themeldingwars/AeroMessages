using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.LootStoreExtension.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssLootStoreExtensionMessage.LootObjectCollected, GssLootStoreExtensionView.LootObjectView, GssVersion.V18, GssVersion.V74)]
    public partial class LootObjectCollected // LootObjectView
    {
        public uint LootIndex; // Assumption
        public EntityId LootedByEntity; // Could be the opposite
        public EntityId LootedToEntity; // Could be the opposite
    }
}