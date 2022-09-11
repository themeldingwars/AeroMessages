using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 104)]
    public partial class ChallengeSetMatchParameters
    {
        public ulong Unk1;
        public uint Unk2;
    }
}