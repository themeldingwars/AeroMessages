using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.BagInventorySettings, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class BagInventorySettings
    {
        public byte HaveData;
        [AeroIf(nameof(HaveData), 1)]
        [AeroBlob] public byte[] Data;
    }
}