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

        public byte HaveRemoteVendorId;
        [AeroIf(nameof(HaveRemoteVendorId), 0x01)] // FIXME: The check should be != 0
        public uint RemoteVendorId;

        public byte HaveVendorId;
        [AeroIf(nameof(HaveVendorId), 0x01)] // FIXME: The check should be != 0
        public uint VendorId;

        public byte HaveUnk4;
        [AeroIf(nameof(HaveUnk4), 0x01)] // FIXME: The check should be != 0
        [AeroString] public string Unk4;
    }
}