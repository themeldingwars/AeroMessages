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
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_ChatPartyUpdate
    {
        public EntityId Begin_Entity;

        [AeroString]
        public string Begin_Name;

        [AeroArray(10)]
        public byte[] Unk1;

        [AeroArray(typeof(byte))]
        ChatPartyMember[] Members;

        public EntityId End_Entity;
    }


    [AeroBlock]
    public struct ChatPartyMember
    {
        public EntityId Id;

        [AeroString]
        public string Name;

        public byte Unk; // Status?
    }
}