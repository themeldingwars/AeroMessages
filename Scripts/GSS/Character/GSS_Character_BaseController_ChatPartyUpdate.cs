[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 2, 169, Ver: 1962)]
public partial class CharacterBaseControllerChatPartyUpdate : AeroBase
{
   public ulong Begin_Entity;

   [AeroNullTermString]
   public string Begin_Name;

   [AeroArray(10)]
   public byte[] Unk1;

   [AeroArray(typeof(byte))]
   ChatPartyMember[] Members;

   public ulong End_Entity;
}


[Aero(AeroType.Block)]
public partial class ChatPartyMember : AeroBase
{
    public ulong EntityGUID;

    [AeroNullTermString]
    public string Name;

    public byte Unk; // Status?
}