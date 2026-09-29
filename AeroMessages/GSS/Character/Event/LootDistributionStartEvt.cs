using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.LootDistributionStartEvt, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class LootDistributionStartEvt
    {
        public uint DistributionId;
        [AeroArray(typeof(byte))] public LootDistributionData[] Participants;
        public uint ExpirationTime;
        public uint ItemSdbId;
        public uint Quantity;
        public uint Unk6;
        [AeroArray(typeof(byte))] public uint[] HiddenModules;
        public byte Unk8;
        public LootDistributionType Type;
    }
}