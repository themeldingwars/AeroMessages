using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 234)]
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