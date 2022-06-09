using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 132)]
    public partial class Character_Event_SimulateLootPickup
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint LootSdbID;

        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}