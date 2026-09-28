using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SlotVisualMultiRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SlotVisualMultiRequest
    {
        public int LoadoutId;
        public uint ConfigId; // 0 PvE, 1 PvP

        [AeroArray(typeof(byte))]
        public LoadoutConfig_Visual[] Visuals;

        [AeroArray(typeof(byte))]
        public VisualPurchaseData[] Purchases;
    }

    [AeroBlock]
    public struct VisualPurchaseData
    {
        public uint SdbId;
        [AeroString] public string UnlockContext;
        public uint PriceId;
        public uint CurrencyRemoteId;
        [AeroString] public string CurrencyType;
        public uint Amount;
        public uint Unk7;
    }
}