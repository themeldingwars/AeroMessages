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
        public uint LootIndex; // slot in LootObjects_0..23
        public EntityId LootedByEntity; // the loot flies to this entity
        public EntityId LootedToEntity; // who gets the item
    }
}