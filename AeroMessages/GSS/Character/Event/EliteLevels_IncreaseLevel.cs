using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.EliteLevels_IncreaseLevel, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class EliteLevels_IncreaseLevel
    {
        public uint Unk1;
        public uint Unk2;

        [AeroArray(typeof(byte))]
        public EliteAvailableUpgradeInfo[] AvailableUpgrades;

        public uint Unk4;
    }
}