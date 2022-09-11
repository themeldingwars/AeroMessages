using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 28)]
    public partial class UpdateDevZoneInfo
    { 
        public DevZoneInfoData DevZoneInfo;
    }
}