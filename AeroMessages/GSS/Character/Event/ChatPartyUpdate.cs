using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ChatPartyUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ChatPartyUpdate
    {
        public EntityId PartyId; // the leader's character id when the party was created
        [AeroString] public string LeaderName;
        public ChatPartyMember Member;

        [AeroArray(typeof(byte))]
        public ChatPartyMember[] Members;

        public EntityId LeaderId;
    }
}