using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 105)]
    public partial class ChallengeSetPowerPrivilege
    {
        public ulong Unk1;
        public ulong Unk2;
        public byte Unk3;
    }
}