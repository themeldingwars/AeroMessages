/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 169
    MsgName: ChatPartyUpdate
META_END
 */
[Aero]
public partial class Character_Event_ChatPartyUpdate
{
   public ulong Begin_Entity;

   [AeroString]
   public string Begin_Name;

   [AeroArray(10)]
   public byte[] Unk1;

   [AeroArray(typeof(byte))]
   ChatPartyMember[] Members;

   public ulong End_Entity;
}


[AeroBlock]
public struct ChatPartyMember
{
    public ulong EntityGUID;

    [AeroString]
    public string Name;

    public byte Unk; // Status?
}