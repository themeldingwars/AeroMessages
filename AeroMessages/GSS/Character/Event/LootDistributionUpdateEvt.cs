using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.LootDistributionUpdateEvt, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class LootDistributionUpdateEvt
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public LootDistributionData[] Unk2;
        public uint Unk3;
    }
}