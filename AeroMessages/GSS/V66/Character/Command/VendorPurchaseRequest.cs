using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 238)]
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