using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.V66.LootStoreExtension.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 53, 83)]
    public partial class LootObjectCollected // LootObjectView
    {
        public uint Unk1;
        public EntityId LootedByEntity; // Could be the opposite
        public EntityId LootedToEntity; // Could be the opposite
    }
}