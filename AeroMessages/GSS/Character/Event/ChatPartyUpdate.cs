using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ChatPartyUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
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