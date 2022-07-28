using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 100)]
    public partial class ChallengeSetReady
    {
        [AeroArray(8)] public byte[] Unk1;
        public byte Unk2; // Ready state?
    }
}