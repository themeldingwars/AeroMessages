using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.UnlockContentSuccess, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class UnlockContentSuccess
    {
        [AeroString] public string ContentType;
        public uint ContentId;
        public ulong Duration; // the client only passes the low 32 bits to Lua
    }
}