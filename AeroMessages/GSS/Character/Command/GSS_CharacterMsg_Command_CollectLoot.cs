using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
  [Aero]
  [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 111)]
  public partial class Character_Command_CollectLoot
  {
     public EntityId LootEntityID;

     [AeroArray(4)]
     public byte[] Unk;

     [AeroSdb("dbitems:RootItem", "sdb_id")]
     public uint LootSdbID;
  }
}