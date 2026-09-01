using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.RunTeamManagerCommand, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class RunTeamManagerCommand
    {
        public enum TeamManagerCommandType : byte
        {
            Invite = 0,
            Accept = 1,
            Decline = 2,
            Change = 3,
            Create = 4,
            Kick = 5
        }
        public TeamManagerCommandType Type;
        [AeroString] public string Unk1;
        public byte Unk2;
    }
}