using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.LootDistributionUpdateEvt, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class LootDistributionUpdateEvt
    {
        public uint DistributionId;
        [AeroArray(typeof(byte))] public LootDistributionData[] Participants;
        public uint Unk3;
    }
}