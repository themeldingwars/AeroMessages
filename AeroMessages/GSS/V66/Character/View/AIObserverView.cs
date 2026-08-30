using Aero.Gen.Attributes;
using Aero.Protocol;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterView.AIObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class AIObserverView
    {
        private ulong ListenerId;
        private uint SpawnTime;
        private WalletData Wallet;
        private ScopeBubbleInfoData ScopeBubbleInfo;
    }
}