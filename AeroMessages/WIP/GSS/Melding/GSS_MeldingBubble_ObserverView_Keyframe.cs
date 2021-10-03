using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.MeldingBubble
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 18, 3)]
    public partial class MeldingBubble_ObserverView_Keyframe
    {
        public PositionStruct Position;
        public RadiusStruct Radius;
        public byte BubbleType;
        public byte FxFlags;
        public ScopeBubbleInfoData ScopeBubbleInfo;
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