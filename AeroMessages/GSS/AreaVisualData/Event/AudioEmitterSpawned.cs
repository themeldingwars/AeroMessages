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
        public long Unk1; // Low dword looks like a 32 bit hash, high dword always 0xFFFFFFFF
        public Vector3 Position;
        public ushort Unk3; // ShortTime or some audio id?
    }
}