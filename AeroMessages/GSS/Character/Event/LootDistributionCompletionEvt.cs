using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.LootDistributionCompletionEvt, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class LootDistributionCompletionEvt
    {
        public uint Unk1;
        public byte Unk2;
        [AeroArray(typeof(byte))] public LootDistributionData[] Unk3;
        public ulong Unk4;
    }
}