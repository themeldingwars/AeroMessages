using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.AreaVisualData.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssAreaVisualDataMessage.AudioEmitterSpawned, GssAreaVisualDataView.ObserverView, GssVersion.V1, GssVersion.V74)]
    public partial class AudioEmitterSpawned
    {
        public long SoundId; // negative: -SoundId is a raw audio event id, positive: looked up by the audio system
        public Vector3 Position;
        public ushort DurationSeconds;
    }
}