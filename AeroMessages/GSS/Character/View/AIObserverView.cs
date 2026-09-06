using Aero.Gen.Attributes;
using Aero.Protocol;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterView.AIObserverView, GssVersion.V1, GssVersion.V74)]
    public partial class AIObserverView
    {
        private ulong ListenerId;
        private uint SpawnTime;
        private WalletData Wallet;
        private ScopeBubbleInfoData ScopeBubbleInfo;
    }
}