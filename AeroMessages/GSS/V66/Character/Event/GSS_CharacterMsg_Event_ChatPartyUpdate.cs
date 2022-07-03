using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 169)]
    public partial class ChatPartyUpdate
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