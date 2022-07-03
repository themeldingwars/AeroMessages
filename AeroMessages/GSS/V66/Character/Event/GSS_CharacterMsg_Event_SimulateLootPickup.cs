using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 132)]
    public partial class SimulateLootPickup
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LootSdbID;

        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}