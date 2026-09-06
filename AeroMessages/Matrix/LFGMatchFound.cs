using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.LFGMatchFound, MatrixVersion.V14, MatrixVersion.V32)]
    public partial class LFGMatchFound
    {
        public ulong MatchId;
        public uint LFGCategoryId;
        public EntityId LeaderId;
        [AeroString] public string LeaderName;

        [AeroArray(typeof(byte))]
        [AeroString] public string[] Unk5;
    }
}