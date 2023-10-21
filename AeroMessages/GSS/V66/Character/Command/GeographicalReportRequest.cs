using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 184)]
    public partial class GeographicalReportRequest
    {
        public enum ClientGeographicalReportRequestFeedback : byte
        {
            OK = 0,
            NOTHUMPINGZONE = 1,
            INVALIDSURFACE = 2,
        }
        public ClientGeographicalReportRequestFeedback Feedback;
    }
}