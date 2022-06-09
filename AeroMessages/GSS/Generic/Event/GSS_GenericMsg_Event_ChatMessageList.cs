using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 118)]
    public partial class Generic_Event_ChatMessageList
    {
        public byte Unk1;
        public EntityId SenderId;

        [AeroString]
        public string SenderName;

        [AeroString]
        public string Message;

        public byte Channel;
    }
}