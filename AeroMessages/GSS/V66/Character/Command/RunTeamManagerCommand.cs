using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 232)]
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