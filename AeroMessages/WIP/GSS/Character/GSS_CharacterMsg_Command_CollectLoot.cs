/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 111
    MsgName: CollectLoot
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
  [Aero]
  public partial class Character_Command_CollectLoot
  {
     public EntityId LootEntityID;

     [AeroArray(4)]
     public byte Unk;

     [AeroSDB("dbitems:RootItem", "sdb_id")]
     public uint LootSdbID;
  }
}