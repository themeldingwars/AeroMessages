using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.MeldingBubble
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 18, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 18, 3)]
    public partial class MeldingBubble_ObserverView
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