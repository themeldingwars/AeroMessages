using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.MeldingBubble
{
    [AeroBlock]
    public struct MeldingBubble_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            Position        = 0x00,
            Radius          = 0x01,
            BubbleType      = 0x02,
            FxFlags         = 0x03,
            ScopeBubbleInfo = 0x04,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Position)]
        public PositionStruct Position;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Radius)]
        public RadiusStruct Radius;
        [AeroIf(nameof(Idx), ShadowFieldIndex.BubbleType)]
        public byte BubbleType;
        [AeroIf(nameof(Idx), ShadowFieldIndex.FxFlags)]
        public byte FxFlags;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [Aero]
    public partial class MeldingBubble_ObserverView_Update
    {
        [AeroArray(-10)]
        public MeldingBubble_ObserverView_ShadowFieldUpdate[] Updates;
    }
}