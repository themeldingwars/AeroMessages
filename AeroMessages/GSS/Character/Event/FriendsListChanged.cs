using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.FriendsListChanged, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FriendsListChanged
    {
        [AeroString] public string Name;
        public uint StatusCode; // HTTP style, 200 or 404
        public byte Added;
        public byte Removed;
        public byte Success;
    }
}