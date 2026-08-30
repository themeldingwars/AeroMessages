using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.BagInventorySettings, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class BagInventorySettings
    {
        public byte HaveUnk1;
        [AeroIf(nameof(HaveUnk1), 1)]
        public UShortBlobData Unk1;
    }

    [AeroBlock]
    public struct UShortBlobData
    {
        [AeroArray(typeof(ushort))]
        public byte[] Data;
    }
}