using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 50)]
    public partial class ChallengeKicked
    {
        public ulong ChallengeId; // Assumption
        [AeroString] public string Unk1;
        public ulong Unk2;
        [AeroString] public string Unk3;
    }
}