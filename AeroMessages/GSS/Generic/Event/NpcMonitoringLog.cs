using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.NpcMonitoringLog, GssVersion.V1, GssVersion.V67)]
    public partial class NpcMonitoringLog
    {
        [AeroString] public string Prefix;
        public byte LogLevel;
        [AeroString] public string Text;
    }
}