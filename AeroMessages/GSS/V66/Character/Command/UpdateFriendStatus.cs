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

        [AeroArray(2)]
        public byte[] Unk_Status;
    }
}