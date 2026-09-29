using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.PlaySoundIdAtLocation, GssVersion.V1, GssVersion.V74)]
    public partial class PlaySoundIdAtLocation
    {
        // > 0: sound id, <= 0: negated raw audio event id
        public long SoundId;
        public Vector3 Position;
    }
}