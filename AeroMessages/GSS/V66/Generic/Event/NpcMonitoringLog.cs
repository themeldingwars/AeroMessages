using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 53)]
    public partial class NpcMonitoringLog
    {
        [AeroString] public string Prefix;
        public byte LogLevel;
        [AeroString] public string Text;
    }
}