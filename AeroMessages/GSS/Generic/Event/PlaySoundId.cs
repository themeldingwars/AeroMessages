using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.PlaySoundId, GssVersion.V1, GssVersion.V74)]
    public partial class PlaySoundId
    {
        // > 0: sound id, <= 0: negated raw audio event id
        public long SoundId;
        public ulong SourceEntity; // 0 = not positional
    }
}