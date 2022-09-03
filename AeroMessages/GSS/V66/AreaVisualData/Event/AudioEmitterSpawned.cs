using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.V66.AreaVisualData.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 20, 84)] // Assuming its on the ObserverView?
    public partial class AudioEmitterSpawned
    {
        public long Unk1;
        public Vector3 Unk2; // Pos?
        public ushort Unk3; // ShortTime or some audio id?
    }
}