using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ChallengeSetRoleAndTeam, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ChallengeSetRoleAndTeam
    {
        public ulong Unk1;
        public ulong Unk2;
        public byte Unk3;
        public byte Unk4;
    }
}