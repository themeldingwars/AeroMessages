using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Melding
{
    [AeroBlock]
    public struct Melding_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            PerimeterSetName = 0x00,
            ActiveData = 0x01,
            ScopeBubbleInfo = 0x02,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.PerimeterSetName)]
        [AeroString]
        public string PerimiterSetName;

        [AeroIf(nameof(Idx), ShadowFieldIndex.ActiveData)]
        public ActiveDataStruct ActiveData;

        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;
    }

    //[Aero]
    //[AeroMessageId(MsgType.GSS, MsgSrc.Message, 16, 1)]
    public partial class Melding_ObserverView_Update
    {
        [AeroArray(-6)]
        public Melding_ObserverView_ShadowFieldUpdate[] Updates;
    }
}