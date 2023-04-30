using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 21)]
    public partial class DEVExecuteCommand
    {
        public enum DevCommandType : byte
        {
            Matrix = 0, // mxcmd
            GSS = 1, // gscmd
            Social = 2, // socmd
            Stats = 3 // statscmd
        }
        public DevCommandType Type;
        [AeroArray(typeof(byte))] [AeroString] public string[] Arguments;
    }
}