using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProximityTextChat, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ProximityTextChat, GssCharacterView.ObserverView, GssVersion.V74, GssVersion.V74)]
    public partial class ProximityTextChat
    {
        [AeroString] public string Message;
        public byte Channel; // 6 say, 7 yell
        public byte ChatIconFlags;
        public ChatMessageAlternateData AlternateData;
    }
}