[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 2, 111, Ver: 1962)]
public partial class CharacterBaseControllerCollectLoot : AeroBase
{
   public ulong LootEntityID;

   [AeroArray(4)]
   public byte Unk;

   [AeroSDB("dbitems:RootItem", "sdb_id")]
   public uint LootSdbID;
}