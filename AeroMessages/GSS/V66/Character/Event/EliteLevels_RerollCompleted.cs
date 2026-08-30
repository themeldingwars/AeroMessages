using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.EliteLevels_RerollCompleted, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class EliteLevels_RerollCompleted
    {
        [AeroArray(typeof(byte))]
        public EliteAvailableUpgradeInfo[] AvailableUpgrades;

        public byte Unk1;
    }
}