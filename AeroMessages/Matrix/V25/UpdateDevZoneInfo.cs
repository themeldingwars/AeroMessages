using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.UpdateDevZoneInfo, MatrixVersion.V26, MatrixVersion.V26)]
    public partial class UpdateDevZoneInfo
    {
        public DevZoneInfoData DevZoneInfo;
    }
}