using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.VendorPurchaseRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class VendorPurchaseRequest
    {
        public ulong Unk1;
        public EntityId Buyer;
        public ulong ProductID;
        public ulong PriceID;

        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 0x01)] // FIXME: The check should be != 0
        public uint ScuffedVendorID; // Half of the ulong...?

        public byte HaveUnk3;
        [AeroIf(nameof(HaveUnk3), 0x01)] // FIXME: The check should be != 0
        public uint VendorRemoteID;

        public byte HaveUnk4;
        [AeroIf(nameof(HaveUnk4), 0x01)] // FIXME: The check should be != 0
        [AeroString] public string Unk4;
    }
}