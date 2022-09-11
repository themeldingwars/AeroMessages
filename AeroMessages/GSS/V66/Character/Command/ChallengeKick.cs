using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 99)]
    public partial class ChallengeKick
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
    }
}