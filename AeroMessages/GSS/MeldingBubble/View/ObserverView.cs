using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.MeldingBubble.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMeldingBubbleView.ObserverView, GssVersion.V1, GssVersion.V74)]
    public partial class ObserverView
    {
        private PositionStruct Position;
        private RadiusStruct Radius;
        private byte BubbleType;
        private byte FxFlags;
        private ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct PositionStruct
    {
        public Vector3 Position;
        public uint Time;
    }

    [AeroBlock]
    public struct RadiusStruct
    {
        public float Radius;
        public uint Time;
    }
}