using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.UpdateFriendStatus, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class UpdateFriendStatus
    {
        [AeroString]
        public string TargetName;

        public sbyte Unk1;

        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)]
        [AeroString] public string Unk2;
    }
}