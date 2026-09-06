using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ChallengeSetPowerPrivilege, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ChallengeSetPowerPrivilege
    {
        public ulong Unk1;
        public ulong Unk2;
        public sbyte Unk3;
    }
}