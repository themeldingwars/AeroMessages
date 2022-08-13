using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 102)]
    public partial class ChallengeSwapTeam
    {
        public ulong Unk1;
        public ulong Unk2;
        public ulong Unk3;
    }
}