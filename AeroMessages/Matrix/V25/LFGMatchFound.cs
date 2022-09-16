using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 65)]
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