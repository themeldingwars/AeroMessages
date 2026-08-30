using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.MatchQueueUpdate, MatrixVersion.V3, MatrixVersion.V26)]
    public partial class MatchQueueUpdate
    {
        public uint Unk1;
        public ushort Unk2;
    }
}