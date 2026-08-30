using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.SendEmergencyChat, MatrixVersion.V25, MatrixVersion.V26)]
    public partial class SendEmergencyChat
    {
        [AeroString] public string Text;
        public uint Unk2;
    }
}