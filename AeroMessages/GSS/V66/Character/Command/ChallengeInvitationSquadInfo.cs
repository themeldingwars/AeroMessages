using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 98)]
    public partial class ChallengeInvitationSquadInfo
    {
        public ulong Unk1;
        public ulong Unk2;
        [AeroString] public string Unk3;
        [AeroArray(typeof(byte))] public ulong[] Unk4;
    }
}