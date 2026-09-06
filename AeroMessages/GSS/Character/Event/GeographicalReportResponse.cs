using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.GeographicalReportResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class GeographicalReportResponse
    {
        public uint ScanId;
        public Vector3 Position;
        public byte Valid; // If 0, game will ignore composition and present as "empty".
        [AeroArray(typeof(byte))] public ResourceCompositionData[] Composition;
    }
}