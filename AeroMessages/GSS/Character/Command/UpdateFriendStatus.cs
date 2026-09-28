using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.UpdateFriendStatus, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class UpdateFriendStatus
    {
        [AeroString]
        public string TargetName;

        public sbyte Add;

        public byte HaveNote;
        [AeroIf(nameof(HaveNote), 1)]
        [AeroString] public string Note;
    }
}