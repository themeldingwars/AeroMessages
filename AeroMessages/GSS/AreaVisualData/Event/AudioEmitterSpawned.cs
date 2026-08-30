using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.V66.AreaVisualData.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssAreaVisualDataMessage.AudioEmitterSpawned, GssAreaVisualDataView.ObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class AudioEmitterSpawned
    {
        public long Unk1;
        public Vector3 Unk2; // Pos?
        public ushort Unk3; // ShortTime or some audio id?
    }
}