using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 36)]
    public partial class Announce
    {
        [AeroString] public string Type; // 'sysmsg'
        [AeroString] public string Data;
    }
}