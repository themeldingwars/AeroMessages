using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 138)]
    public partial class ActivateConsumable
    {
        public uint Time;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;
    }
}