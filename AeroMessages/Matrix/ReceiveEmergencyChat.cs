using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ReceiveEmergencyChat, MatrixVersion.V25, MatrixVersion.V32)]
    public partial class ReceiveEmergencyChat
    {
        public EntityId AuthorId;
        [AeroString] public string DisplayName;
        [AeroString] public string Message;
        public uint ChatIconFlags; // Why a full uint tho
    }
}