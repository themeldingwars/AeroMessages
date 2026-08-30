using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.EliteLevels_UpgradesChanged, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class EliteLevels_UpgradesChanged
    {
        public uint Unk1;

        [AeroArray(typeof(byte))]
        public ElitePreviousUpgradeInfo[] PreviousUpgrades;

        public byte Unk3;
    }
}