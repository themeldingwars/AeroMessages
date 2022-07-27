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
        public byte Unk1;
        [AeroString] public string Key1;
        [AeroString] public string Key2;
        [AeroString] public string Key3;
        [AeroString] public string JSON;
    }
}