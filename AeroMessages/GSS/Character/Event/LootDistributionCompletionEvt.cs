using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.LootDistributionCompletionEvt, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class LootDistributionCompletionEvt
    {
        public uint DistributionId;
        public LootDistributionState RollType;
        [AeroArray(typeof(byte))] public LootDistributionData[] Participants;
        public ulong Winner;
    }
}