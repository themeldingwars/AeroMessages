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
[Aero]
public partial class Character_Command_CollectLoot
{
   public ulong LootEntityID;

   [AeroArray(4)]
   public byte Unk;

   [AeroSDB("dbitems:RootItem", "sdb_id")]
   public uint LootSdbID;
}