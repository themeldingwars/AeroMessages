using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 96)]
    public partial class ChallengeInvitation
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        public byte Unk3;
        public uint Unk4;
    }
}