using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ApplyCameraShake, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ApplyCameraShake
    {
        public ulong Unk1; // with StartTime the key to remove the shake again
        public uint StartTime; // game time in ms
        public float InitialShake;
        public float FinalShake;
        public uint LifetimeMs; // 0 = constant InitialShake without fading
        public uint FadeTimeMs;
    }
}