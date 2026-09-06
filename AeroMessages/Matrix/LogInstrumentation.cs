using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.LogInstrumentation, MatrixVersion.V18, MatrixVersion.V32)]
    public partial class LogInstrumentation
    {
        public enum LogInstrumentationType : byte
        {
            Event = 0,
            Error = 1,
            Crash = 2,
            UI = 3
        }
        public LogInstrumentationType Type;
        [AeroString] public string Action;
        [AeroString] public string Message;
        [AeroString] public string UIComponentName;
        [AeroString] public string Data; // Can be JSON
    }
}