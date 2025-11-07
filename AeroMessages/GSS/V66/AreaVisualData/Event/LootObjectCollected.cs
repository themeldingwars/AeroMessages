using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.V66.AreaVisualData.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 24, 83)]
    public partial class LootObjectCollected // LootObjectView
    {
        public uint LootIndex;
        public EntityId LootedByEntity; // Could be the opposite
        public EntityId LootedToEntity; // Could be the opposite
    }
}