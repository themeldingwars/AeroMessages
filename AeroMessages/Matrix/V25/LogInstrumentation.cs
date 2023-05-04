using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 31)]
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