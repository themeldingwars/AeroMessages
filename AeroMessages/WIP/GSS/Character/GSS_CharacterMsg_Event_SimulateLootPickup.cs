/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 132
    MsgName: SimulateLootPickup
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_SimulateLootPickup
    {
        //[AeroSDB("dbitems::RootItem", "sdb_id")]
        public uint LootSdbID;

        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}