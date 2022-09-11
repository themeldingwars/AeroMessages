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
        [AeroString] public string Begin_Name;
        public ulong Begin_Long;
        [AeroString] public string Begin_String2;
        public byte Begin_Byte;

        [AeroArray(typeof(byte))]
        public ChatPartyMember[] Members;

        public EntityId End_Entity;
    }
}