using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 249)]
    public partial class UpdateFriendStatus
    {
        [AeroString]
        public string TargetName;

        public byte Unk1;

        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)]
        [AeroString] public string Unk2;
    }
}