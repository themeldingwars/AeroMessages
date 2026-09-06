using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.UpdateDevZoneInfo, MatrixVersion.V32, MatrixVersion.V32)]
    public partial class UpdateDevZoneInfo
    {
        public DevZoneInfoData DevZoneInfo;
    }
}