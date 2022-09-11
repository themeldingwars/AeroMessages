using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 21)]
    public partial class DEVExecuteCommand
    {
        public byte Unk1;
        [AeroArray(typeof(byte))] [AeroString] public string[] Unk2;
    }
}