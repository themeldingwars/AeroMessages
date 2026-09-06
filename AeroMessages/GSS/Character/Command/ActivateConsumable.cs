using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ActivateConsumable, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class ActivateConsumable
    {
        public uint Time;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;
    }
}