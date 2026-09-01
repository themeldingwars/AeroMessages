using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.CollectLoot, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class CollectLoot
    {
        public EntityId LootObjectView;
        public uint LootObjectIndex;

        [AeroSdb("dbitems:RootItem", "sdb_id")]
        public uint ItemSdbId;
    }
}