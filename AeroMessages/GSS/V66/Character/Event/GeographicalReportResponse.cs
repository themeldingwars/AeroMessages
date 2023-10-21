using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 139)]
    public partial class GeographicalReportResponse
    {
        public uint ScanId;
        public Vector3 Position;
        public byte Valid; // If 0, game will ignore composition and present as "empty".
        [AeroArray(typeof(byte))] public ResourceCompositionData[] Composition;
    }
}